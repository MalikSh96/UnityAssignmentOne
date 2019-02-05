using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandlerScript : MonoBehaviour
{
    public string _printText;
    public GameObject preFab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PrintText()
    {
        print(_printText);
    }

    public void PlaySound()
    {
        GetComponent<AudioSource>().Play();
    }

    public void instantiateCube()
    {
        Instantiate(preFab, transform.position, Quaternion.identity);
    }
}
