using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : Interactable
{
    private Plug plug;

    void Start()
    {
        plug = GameObject.FindObjectOfType<Plug>();
        massage = "Iść Spać";
    }

    public void DoInteraction()
    {
        plug.turn();
        Application.Quit();
        gameObject.SetActive(false);
        GameObject.Find("/CanvasBox/Canvas/InteractionText").SetActive(false);
    }
}
