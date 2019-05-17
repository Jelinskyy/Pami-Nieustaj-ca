using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AfterWork : MonoBehaviour
{
    private Plug plug;
    private GameObject Camera;
    private Dawid dawid;
    public GameObject Lights;
    public GameObject dir;
    public Color col;
    public ShadowRender Gen;

    void Start()
    {
        dawid = GameObject.FindObjectOfType<Dawid>();
        Camera = GameObject.Find("/Main Camera");
    }

    void Update()
    {
        if(Input.anyKey)
        {
            gameObject.SetActive(false);
            GameObject.FindObjectOfType<Canva>().OnCanva();
            plug = FindObjectOfType<Plug>();
            dir.SetActive(true);
            Gen.gameObject.SetActive(true);
            Lights.SetActive(true);
            dawid.statePlus();
            Camera.GetComponent<Camera>().backgroundColor = col;
        }
    }

    public void outWork()
    {
        GameObject.FindObjectOfType<Canva>().OnCanva();
        plug.turn();
    }
}
