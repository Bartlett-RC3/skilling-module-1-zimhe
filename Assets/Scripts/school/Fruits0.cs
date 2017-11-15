using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits0 : MonoBehaviour {
    string[] cars = { "banana", "apple", "mango", "blueberry" };

    // Use this for initialization
    void Start () {

        for (int i = 0; i <= cars.Length; i = i + 1)
        {
            Debug.Log("cars at position" + i + "is " + cars[i]);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
