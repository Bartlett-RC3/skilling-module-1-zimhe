using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace myhomework { 


public class Session1_Homework : MonoBehaviour


{   
        
        //Declare a int variable and set a value
    private int integer = 30;

    //Declare a float variable and set a value
    private float float1 = 10.5f;

    //Declare a string variable and set a value
    private string string1 = "I am doing my homework ";

    //Declare and initialize an array
    private string[] RC3_Tutors = new string[3];

    //Declare and initialize a list
    public List<string> students = new List<string>(){"Ziming He", "Joyce Ren", "Ning Wang", "Linlin Cao",};

    //Create and initialize a Dictionary
    private Dictionary<int, string> Country = new Dictionary<int, string>();

    public Session1_Homework ( ){
        students.Add("Jialin Zhang");
        students.Add("Skyler Zhang");
        students.Add("Xiaoyu Wu");
        }

	// Use this for initialization
	public void Start ()
	{
	    Country.Add(0, "Beijing,China");
	    Country.Add(1, "Shanghai,China");
	    Country.Add(2, "Shenzhen,China");
	    Country.Add(3, "Guangzhou,China");

       
       

        RC3_Tutors[0] = "Tyson Hosmer ";
	    RC3_Tutors[1] = "Octavian Gheorghiu ";
	    RC3_Tutors[2] = "Dave Reeves ";

        //Create a function that prints the declared variables
        Debug.Log("I am at school and " + string1 + " Setting integer :" + integer + " Setting float :" + float1 + " Cool!!!!!");
        Debug .Log( "Our cool tutors are : "+RC3_Tutors [0]+", "+RC3_Tutors [1]+"and "+RC3_Tutors [2]);

        for (int i = 0; i < students.Count; i++)
	    {
	        
	        Debug.Log("Student " + (i+1) + " is " + students[i] + "," + "from " + Country[Random.Range(0,4)]);
            
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
}
