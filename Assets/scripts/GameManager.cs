using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool keypickedUP;
    public GameObject keyIcon;
    public static GameManager instance;
    private void Awake()
    {
        instance = this;    
    }
    public void Update()
    {
        if (keypickedUP == true)
        {
            keyIcon.SetActive(true);
        }


        else
        {
            keyIcon.SetActive(false);
        }
    }


    
}
