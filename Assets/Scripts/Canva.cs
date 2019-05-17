using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canva : MonoBehaviour
{
    private static bool canvaExists;
    public GameObject canva;

    // Start is called before the first frame update
    void Start()
    {
        if (!canvaExists)
        {
            canvaExists = true;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void OnCanva()
    {
        canva.SetActive(true);
    }
}
