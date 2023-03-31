using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorDetection : MonoBehaviour
{
    public GameObject Detec;
    public bool inrange = false;

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            inrange = true;
        }
    }

    
}
