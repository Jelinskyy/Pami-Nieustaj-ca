using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talk : Interactable
{
    public Dialogue[] dialogue;
    public int state = 0;

    public override void DoInteraction()
    {
        FindObjectOfType<DialogueMenager>().StartDialogue(dialogue[state]);
    }
}
