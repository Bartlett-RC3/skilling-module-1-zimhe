using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4_Homework_RayCastingMurder : MonoBehaviour {

    public Transform MurderCube;
    public Material CubeMaterial;


    // Use this for initialization
    void Start ()
    {

        CubeMaterial.color = Color.yellow ;

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

	    if (Input.GetKey(KeyCode.W))
	    {
	        if (Physics.Raycast(transform.position, castedRayDirectionUp, out ObjectUp, 1))
	        {
	            CubeMaterial.color = Color.red;
	            Debug.Log(ObjectUp.transform.gameObject.name + " IS FOUND, DESTROY!!!!");
	            Destroy(ObjectUp.transform.gameObject);

	        }
	        MurderCube.transform.Translate(Vector3.up);
	    }

	    if (Input.GetKey(KeyCode.S ))
	    {
	        if (Physics.Raycast(transform.position, castedRayDirectionDown , out ObjectDown , 1))
	        {
	            CubeMaterial.color = Color.red;
	            Debug.Log(ObjectDown .transform.gameObject.name + " IS FOUND, DESTROY!!!!");
	            Destroy(ObjectDown .transform.gameObject);

	        }
	        MurderCube.transform.Translate(Vector3.down );
	    }

	    if (Input.GetKey(KeyCode.D))
	    {
	        if (Physics.Raycast(transform.position, castedRayDirectionRight , out ObjectRight , 1))
	        {
	            CubeMaterial.color = Color.red;
	            Debug.Log(ObjectRight .transform.gameObject.name + " IS FOUND, DESTROY!!!!");
	            Destroy(ObjectRight .transform.gameObject);

	        }
	        MurderCube.transform.Translate(Vector3.right );
	    }

	    if (Input.GetKey(KeyCode.A ))
	    {
	        if (Physics.Raycast(transform.position, castedRayDirectionLeft, out ObjectLeft , 1))
	        {
	            CubeMaterial.color = Color.red;
	            Debug.Log(ObjectLeft.transform.gameObject.name + " IS FOUND, DESTROY!!!!");
	            Destroy(ObjectLeft .transform.gameObject);

	        }
	        MurderCube.transform.Translate(Vector3.left );
	    }


    }
}
