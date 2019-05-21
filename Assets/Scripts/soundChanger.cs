using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundChanger : MonoBehaviour
{
    public GameObject guzik;
    private Button myButton;
    public AudioSource soundTrack;
    public Sprite On;
    public Sprite Off;
    private int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        myButton = guzik.GetComponent<Button>();
    }

    public void changeButton()
    {
        soundTrack = GameObject.Find("/SoundTrack").GetComponent<AudioSource>();
        counter++;

        if (counter % 2 == 0)
        {
            myButton.image.overrideSprite = On;
            soundTrack.mute = !soundTrack.mute;
        }
        else
        {
            myButton.image.overrideSprite = Off;
            soundTrack.mute = !soundTrack.mute;
        }
    }
}
