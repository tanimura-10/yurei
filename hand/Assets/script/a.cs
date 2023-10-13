using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tri : MonoBehaviour
{
    public bool a;
    // Start is called before the first frame update
    void Start()
    {
        a = false;
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        a = true;
        if(a == true)
        {
            Debug.Log("‚ ");
        }
    }
}
