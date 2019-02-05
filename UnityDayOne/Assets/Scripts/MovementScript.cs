using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float panSpeed = 200f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKeyDown(KeyCode.S))
        {
            pos.z -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            pos.z += panSpeed * Time.deltaTime;
        }
        transform.position = pos;
    }
}
