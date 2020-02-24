using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mestle : MonoBehaviour
{
    public float mestleCost = 5500000f;
    public Text ownership;
    public float textTimer = 10f;
    public float timerPrinciple = 2f;
    float timer;
    public float mestleMoney = 5000f;
    bool textActive = false;

    public GameObject mestleCanvas;
    public Text mestleText;

    void Start()
    {
        timer = timerPrinciple;
        mestleCanvas.gameObject.SetActive(false);
        if (PlayerPrefs.GetInt("ownDamsung") != 1)
        {
            mestleText.text = "Mestle, a large foodstuff manufacturer. Makes $5000 per cycle. Buy for 5.5 million?";
        }
        else
        {
            mestleText.text = "Mestle, a large foodstuff manufacturer. Makes $5000 per cycle. Buy for 5.5 million?";
        }
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("ownMestle") == 1)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                RunMestle();
            }
        }
        if (textActive)
        {
            textTimer -= Time.deltaTime;
            if (textTimer < 0)
            {
                textTimer = 10f;
                ownership.text = "";
                textActive = false;
            }
        }
    }

    public void PurchaseMestle()
    {
        if (PlayerPrefs.GetFloat("currentMoney") < mestleCost && PlayerPrefs.GetInt("ownMestle") == 0)
        {
            Debug.Log("not enough bling");
            return;
        }
        else if (PlayerPrefs.GetInt("ownMestle") == 1)
        {
            Debug.Log("already owned");
            ownership.text = "You already own Mestle!";
            textActive = true;
        }
        else
        {
            Debug.Log("success!");
            PlayerPrefs.SetInt("ownMestle", 1);
            PlayerPrefs.SetFloat("currentMoney", PlayerPrefs.GetFloat("currentMoney") - mestleCost);
            ownership.text = "Congratulations! You now own Mestle.";
            textActive = true;
            mestleText.text = "Mestle, a large foodstuff manufacturer. Makes $5000 per cycle. Buy for 5.5 million?";
        }
    }

    void RunMestle()
    {
        if(PlayerPrefs.GetInt("mestleBad") == 1)
        {
            mestleMoney = 7000f;
        }

        Debug.Log("$3000 collected");
        timer = timerPrinciple;
        PlayerPrefs.SetFloat("currentMoney", PlayerPrefs.GetFloat("currentMoney") + mestleMoney);
    }

    public void PressStore()
    {
        mestleCanvas.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseCanvas()
    {
        mestleCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
