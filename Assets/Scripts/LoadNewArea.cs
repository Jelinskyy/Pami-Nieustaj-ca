using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNewArea : Interactable
{
    public string levelToLoad;
    public Vector3 StartPoint;
    private CameraController Camera;
    private PlayerConroler Player;

    public void DoInteraction()
    {
        Camera = FindObjectOfType<CameraController>();
        Player = FindObjectOfType<PlayerConroler>();
        Camera.transform.position = new Vector3(StartPoint.x, StartPoint.y, -10);
        Player.transform.position = StartPoint;
        Application.LoadLevel(levelToLoad);
        GameObject.Find("/CanvasBox/Canvas/InteractionText").SetActive(false);
        restartState();
    }

    public virtual void restartState()
    {

    }
}


