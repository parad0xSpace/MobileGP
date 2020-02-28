using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public Animator anim;

    public void Continue()
    {
        if(PlayerPrefs.GetInt("PrevPlay") == 1)
        {
            anim.GetComponent<Animator>().SetTrigger("GameFade");
        }
        else
        {
            NewGame();
        }
    }

    public void NewGame()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("PrevPlay", 1);
        anim.GetComponent<Animator>().SetTrigger("NameFade");
    }

    public void EndGame()
    {
        Application.Quit();
    }

    void LoadName()
    {
        SceneManager.LoadScene("NameScene");
    }

    void LoadGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
