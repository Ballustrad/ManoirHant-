using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject itemToPickUp;
    public GameManager gameManager;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            itemToPickUp.SetActive(false);
            gameManager.keypickedUP = true;
         }
    }
}
