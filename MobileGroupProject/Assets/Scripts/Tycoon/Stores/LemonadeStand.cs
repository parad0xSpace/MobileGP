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
    
    void Start()
    {
        timer = timerPrinciple;
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
}
