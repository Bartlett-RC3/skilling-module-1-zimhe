using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4_Homework : MonoBehaviour
{
    public GameObject ColorCube;
    public Material CubeMat;
  

    private List<Color> TatolColors = new List<Color>();


    private Color[] cubeColors = new Color[100];

    //(Random.Range(30, 150), Random.Range(30, 150), Random.Range(30, 150), Random.Range(30, 150))
    



    IEnumerator ChangingColor()
    {
        for (int i=0;i<cubeColors.Length; i++) { 
        yield return new WaitForSeconds(0.1f);

        CubeMat .color = cubeColors [i];

    
        Debug.Log(Time.time);
        }
    }

    IEnumerator Start()
    {
        for (int i = 0; i < cubeColors.Length ; i++)
        {
            cubeColors[i] = Random.ColorHSV(0f,1f,1f,1f,1f,1f); //new Color(Random.Range(30f, 200f), Random.Range(30f, 200f), Random.Range(30f, 200f),Random.Range(30f, 150f));
            TatolColors .Add(cubeColors [i]);

            
        }

        


        yield return StartCoroutine(ChangingColor());
    }
    

	
	// Update is called once per frame
	void Update () {
	    
    }
}
