using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Session4_Homework_RayCasting_VictimGrid : MonoBehaviour
{

    public Transform MurderCube;
    public Material CubeMaterial;
    public GameObject VictimCube;
    public GameObject  BiuBiuBiu;

    public int VictimNumber;

    private int[] GridX = new int[2];
    private int[] GridY = new int[2];
    private Vector3[,] VictimPos = new Vector3[51, 51];
    
    List< Vector3 > VictimPosList=new List<Vector3 >();
    Quaternion VictimRotation = new Quaternion(0, 0, 0, 0);
    List<GameObject> VictimList = new List<GameObject> ();

    //private Vector3 VictimPos = new Vector3();




    // Use this for initialization
    IEnumerator VictimGrid()
    {
        for (int i = 0; i < 51; i++)
        { 
            for(int j= 0;j<51; j++)
            {       
                yield return new WaitForSeconds(0.01f);
                
                //get a random index form VictimPosList
                int index = Random.Range(0, VictimPosList.Count);
                //Generate Object
                
                GameObject Victim = Instantiate(VictimCube, VictimPosList[index], VictimRotation);
                //Remove Used Position From List
                VictimPosList.Remove(VictimPosList[index]);
                Victim.name = "New Victim " + i + " _ " + j;
                VictimList.Add(Victim);
                
            }
        }
        









        //Victim .name = "newVictim" + i;

    }

    IEnumerator Start()
    {
        for (int i = -25; i <= 25; i++)
        {
            for (int j = -25; j <= 25; j++)
            {
                VictimPos[i + 25, j +25] = new Vector3 (i, j, 0);
                VictimPosList.Add(VictimPos[i + 25, j +25]);
            }
        }
        yield return StartCoroutine(VictimGrid());

        /*float Block_X1 = MurderCube.transform.position.x + 5;
        float Block_X2 = MurderCube.transform.position.x - 5;
        float Block_Y1 = MurderCube.transform.position.y + 5;
        float Block_Y2 = MurderCube.transform.position.y - 5;*/
    }


    // Update is called once per frame
     void Update () {
        //Ray Direction
        Vector3 castedRayDirectionUp = transform.TransformDirection(Vector3.up);
        Vector3 castedRayDirectionDown = transform.TransformDirection(Vector3.down);
        Vector3 castedRayDirectionLeft = transform.TransformDirection(Vector3.left);
        Vector3 castedRayDirectionRight = transform.TransformDirection(Vector3.right);

        //Object around
        RaycastHit ObjectUp;
        RaycastHit ObjectDown;
        RaycastHit ObjectLeft;
        RaycastHit ObjectRight;


        CubeMaterial.color = Color.yellow;



        /*float  Block_X1=MurderCube.transform.position.x +5;
        float Block_X2 = MurderCube.transform.position.x - 5;
        float Block_Y1 = MurderCube.transform.position.y + 5;
        float Block_Y2 = MurderCube.transform.position.y - 5;


        for (float i = Block_Y2; i < Block_Y1; i++)
        {
            Vector3 blockPos = new Vector3(Block_X2, i, 0);
            Quaternion blockQua = new Quaternion(0, 0, 0, 0);


            GameObject Victim = Instantiate(VictimCube, blockPos, blockQua);

        }*/

        


        if (Input.GetKey(KeyCode.W))
        {
            if (Physics.Raycast(transform.position, castedRayDirectionUp, out ObjectUp, 5f))
            {
                
                Debug.Log(ObjectUp.transform.gameObject.name + " IS FOUND, DESTROY!!!!");
                Destroy(ObjectUp.transform.gameObject);
                BiuBiuBiu.GetComponent<AudioSource>().Play();
               
            }
            CubeMaterial.color = Color.red;
            MurderCube.transform.Translate(Vector3.up*0.3f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (Physics.Raycast(transform.position, castedRayDirectionDown, out ObjectDown, 5f))
            {
                
                Debug.Log(ObjectDown.transform.gameObject.name + " IS FOUND, DESTROY!!!!");
                Destroy(ObjectDown.transform.gameObject);
                BiuBiuBiu.GetComponent<AudioSource>().Play();
            }
            CubeMaterial.color = Color.red;
            MurderCube.transform.Translate(Vector3.down*0.3f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (Physics.Raycast(transform.position, castedRayDirectionRight, out ObjectRight, 5f))
            {
                
                Debug.Log(ObjectRight.transform.gameObject.name + " IS FOUND, DESTROY!!!!");
                Destroy(ObjectRight.transform.gameObject);
                BiuBiuBiu.GetComponent<AudioSource>().Play();
            }
            CubeMaterial.color = Color.red;
            MurderCube.transform.Translate(Vector3.right*0.3f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (Physics.Raycast(transform.position, castedRayDirectionLeft, out ObjectLeft, 5f))
            {
                
                Debug.Log(ObjectLeft.transform.gameObject.name + " IS FOUND, DESTROY!!!!");
                Destroy(ObjectLeft.transform.gameObject);
                BiuBiuBiu.GetComponent<AudioSource>().Play();
            }
            CubeMaterial.color = Color.red;
            MurderCube.transform.Translate(Vector3.left*0.3f);
        }
    }
}
