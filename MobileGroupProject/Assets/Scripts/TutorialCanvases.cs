using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialCanvases : MonoBehaviour
{
    public GameObject lineOne;
    public GameObject lineTwo;
    public GameObject lineThree;
    public GameObject lineFour;
    public GameObject lineFive;
    public GameObject lineSix;
    public GameObject lineSeven;

    void Start()
    {
        lineOne.gameObject.SetActive(false);
        lineTwo.gameObject.SetActive(false);
        lineThree.gameObject.SetActive(false);
        lineFour.gameObject.SetActive(false);
        lineFive.gameObject.SetActive(false);
        lineSix.gameObject.SetActive(false);
        lineSeven.gameObject.SetActive(false);

        if(PlayerPrefs.GetInt("tutorial") != 1)
        {
            lineOne.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void LineTwo()
    {
        lineOne.gameObject.SetActive(false);
        lineTwo.gameObject.SetActive(true);
    }

    public void LineThree()
    {
        lineTwo.gameObject.SetActive(false);
        lineThree.gameObject.SetActive(true);
    }

    public void LineFour()
    {
        lineThree.gameObject.SetActive(false);
        lineFour.gameObject.SetActive(true);
    }

    public void LineFive()
    {
        lineFour.gameObject.SetActive(false);
        lineFive.gameObject.SetActive(true);
    }

    public void LineSix()
    {
        lineFive.gameObject.SetActive(false);
        lineSix.gameObject.SetActive(true);
    }

    public void LineSeven()
    {
        lineSix.gameObject.SetActive(false);
        lineSeven.gameObject.SetActive(true);
    }

    public void EndTutorial()
    {
        PlayerPrefs.SetInt("tutorial", 1);
        lineSeven.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
