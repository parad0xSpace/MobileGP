using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LemonadeStand : MonoBehaviour
{
    float balance;
    public float textTimer = 10f;
    public float timerPrinciple = 2f;
    float timer;
    public float lemonadeMoney = 10f;

    public Text lemonadeText;
    public GameObject lemonadeCanvas;

    void Start()
    {
        timer = timerPrinciple;
        lemonadeCanvas.gameObject.SetActive(false);
        lemonadeText.text = PlayerPrefs.GetString("corpName") + " Lemonade Stand. It makes $10 per cycle.";
    }

    
    void Update()
    {
        timer -= Time.deltaTime;

        if(textTimer < 0)
        {
            textTimer = 10f;
        }

        if(timer < 0)
        {
            RunLemonadeStand();
        }
    }

    void RunLemonadeStand()
    {
        Debug.Log("$10 collected");
        PlayerPrefs.SetFloat("currentMoney", PlayerPrefs.GetFloat("currentMoney") + lemonadeMoney);
        timer = timerPrinciple;
    }

    public void PressStore()
    {
        lemonadeCanvas.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseCanvas()
    {
        lemonadeCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}

