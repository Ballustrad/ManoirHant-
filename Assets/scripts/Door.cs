using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject door;
   

   

  

   
  

    void OnTriggerExit(Collider other)
    {
        // V�rifier si le personnage quitte la zone de d�tection
        if (other.tag == "Player" )
        {
            door.SetActive(true);
        }

    }

    
}
