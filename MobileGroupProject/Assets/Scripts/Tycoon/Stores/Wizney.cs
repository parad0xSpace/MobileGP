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

    void Start()
    {
        timer = timerPrinciple;
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
            ownership.text = "Congradulations! You now own Wizney.";
            textActive = true;
        }
    }

    void RunWizney()
    {
        if(PlayerPrefs.GetInt("wizneyBad") == 1)
        {
            timerPrinciple = 1f;
        }
        Debug.Log("$2000 collected");
        timer = timerPrinciple;
        PlayerPrefs.SetFloat("currentMoney", PlayerPrefs.GetFloat("currentMoney") + wizneyMoney);
    }
}
