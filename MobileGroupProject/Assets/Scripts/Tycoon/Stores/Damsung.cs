using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damsung : MonoBehaviour
{
    public float damsungCost = 3000000f;
    public Text ownership;
    public float textTimer = 10f;
    public float timerPrinciple = 2f;
    float timer;
    public float damsungMoney = 3000f;
    bool textActive = false;

    void Start()
    {
        timer = timerPrinciple;
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("ownDamsung") == 1)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                RunDamsung();
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

    public void PurchaseDamsung()
    {
        if (PlayerPrefs.GetFloat("currentMoney") < damsungCost && PlayerPrefs.GetInt("ownDamsung") == 0)
        {
            Debug.Log("not enough bling");
            return;
        }
        else if (PlayerPrefs.GetInt("ownDamsung") == 1)
        {
            Debug.Log("already owned");
            ownership.text = "You already own Damsung!";
            textActive = true;
        }
        else
        {
            Debug.Log("success!");
            PlayerPrefs.SetInt("ownDamsung", 1);
            PlayerPrefs.SetFloat("currentMoney", PlayerPrefs.GetFloat("currentMoney") - damsungCost);
            ownership.text = "Congradulations! You now own Damsung.";
            textActive = true;
        }
    }

    void RunDamsung()
    {
        if(PlayerPrefs.GetInt("damsungBad") == 1)
        {
            timerPrinciple = 1f;
        }

        if (PlayerPrefs.GetInt("damsungGood") == 1)
        {
            timerPrinciple = 2.5f;
        }

        Debug.Log("$3000 collected");
        timer = timerPrinciple;
        PlayerPrefs.SetFloat("currentMoney", PlayerPrefs.GetFloat("currentMoney") + damsungMoney);
    }
}
