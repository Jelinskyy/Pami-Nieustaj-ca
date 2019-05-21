using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadHome : LoadNewArea
{
    public override void restartState()
    {
        GameObject.FindObjectOfType<Jonatan>().state = 0;
    }
}
