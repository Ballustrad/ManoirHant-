using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Door : MonoBehaviour
{
    public GameObject door;
    public DoorDetection doorDetection;

    private void Update()
    {
        if(doorDetection.inrange == true && (Keyboard.current.eKey.wasPressedThisFrame))
        {
            door.SetActive(false);
        }
    }


}
