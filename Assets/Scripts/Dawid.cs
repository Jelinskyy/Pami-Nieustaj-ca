using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dawid : Talk
{
    public GameObject DawidVector;
    public GameObject BucketVector;
    public GameObject exit;
    public GameObject exit2;
    public GameObject Currentitem;
    public GameObject Bucket;

    void Start()
    {
        Currentitem = GameObject.Find("/CanvasBox/Canvas/ItemFrame/CurrentItem");
    }

    public override void DoInteraction()
    {
        switch (state)
        {
            case 0:
                {
                    FindObjectOfType<DialogueMenager>().StartDialogue(dialogue[0]);
                    DawidVector.SetActive(false);
                    BucketVector.SetActive(true);
                    state++;
                    break;
                }
            case 1:
                {
                    if (Currentitem.GetComponent<ItemFrame>().CurrentItem == Bucket)
                    {
                        exit.SetActive(true);
                        DawidVector.SetActive(false);
                        state++;
                        FindObjectOfType<DialogueMenager>().StartDialogue(dialogue[1]);
                        FindObjectOfType<ItemFrame>().SetItem(null);
                        Currentitem.GetComponent<Image>().enabled = false;
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
            case 3:
                {
                    FindObjectOfType<DialogueMenager>().StartDialogue(dialogue[3]);
                    DawidVector.SetActive(false);
                    exit2.SetActive(true);
                    break;
                }
        }
    }

    public void statePlus()
    {
        state++;
    }
}
