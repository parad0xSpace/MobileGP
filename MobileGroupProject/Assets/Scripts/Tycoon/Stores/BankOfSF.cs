using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BankOfSF : MonoBehaviour
{
    public float bankCost = 30000f;
    public Text ownership;
    public float textTimer = 10f;
    public float timerPrinciple = 3f;
    float timer;
    public float bankMoney = 300f;
    bool textActive = false;

    public GameObject bankCanvas;
    public Text bankText;

    void Start()
    {
        timer = timerPrinciple;
        bankCanvas.gameObject.SetActive(false);
        if (PlayerPrefs.GetInt("ownBank") != 1)
        {
            bankText.text = "The Bank of South Florida. Makes $300 per cycle. Buy for $30,000?";
        }
        else
        {
            bankText.text = "The Bank of South Florida. Makes $300 per cycle.";
        }
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("ownBank") == 1)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                RunBank();
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
        if (PlayerPrefs.GetFloat("currentMoney") < bankCost && PlayerPrefs.GetInt("ownBank") == 0)
        {
            Debug.Log("not enough bling");
            return;
        }
        else if (PlayerPrefs.GetInt("ownBank") == 1)
        {
            Debug.Log("already owned");
            ownership.text = "You already own the Bank of South Florida!";
            textActive = true;
        }
        else
        {
            Debug.Log("success!");
            PlayerPrefs.SetInt("ownBank", 1);
            PlayerPrefs.SetFloat("currentMoney", PlayerPrefs.GetFloat("currentMoney") - bankCost);
            ownership.text = "Congratulations! You now own the Bank of South Florida.";
            textActive = true;
            bankText.text = "The Bank of South Florida. Makes $300 per cycle.";
        }
    }

    void RunBank()
    {
        Debug.Log("$300 collected");
        timer = timerPrinciple;
        PlayerPrefs.SetFloat("currentMoney", PlayerPrefs.GetFloat("currentMoney") + bankMoney);
    }

    public void PressStore()
    {
        bankCanvas.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseCanvas()
    {
        bankCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
