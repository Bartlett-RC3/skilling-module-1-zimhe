using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4 : MonoBehaviour {
    //varibles
    public GameObject ColumnPrefab;

    public int columnNumber;

    //public float time = Time.time;

    IEnumerator DropColumns() { 

            yield return new WaitForSeconds(5);

       for (int i=0;i<=columnNumber ; i++) {
        
            Vector3 columnPosition = new Vector3(Random.Range(-9f, 9f), Random.Range(7f, 15f), Random.Range(-9f, 3f));
            Quaternion columnRotation =
                new Quaternion(Random.Range(0, 90), Random.Range(0, 90), Random.Range(0, 90), 1);
            GameObject newColumn = Instantiate(ColumnPrefab, columnPosition, columnRotation) ;

            yield return new WaitForSeconds(0.2f);
            newColumn.name = "newColumn" + i;




           }


       }

   IEnumerator Start()
    {
        yield return StartCoroutine(DropColumns() );
        Debug.Log("Done" + Time.time);
    }

}

