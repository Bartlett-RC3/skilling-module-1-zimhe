//liberarysb //references
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//where code lives
public class Session1 : MonoBehaviour {

    // 1.Veriables
    // Scope -- type -- name --value

    // Numbers
    public int myFirstIntegerNumber = 101;//make sure you end with ;
    float myFirstFloatNunmber = 1.75f;

    //Text
    public string myFirstString = "my text is somewhere.";

    // logical variable
    bool myFirstBoolean = true;


    // Data structures
    // Scope -- Type -- Values

    // 3.a.arrays
    public int[] myintegrerArray = { 1, 2, 3, 4, 5 };
    public float[] myFloatArray = new float[5];

    // 3.b.lists
    public List<int> myIntegerList = new List<int>();


    // 2. functions
    // Scope -- Type -- Variables -- Body(Instructions)

    // Use this for initialization
    void Start () {
        Debug.Log("Addtion of 5 and 3 is :"+ AddtionOfNumbers(5,3));
        myFloatArray[2] = 3.2f;
        myFloatArray[3] = 5.6f;
        myFloatArray[4] = 9.2f;

        myIntegerList.Add(1);
        myIntegerList.Add(2);
        myIntegerList.Add(3);    
	}


    // Update is called once per frame
    void Update() {
        Debug.Log("Hello world");
        }

    int AddtionOfNumbers(int number1, int number2)
    {
        int addtionResult = number1 + number2;
        return addtionResult;
    }
}
