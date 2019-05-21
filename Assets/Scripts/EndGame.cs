using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : Interactable
{
    private Plug plug;
    public BackMainMenu backMain;

    void Start()
    {
        plug = GameObject.FindObjectOfType<Plug>();
        massage = "Iść Spać";
    }

    public void DoInteraction()
    {
        gameObject.SetActive(false);
        GameObject.FindObjectOfType<GameMenager>().turnOff();
        GameObject.FindObjectOfType<JonatanNight>().state = 0;
        Application.LoadLevel("mainMenu");
    }
}
