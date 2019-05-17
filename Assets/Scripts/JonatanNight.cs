using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JonatanNight : Talk
{
    public GameObject JonatanVector;
    public GameObject BedVector;

    public override void DoInteraction()
    {
        switch (state)
        {
            case 0:
                {
                    FindObjectOfType<DialogueMenager>().StartDialogue(dialogue[0]);
                    JonatanVector.SetActive(false);
                    BedVector.GetComponent<SpriteRenderer>().material.shader = Shader.Find("Sprites/Diffuse");
                    BedVector.SetActive(true);
                    state++;
                    break;
                }
            case 1:
                {
                    FindObjectOfType<DialogueMenager>().StartDialogue(dialogue[1]);
                    break;
                }
        }
    }
}
