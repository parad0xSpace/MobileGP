using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wizney : MonoBehaviour
{
    public float wizneyCost = 1500000f;
    public Text ownership;
    public float textTimer = 10f;
    public float timerPrinciple = 2f;
    float timer;
    public float wizneyMoney = 2000f;
    bool textActive = false;

    public GameObject wizCanvas;
    public Text wizText;

    void Start()
    {
        timer = timerPrinciple;
        wizCanvas.gameObject.SetActive(false);
        if (PlayerPrefs.GetInt("ownWizney") != 1)
        {
            wizText.text = "Wizney, a large entertainment empire. Makes $2000 per cycle. Buy for 1.5 million?";
        }
        else
        {
            wizText.text = "Wizney, a large entertainment empire. Makes $2000 per cycle. Buy for 1.5 million?";
        }
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("ownWizney") == 1)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                RunWizney();
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

    public void PurchaseWizney()
    {
        if (PlayerPrefs.GetFloat("currentMoney") < wizneyCost && PlayerPrefs.GetInt("ownWizney") == 0)
        {
            Debug.Log("not enough bling");
            return;
        }
        else if (PlayerPrefs.GetInt("ownWizney") == 1)
        {
            Debug.Log("already owned");
            ownership.text = "You already own Wizney!";
            textActive = true;
        }
        else
        {
            Debug.Log("success!");
            PlayerPrefs.SetInt("ownWizney", 1);
            PlayerPrefs.SetFloat("currentMoney", PlayerPrefs.GetFloat("currentMoney") - wizneyCost);
            ownership.text = "Congratulations! You now own Wizney.";
            textActive = true;
            wizText.text = "Wizney, a large entertainment empire. Makes $2000 per cycle. Buy for 1.5 million?";
        }
    }

    void RunWizney()
    {
        if(PlayerPrefs.GetInt("wizneyBad") == 1)
        {
            timerPrinciple = 0.75f;
        }
        Debug.Log("$2000 collected");
        timer = timerPrinciple;
        PlayerPrefs.SetFloat("currentMoney", PlayerPrefs.GetFloat("currentMoney") + wizneyMoney);
        wizText.text = "Wizney, a large entertainment empire. Makes $2000 per cycle. Buy for 1.5 million?";
    }

    public void PressStore()
    {
        wizCanvas.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseCanvas()
    {
        wizCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
