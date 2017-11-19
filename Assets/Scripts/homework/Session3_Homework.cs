using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;


public class Session3_Homework : MonoBehaviour
{


    public Transform CuteCube;
    public GameObject CuteCube1;
    public Material CubeMaterial; 

    public int cubeNumber;
   
    float[] ScreenX=new float[2];
    float[] ScreenY = new float[2];

   
       
    
    

    IEnumerator ManyCubes()
    {
        yield return new WaitForSeconds(0.5f);

        //for (int i = 0; i <= cubeNumber; i++)
        {
            Vector3 columnPosition = new Vector3(Random.Range(ScreenX [0], ScreenX [1]), Random.Range(ScreenY [0], ScreenY [1]), 30);
            Quaternion columnRotation = new Quaternion(0,0,0,0);

            GameObject newCube = Instantiate(CuteCube1, columnPosition,columnRotation );

           // yield return new WaitForSeconds(3f);
            //newCube .name = "newCube" + i;
        }

    }
    IEnumerator Start()
    {
        ScreenX[0] = -35f;
        ScreenX[1] = 35f;
        ScreenY[0] = -20f;
        ScreenY[1] = 20f;


        //CubeMaterial.color = Color.red;

        

        yield return StartCoroutine(ManyCubes() );
        //CubeMaterial.color = Color.red;

        

    }

    // Update is called once per frame
    public void Update ()
	{
        //Movement range for cube
	    Vector3 flyAround = new Vector3(Random.Range(-4f, 4f), Random.Range(-4f, 4f), Random.Range(0, 0));


        if (CuteCube .position .x >= ScreenX[1])
	    {
	        if (CuteCube.position.y >= ScreenY[1])
	        {
	            CuteCube.transform.Translate(Vector3.down);
	            CuteCube.transform.Translate(Vector3.left);
            }
	        if (CuteCube.position.y <= ScreenY[0])
	        {
	            CuteCube.transform.Translate(Vector3.up);
	            CuteCube.transform.Translate(Vector3.left);
            }

            CuteCube.transform.Translate(Vector3.left);
	     }
	    else if (CuteCube .position .x <= ScreenX[0])
	    {
            if (CuteCube.position.y >= ScreenY[1])
            {
                CuteCube.transform.Translate(Vector3.down);
                CuteCube.transform.Translate(Vector3.right);
            }
            if (CuteCube.position.y <= ScreenY[0])
            {
                CuteCube.transform.Translate(Vector3.up);
                CuteCube.transform.Translate(Vector3.right);
            }
            CuteCube.transform.Translate(Vector3.right);
        }
        else if (CuteCube.position.y >= ScreenY[1])
	    {
	        if (CuteCube.position.x >= ScreenX[1])
	        {
	            CuteCube.transform.Translate(Vector3.left);
	            CuteCube.transform.Translate(Vector3.down);
            }
	        if (CuteCube.position.x <= ScreenX[0])
	        {
	            CuteCube.transform.Translate(Vector3.right);
	            CuteCube.transform.Translate(Vector3.down);
            }

                CuteCube.transform.Translate(Vector3.down);
	        
	    }
        else if (CuteCube.position.y <= ScreenY[0])
        {
            if (CuteCube.position.x >= ScreenX[1])
            {
                CuteCube.transform.Translate(Vector3.left);
                CuteCube.transform.Translate(Vector3.up);
            }
            if (CuteCube.position.x <= ScreenX[0])
            {
                CuteCube.transform.Translate(Vector3.right);
                CuteCube.transform.Translate(Vector3.up);
            }

            CuteCube.transform.Translate(Vector3.up);

        }
	    else if (CuteCube.position.x > ScreenX[0] && CuteCube.position.x < ScreenX[1] && CuteCube.position.y > ScreenY[0] && CuteCube.position.y < ScreenY[1])
	    {
	        CuteCube.transform.Translate(flyAround);     
            }
	    if (Time.time > 30)
	    {
	        StopAllCoroutines();
	    }
	    //Color changing.
	    if (Input.GetKey(KeyCode.Space) /*&& CubeMaterial.color == Color.red*/)
	    {
	        CubeMaterial.color = Color.black;
	    }
	  

	    else if (Input.GetKey( KeyCode.DownArrow) )
        {
            CubeMaterial.color = Color.blue;
        }
	    else if (Input.GetKey( KeyCode.UpArrow ))
	    {
	        CubeMaterial.color = Color.green;
	    }
	    else
	    {
	        CubeMaterial.color = Color.red;
	    }
    }





}

    



