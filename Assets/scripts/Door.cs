using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject door;
   

   

  

   
  

    void OnTriggerExit(Collider other)
    {
        // Vérifier si le personnage quitte la zone de détection
        if (other.tag == "Player" )
        {
            door.SetActive(true);
        }

    }

    
}
