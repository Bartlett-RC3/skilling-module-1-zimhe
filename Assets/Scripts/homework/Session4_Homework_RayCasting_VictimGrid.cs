using System.Collections;
using System.Collections.Generic;
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

   

    // Use this for initialization
    IEnumerator VictimGrid()
    {
        for (int i = 0; i < VictimNumber; i++)
        {
            yield return new WaitForSeconds(0.01f);

        
        Vector3 columnPosition = new Vector3(Random.Range(GridX[0], GridX[1]), Random.Range(GridY[0], GridY[1]), 0);
        Quaternion columnRotation = new Quaternion(0, 0, 0, 0);

        GameObject Victim = Instantiate(VictimCube, columnPosition, columnRotation);
            
       
            Victim .name = "newVictim" + i;
        }
    }

    IEnumerator Start()
    {
        GridX[0] = -25;
        GridX[1] = 25;
        GridY[0] = -25;
        GridY[1] = 25;

       

        //CubeMaterial.color = Color.red;

        yield return StartCoroutine(VictimGrid());

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


        if (Input.GetKey(KeyCode.W))
        {
            if (Physics.Raycast(transform.position, castedRayDirectionUp, out ObjectUp, 1f))
            {
                
                Debug.Log(ObjectUp.transform.gameObject.name + " IS FOUND, DESTROY!!!!");
                Destroy(ObjectUp.transform.gameObject);
                BiuBiuBiu.GetComponent<AudioSource>().Play();
            }
            CubeMaterial.color = Color.red;
            MurderCube.transform.Translate(Vector3.up);
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (Physics.Raycast(transform.position, castedRayDirectionDown, out ObjectDown, 1f))
            {
                
                Debug.Log(ObjectDown.transform.gameObject.name + " IS FOUND, DESTROY!!!!");
                Destroy(ObjectDown.transform.gameObject);
                BiuBiuBiu.GetComponent<AudioSource>().Play();
            }
            CubeMaterial.color = Color.red;
            MurderCube.transform.Translate(Vector3.down);
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (Physics.Raycast(transform.position, castedRayDirectionRight, out ObjectRight, 1f))
            {
                
                Debug.Log(ObjectRight.transform.gameObject.name + " IS FOUND, DESTROY!!!!");
                Destroy(ObjectRight.transform.gameObject);
                BiuBiuBiu.GetComponent<AudioSource>().Play();
            }
            CubeMaterial.color = Color.red;
            MurderCube.transform.Translate(Vector3.right);
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (Physics.Raycast(transform.position, castedRayDirectionLeft, out ObjectLeft, 1f))
            {
                
                Debug.Log(ObjectLeft.transform.gameObject.name + " IS FOUND, DESTROY!!!!");
                Destroy(ObjectLeft.transform.gameObject);
                BiuBiuBiu.GetComponent<AudioSource>().Play();
            }
            CubeMaterial.color = Color.red;
            MurderCube.transform.Translate(Vector3.left);
        }
    }
}
