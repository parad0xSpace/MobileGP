using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseCanvas;
    public Animator anim;

    void Start()
    {
        pauseCanvas.gameObject.SetActive(false);
    }

    public void PauseButton()
    {
        Time.timeScale = 0;
        pauseCanvas.gameObject.SetActive(true);
    }

    public void MainMenu()
    {
        anim.GetComponent<Animator>().SetTrigger("Fade");
    }

    public void Resume()
    {
        Time.timeScale = 1;
        pauseCanvas.gameObject.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
