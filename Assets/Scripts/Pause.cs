using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public GameObject pauseMenu;

    //public UnityAction TaskOnClick { get; private set; }


    // Start is called before the first frame update
    void Start()
    {
        Data.Paused = false;

        if (Data.Paused)
        {
            pauseMenu.SetActive(true);
        }
        else
        {
            pauseMenu.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //pause/unpause
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Debug.Log("pause input read");
            if (Data.Paused)
            {
                Data.Paused = false;
            }
            else if (!Data.Paused)
            {
                Data.Paused = true;
            }
        }

        if (Data.Paused)
        {
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
        }
        else
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1;
        }

        
    }

    void Resume()
    {
        Data.Paused = false;
    }

    void Restart()
    {
        SceneManager.LoadScene(1);
    }

    void QuitToMenu()
    {
        SceneManager.LoadScene(0);
    }



}
