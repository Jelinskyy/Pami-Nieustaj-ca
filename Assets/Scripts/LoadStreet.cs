using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadStreet : LoadNewArea
{
    public override void restartState()
    {
        GameObject.FindObjectOfType<Dawid>().state = 0;
    }
}
