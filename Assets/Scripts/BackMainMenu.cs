using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMainMenu : MonoBehaviour
{
    public void backMenu()
    {
        Destroy(GameObject.Find("/Player"));
        Destroy(GameObject.Find("/MainCamera"));
        Destroy(GameObject.Find("/CanvasBox"));
        Application.LoadLevel("mainMenu");
    }
}
