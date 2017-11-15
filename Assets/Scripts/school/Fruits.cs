using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : MonoBehaviour {


    string[] cars = { "banana", "apple", "mango", "blueberry"};

    void Start(){
        for (int i = 0; i <= cars.Length; i = i + 1)
        {
        Debug.Log("cars at position" + i + "is " + cars[i]);
        }
    }
}