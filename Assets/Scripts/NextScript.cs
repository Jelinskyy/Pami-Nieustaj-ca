using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScript : MonoBehaviour
{
    private DialogueMenager dialogue;
    void Start()
    {
        dialogue = FindObjectOfType<DialogueMenager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Next"))
        {
            dialogue.SendMessage("DisplayNextSentence");
        }

        if (Input.GetButtonDown("Skip"))
        {
            dialogue.SendMessage("EndDialogue");
        }
    }
}
