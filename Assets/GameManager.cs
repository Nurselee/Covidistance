using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{

   

    bool pause = false;

    public float restartDelay = 2f;


    public GameObject panel;

   



    public void YouWin()
    {

        panel.SetActive(true);
        Time.timeScale = 0.0f;

    }


    public void EndGame()
    {

        panel.SetActive(true);
        Time.timeScale = 0.0f;

    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1.0f;
    }
    

    public void pauseButton()
    {

        pause = !pause;
        if (pause ==true)
        {
            Time.timeScale = 0.0f;
        }

        else
        {
            Time.timeScale = 1.0f;
        }
    }
}
