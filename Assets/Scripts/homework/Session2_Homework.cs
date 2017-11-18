using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using myhomework;


public class Session2_Homework : MonoBehaviour
{

    public int j;

    Session1_Homework s1 = new Session1_Homework();


    private List<DogClass> mydog = new List<DogClass>();


    // Use this for initialization
    void Start ()
    {
        DogClass Mr8 = new DogClass(1, 0.6f, 20f, true, "Mr8", "Husky", "White");
        DogClass Kahn = new DogClass(3, 0.3f, 5f, true, "Kahn", "Teddy", "brown");
        DogClass Forty = new DogClass(2, 0.5f, 10f, false, "Forty", "Hybrid", "Yellow");
        DogClass Leo = new DogClass(7, 0.8f, 22f, true, "Leo", "Golden Retriever", "Golden");


        mydog.Add(Mr8);
        mydog.Add(Kahn);
        mydog.Add(Forty);
        mydog.Add(Leo);

        Debug.Log("I have " + mydog.Count + " dogs, they are " + mydog[0].Name  + ", "+mydog[1].Name +", " + mydog[2] .Name +" and "+ mydog[3].Name );

        for (int a = 0; a < mydog.Count; a++)
        {

           
            Debug.Log(mydog[a].Name  + " is a " + mydog[a].Breeds + " and its color is " + mydog[a].Color + ", it is " +
                      mydog[a].Age + " years old.");
        }



        //Write a for loop
        for (int i = 0; i < s1.students.Count; i++)
	    {
	        Debug.Log("Student "+(i+1)+" of RC3 is " + s1.students[i]);
	    }


	    if (j < s1.students.Count)
	    {
	        Debug.Log(s1.students[j] + " is an RC3 student.");
	    }
	    else
	    {
	        Debug.Log("There are no " + j + " students in RC3");
	    }


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
