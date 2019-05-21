using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMenager : MonoBehaviour
{
    public GameMenager menago;

    public void exitGame()
    {
        Application.Quit();
    }

    public void startGame()
    {
        menago = GameObject.FindObjectOfType<GameMenager>();
        Application.LoadLevel("Main");
        if(menago!=null)
        {
            menago.turnOn();
        }
    }
}
