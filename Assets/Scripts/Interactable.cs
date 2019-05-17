using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public string massage;

    public virtual void DoInteraction()
    {
        
    }

    public void GetMassage()
    {
        FindObjectOfType<PlayerInteraction>().SetMassage(massage);
    }
}
