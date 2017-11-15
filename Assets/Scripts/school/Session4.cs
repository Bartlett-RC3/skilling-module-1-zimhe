using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4 : MonoBehaviour {
    //varibles
    public GameObject ColumnPrefab;
    IEnumerator _createColumnCoroutines;

	// Use this for initialization
	void Start () {
        _createColumnCoroutines = DropColumns();
	}
	
	// Update is called once per frame
	void Update ()
	{
	    StartCoroutine(_createColumnCoroutines);
	    Debug.Log(Time.time);
	    if (Time.time > 5)
	    {
	        StopCoroutine(_createColumnCoroutines);
	        StopAllCoroutines();
	    }
	}

    //Coroutienes
    IEnumerator DropColumns()
    {
        
        {
            yield return new WaitForSeconds(5);
            Vector3 columnPosition = new Vector3(Random.Range(-9f, 9f), Random.Range(7f, 15f), Random.Range(-9f, 3f));
            Quaternion columnRotation =
                new Quaternion(Random.Range(0, 90), Random.Range(0, 90), Random.Range(0, 90), 1);
            GameObject newColumn = Instantiate(ColumnPrefab, columnPosition, columnRotation);
            yield return new WaitForSeconds(5);
        }
    }
}
