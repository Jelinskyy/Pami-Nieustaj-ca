using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowRender : MonoBehaviour
{
    private GameObject[] render;
    private GameObject[] interactives;
    public Shader shader;
    private int howLong, howMany;

    void Start()
    {
        shader = Shader.Find("Sprites/Diffuse");
        render = GameObject.FindGameObjectsWithTag("ToNight");
        interactives = GameObject.FindGameObjectsWithTag("Interactive");
        howLong = render.Length;
        howMany = interactives.Length;
        ToNight();
    }

    public void ToNight()
    {
        for (int i = 0; i < howLong; i++)
        {
            render[i].GetComponent<Renderer>().material.shader = shader;
        }
        for (int i = 0; i < howMany; i++)
        {
            interactives[i].GetComponent<Renderer>().material.shader = shader;
        }
        GameObject.Find("/Player").GetComponent<SpriteRenderer>().material.shader = shader;
    }
}
