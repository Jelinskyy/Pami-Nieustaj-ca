using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jonatan : Talk
{
    public GameObject JonatanVector;
    public GameObject BottleVector;
    public GameObject Door;
    public GameObject exit;
    public GameObject Currentitem;
    public GameObject Bottle;

    public override void DoInteraction()
    {
        switch(state)
        {
            case 0:
                {
                    FindObjectOfType<DialogueMenager>().StartDialogue(dialogue[0]);
                    JonatanVector.SetActive(false);
                    BottleVector.SetActive(true);
                    state++;
                    break;
                }
            case 1:
                {
                    if (FindObjectOfType<ItemFrame>().CurrentItem == Bottle)
                    {
                        exit.SetActive(true);
                        JonatanVector.SetActive(false);
                        state++;
                        FindObjectOfType<DialogueMenager>().StartDialogue(dialogue[1]);
                        FindObjectOfType<ItemFrame>().SetItem(null);
                        Currentitem.GetComponent<Image>().enabled=false;
                    }
                    else
                    {
                        FindObjectOfType<DialogueMenager>().StartDialogue(dialogue[0]);
                    }
                    break;
                }
            case 2:
                {
                    FindObjectOfType<DialogueMenager>().StartDialogue(dialogue[2]);
                    break;
                }
        }
    }
}
