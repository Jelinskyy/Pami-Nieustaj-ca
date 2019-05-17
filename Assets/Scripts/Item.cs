using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : Interactable
{
    public GameObject Circle1;
    public GameObject Circle2;

    void Start()
    {
    }

    public void pickUp()
    {
        FindObjectOfType<ItemFrame>().pickUp(gameObject, gameObject.GetComponent<SpriteRenderer>().sprite);

        Circle1.SetActive(false);
        Circle2.SetActive(true);
    }

    public override void DoInteraction()
    {
        pickUp();
    }
}
