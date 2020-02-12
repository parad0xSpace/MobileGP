using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bepis : MonoBehaviour
{
    public float bepisCost = 30000f;
    public Text ownership;
    public float textTimer = 10f;
    public float timerPrinciple = 4f;
    float timer;
    public float bepisMoney = 500f;
    bool textActive = false;

    void Start()
    {
        timer = timerPrinciple;
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("ownBepis") == 1)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                RunBepis();
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

    public void PurchaseBank()
    {
        if (PlayerPrefs.GetFloat("currentMoney") < bepisCost && PlayerPrefs.GetInt("ownBepis") == 0)
        {
            Debug.Log("not enough bling");
            return;
        }
        else if (PlayerPrefs.GetInt("ownBepis") == 1)
        {
            Debug.Log("already owned");
            ownership.text = "You already own Bepis!";
            textActive = true;
        }
        else
        {
            Debug.Log("success!");
            PlayerPrefs.SetInt("ownBepis", 1);
            PlayerPrefs.SetFloat("currentMoney", PlayerPrefs.GetFloat("currentMoney") - bepisCost);
            ownership.text = "Congradulations! You now own Bepis.";
            textActive = true;
            PlayerPrefs.SetInt("ownBepis", 1);
        }
    }

    void RunBepis()
    {
        Debug.Log("$500 collected");
        timer = timerPrinciple;
        PlayerPrefs.SetFloat("currentMoney", PlayerPrefs.GetFloat("currentMoney") + bepisMoney);
    }
}
