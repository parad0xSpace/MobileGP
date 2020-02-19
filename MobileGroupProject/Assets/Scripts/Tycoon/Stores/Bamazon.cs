using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bamazon : MonoBehaviour
{
    public float bamazonCost = 25000000f;
    public Text ownership;
    public float textTimer = 10f;
    public float timerPrinciple = 4f;
    float timer;
    public float bamazonMoney = 10000f;
    bool textActive = false;

    void Start()
    {
        timer = timerPrinciple;
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("ownBamazon") == 1)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                RunBamazon();
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

    public void PurchaseBamazon()
    {
        if (PlayerPrefs.GetFloat("currentMoney") < bamazonCost && PlayerPrefs.GetInt("ownBamazon") == 0)
        {
            Debug.Log("not enough bling");
            return;
        }
        else if (PlayerPrefs.GetInt("ownBamazon") == 1)
        {
            Debug.Log("already owned");
            ownership.text = "You already own Bamazon!";
            textActive = true;
        }
        else
        {
            Debug.Log("success!");
            PlayerPrefs.SetInt("ownBamazon", 1);
            PlayerPrefs.SetFloat("currentMoney", PlayerPrefs.GetFloat("currentMoney") - bamazonCost);
            ownership.text = "Congradulations! You now own Bamazon.";
            textActive = true;
        }
    }

    void RunBamazon()
    {
        if(PlayerPrefs.GetInt("bamazonBad") == 1)
        {
            timerPrinciple = .5f;
        }

        Debug.Log("$10000 collected");
        timer = timerPrinciple;
        PlayerPrefs.SetFloat("currentMoney", PlayerPrefs.GetFloat("currentMoney") + bamazonMoney);
    }
}
