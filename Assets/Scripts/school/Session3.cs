using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3 : MonoBehaviour {

    int counter = 0;
    public object cubreference;
    bool moveLeft = true;
    bool moveRight = false;
    
    // Use this for initialization
    void Start() {
        /*for (int i = 0; i < 1000; i++)
        {
            Vector3 cubeposition = new Vector3(i + 0.5f, 0, 0);
            Quaternion cubeRotaion = Quaternion.identity;
            GameObject newcube = Instantiate(cubreference, cubeposition, cubeRotaion);
        }*/
    }

    // Update is called once per frame
    void Update() {
        // Time in frames, not very useful because of variation.
        /*
        counter = counter + 1;
        if (counter % 30 == 00)
        {
            Debug.Log("Time in frame is:" + counter / 30);
        }
        Debug.Log("Frame:" + counter);
        Debug.Log("Actual time is : " + Time.deltaTime.ToString());
        */

        // Time in milliseconds, useful because it is precise
        Debug.Log("Actual time is:" + Time.deltaTime.ToString());

        // Move cube left and right by manually setting the Transfor component

        /*
        if (moveLeft == true)
        {
            if (counter < 30)
            {
                this.gameObject.GetComponent<Transform>().position = new Vector3(counter * (-1), 0, 0);
                counter++;
            } else
            {
                moveLeft = false;
                moveRight = true;
                counter = 0;
            }
        }
        if (moveRight == true)
        {
            gameObject.transform.Translate(Vector3.left);
            counter++;
        }
        else
        {
            moveLeft = true;
            moveRight = false;
            counter = 0;
        }
        */

        // use unity built in function to move the cube left and right
        if (moveLeft == true)
        {
            if(counter<=15)
            {
                gameObject.transform.Translate(Vector3.left);
                counter++;
            }
            else
            {
                moveLeft = false;
                moveRight = true;
                counter = 0;
            }
        }
        if (moveRight == true)
        {
            if (counter <= 15)
            {
                gameObject.transform.Translate(Vector3.right);
                counter++;
            }
            else
            {
                moveLeft = true;
                moveRight = false;
                counter = 0;
            }
        }
      


        // keyboard input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.transform.Rotate(new Vector3(0, 5, 0));
        }

        // Mouse input
        if (Input.GetMouseButton(0))
        {
            gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
        if (Input.GetMouseButton(1))
        {
            gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }

}
