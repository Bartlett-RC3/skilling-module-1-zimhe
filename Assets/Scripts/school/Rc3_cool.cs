using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rc3_cool : MonoBehaviour
{

    //Session 2 homework
    //

    //1.Write a function that uses a condition

    //Variable

    List<string> RC3 = new List<string>() {"Joyce ", "Caelyn ", "Ning ", "Zim "};
    List<string> NotRC3 = new List<string>() {"鹿晗", "张艺兴", "黄磊", "邓超"};

    public int i;

    // Use this for initialization
    void Start()
    {

        RC3.Add("Octavian ");
        RC3.Add("Tyson ");
        RC3.Add("Dave ");


        ConditionTest();
      
    }




    void ConditionTest()
    {
        int k = (i - RC3.Count);
        if(i<RC3.Count && i>=0 )
                {
                    Debug.Log(RC3[i] + "is COOL!");
                }
        else if (i > RC3.Count && i < (RC3.Count + NotRC3.Count))
        {
            Debug.Log(NotRC3[k]+"不酷！");
        }
        else
        {
            Debug.Log("We don't have that many people");
        }
    }
}


