using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plug : MonoBehaviour
{
    private bool isOn;
    private Image image;
    private Color c;
    private bool work;
    
    void Start()
    {
        image = GetComponent<Image>();
        c = image.color;
        c.a = 1f;
        image.color = c;
        isOn = false;
    }
    
    void Update()
    {
        if (isOn == true && work == true)
        {
            c.a += 0.3f * Time.deltaTime;
            image.color = c;
            if(c.a >= 1f)
            {
                work = false;
                GameObject.FindObjectOfType<LoadWorkArea>().SendMessage("GoWork");
            }
        }
        else if(isOn==false && c.a > 0f)
        {
            c.a -= 0.25f * Time.deltaTime;
            image.color = c;
        }else if(isOn == true && c.a < 1f)
        {
            c.a += 0.25f * Time.deltaTime;
            image.color = c;
        }
    }

    public void turn()
    {
        isOn = !isOn;
    }

    public void turnWork()
    {
        isOn = true;
        work = true;
    }

    public void lightOf()
    {
        isOn = true;
        c.a = 1f;
        image.color = c;
    }
}
