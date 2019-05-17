using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    private GameObject currentInterObject = null;
    public GameObject InteractionTextBox;
    public GameObject DialogueBox;
    public Text InteractionText;
    private string massage;

    void Start()
    {
        InteractionText.text = "";
    }
    void Update()
    {
        if(Input.GetButtonDown ("Interaction"))
        {
            currentInterObject.SendMessage("DoInteraction"); 
        }
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.CompareTag ("Interactive"))
        {
            currentInterObject = other.gameObject;
            currentInterObject.SendMessage("GetMassage");
            InteractionText.text = ("Wciśnij F aby " + massage);
            InteractionTextBox.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Interactive"))
        {
            if (currentInterObject == other.gameObject)
            {
                currentInterObject = null;
                InteractionTextBox.SetActive(false);
                DialogueBox.SetActive(false);
            }
        }
    }

    public void SetMassage(string massage)
    {
        this.massage = massage;
    }
}
//Do? or not to do?