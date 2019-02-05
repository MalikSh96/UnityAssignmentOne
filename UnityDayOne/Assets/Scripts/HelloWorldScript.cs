using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorldScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //print("Hello World");
        //Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown("f"))
        {
            print("Respect");
        }*/
        if (Input.GetKeyDown(KeyCode.F))
        {
            print("F, RESPECT");
        }
    }
}
