using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemFrame : MonoBehaviour
{
    public GameObject CurrentItem;
    public GameObject InteractionTextBox;

    public void SetItem(GameObject Item)
    {
        CurrentItem = Item;
    }

    public void pickUp(GameObject Item, Sprite sprite)
    {
        gameObject.GetComponent<Image>().enabled = true;
        gameObject.GetComponent<Image>().sprite = sprite;
        CurrentItem = Item;
        Item.SetActive(false);
        InteractionTextBox.SetActive(false);
    }
}
