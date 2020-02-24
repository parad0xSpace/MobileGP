using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nicholasodeon : MonoBehaviour
{
    public float nickCost = 15000f;
    public Text ownership;
    public float textTimer = 10f;
    public float timerPrinciple = 2f;
    float timer;
    public float nickMoney = 150f;
    bool textActive = false;

    public GameObject nickCanvas;
    public Text nickText;

    void Start()
    {
        timer = timerPrinciple;
        nickCanvas.gameObject.SetActive(false);
        if (PlayerPrefs.GetInt("ownNick") != 1)
        {
            nickText.text = "Nicholasodeon, a cartoon production studio. Makes $150 per cycle. Buy for $15000?";
        }
        else
        {
            nickText.text = "Nicholasodeon, a cartoon production studio. Makes $150 per cycle.";
        }
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("ownNick") == 1)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                RunNick();
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

    public void PurchaseNick()
    {
        if (PlayerPrefs.GetFloat("currentMoney") < nickCost && PlayerPrefs.GetInt("ownNick") == 0)
        {
            Debug.Log("not enough bling");
            return;
        }
        else if (PlayerPrefs.GetInt("ownNick") == 1)
        {
            Debug.Log("already owned");
            ownership.text = "You already own Nicholasodeon!";
            textActive = true;
        }
        else
        {
            Debug.Log("success!");
            PlayerPrefs.SetInt("ownNick", 1);
            PlayerPrefs.SetFloat("currentMoney", PlayerPrefs.GetFloat("currentMoney") - nickCost);
            ownership.text = "Congratulations! You now own Nickolasodeon.";
            textActive = true;
            nickText.text = "Nicholasodeon, a cartoon production studio. Makes $150 per cycle.";
        }
    }

    void RunNick()
    {
        Debug.Log("$150 collected");
        timer = timerPrinciple;
        PlayerPrefs.SetFloat("currentMoney", PlayerPrefs.GetFloat("currentMoney") + nickMoney);
    }

    public void PressStore()
    {
        nickCanvas.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseCanvas()
    {
        nickCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
