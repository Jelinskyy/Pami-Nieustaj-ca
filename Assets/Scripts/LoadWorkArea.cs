using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadWorkArea : Interactable
{
    public string levelToLoad;
    public GameObject WorkScrean;
    private Plug plug;

    void Start()
    {
        plug = FindObjectOfType<Plug>();
    }

    public void DoInteraction()
    {
        plug.turnWork();
    }

    public void GoWork()
    {
        gameObject.SetActive(false);
        WorkScrean.SetActive(true);
        GameObject.Find("/CanvasBox/Canvas/InteractionText").SetActive(false);
        GameObject.Find("/CanvasBox/Canvas").SetActive(false);
        plug.turn();
    }
}
