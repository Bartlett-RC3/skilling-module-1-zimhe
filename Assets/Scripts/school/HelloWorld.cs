using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {

    public string text = "Hello World";
    public bool turnOn = true;
    public float posX = 5.0f;
    public int intTest = 5;

    List<string> animals = new List<string>() { "dog","cat"};

    string[] names = new string[]{ "Jesse", "Freeman" };

    Dictionary<string, string> weapons = new Dictionary<string, string>();

	// Use this for initialization
	void Start () {

        animals.Add("fish");
        animals.Add("bird");

        animals.Remove("bird");

        print("List to Array length" + animals.ToArray().Length);

        //names[0] = "jesse";
        //names[1] = "ziming";


        text =  Test ("Calling Test()");//"Updated during Strat()";

        print (names[0]+" "+names[1]);
        print ("Total Names" + names.Length);

        print ("Total Animals" + animals.Count);
        print("Animal 1" + animals[0]);
        print("Last Animal" + animals[animals.Count-1]);

        weapons.Add("slot1", "sword");

        print ("Weapon in slot 1" + weapons["slot1"]);
        print("Slot 2 equiped" + weapons.ContainsKey("slot2"));
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    string Test(string value){
        return value + " Updated during Text()";
    }
}
