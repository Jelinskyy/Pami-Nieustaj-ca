using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenager : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Player;
    public GameObject Camera;
    private Plug plug;
    public Color col;
    private static bool isExist;

    void Start()
    {
        if (!isExist)
        {
            isExist = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        plug = GameObject.FindObjectOfType<Plug>();
    }

    public void turnOn()
    {
        Camera.SetActive(true);
        Player.SetActive(true);
        Canvas.SetActive(true);
        Camera.GetComponent<Camera>().backgroundColor = col;
        plug.lightOf();
        plug.turn();
        GameObject.Find("/Player").GetComponent<SpriteRenderer>().material.shader = Shader.Find("Sprites/Default"); ;
    }

    public void turnOff()
    {
        Camera.SetActive(false);
        Player.SetActive(false);
        Canvas.SetActive(false);
    }

    public void gameOff()
    {
        Application.Quit();
    }
}
