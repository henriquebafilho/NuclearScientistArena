using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseScript : MonoBehaviour {
   
    public GameObject pauseToMenu, newGame, restart;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pausar();
        }
    }
    public void Pausar()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            pauseToMenu.SetActive(true);
            newGame.SetActive(true);
            restart.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            pauseToMenu.SetActive(false);
            newGame.SetActive(false);
            restart.SetActive(false);
        }
    }
}