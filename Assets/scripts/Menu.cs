using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject Journal;



    public void Quit()
    {
        Application.Quit();
    }
    public void ButtonClicked(string _String)
    {

        if (_String == "Resume")
        {
            MainMenu.SetActive(false);

        }

        if (_String == "Journal")
        {
            Journal.SetActive(true);

        }

    }
}
