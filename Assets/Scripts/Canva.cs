using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canva : MonoBehaviour
{
    private static bool canvaExists;
    public GameObject canva;
    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;

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

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void OnCanva()
    {
        canva.SetActive(true);
    }

    void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
