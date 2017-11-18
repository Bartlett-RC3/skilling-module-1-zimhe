using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session2 : MonoBehaviour {

    //varibles
    public int myNumber = 2;
    public bool questionTime=true;
    int myVariableQuestionTime;

    string[] fruits = { "banana", "apple", "mango", "blueberry" };
    List<int> evenNumbers = new List<int>();
    int[] evenNumbersSmart = new int[10];

    //list to store Humans
   


    // Use this for initialization
    void Start() {

        //variable Name is equal to either 1 or 0 based on the value of questionTime
        myVariableQuestionTime = (questionTime) ? 1 : 0;
        Debug.Log("The value of myVariableQuestionTime is" + myVariableQuestionTime);

      
        if (myNumber == 2)
        {
            Debug.Log("Your number is equal to 2.");
        }else
        {
            Debug.Log("your number is not equal to 2.");
        }
        //Question concatenation
        if (myNumber == 2 && questionTime == false)
        {
            Debug.Log("Your number is 2 and QT is false");
        }

        // question or statement
        if (myNumber == 2 || questionTime == false)
        {
            Debug.Log("It may be that your number is 2 or it may be that QT is false");
        }
        //loops
        Debug.Log("fruit in list at position 1 is :" + fruits[0]);
        // for loop statement (start value,how this ends, incrementation)
        for (int i = 0; i <= fruits.Length; i = i + 1)
        {
            Debug.Log("Fruit at position" + i + "is " + fruits[i]);
        }

        // add 10 even number from 0 to 20 
        for (int i = 0; i < 20; i = i+2 )
        {
            evenNumbers.Add(i);
            evenNumbersSmart[i / 2] = i;
        }

        // Print the list
        for(int i=0; i<evenNumbers.Count; i++)// i = i+1,i++
        {
            Debug.Log("Number is;" + evenNumbers[i]);

        }

        List<int> myoneHundredNumbers = new List<int>();


        // while loop
        List<int> oddNumbers = new List<int>();
        int counter = 1;
        while(counter < 100)
        {
            oddNumbers.Add(counter);
            counter = counter + 2;
        }
        for(int i = 0; i<oddNumbers.Count; i++)
        {
            Debug.Log("Odd number ;" + oddNumbers[i]);
        }
	}

	

	// Update is called once per frame
	void Update () {
		if (questionTime == false)
        {
            Debug.Log("questionTime is Flase");
        }else
        {
            Debug.Log("questionTime is true");
        }
	}
}
