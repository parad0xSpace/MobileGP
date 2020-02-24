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

    public GameObject bepisCanvas;
    public Text bepisText;

    void Start()
    {
        timer = timerPrinciple;
        bepisCanvas.gameObject.SetActive(false);
        if (PlayerPrefs.GetInt("ownBepis") != 1)
        {
            bepisText.text = "Bepis, a well-known cola soda brand, among other things. Makes $500 per cycle. Buy for $100,000?";
        }
        else
        {
            bepisText.text = "Bepis, a well-known cola soda brand, among other things. Makes $500 per cycle. ";
        }
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

    public void PurchaseBepis()
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
            ownership.text = "Congratulations! You now own Bepis.";
            textActive = true;
            bepisText.text = "Bepis, a well-known cola soda brand, among other things.";
        }
    }

    void RunBepis()
    {
        if (PlayerPrefs.GetInt("bepisBad") == 1)
        {
            bepisMoney = 700f;
        }
        if (PlayerPrefs.GetInt("bepisGood") == 1)
        {
            timerPrinciple = 3.5f;
        }

        timer = timerPrinciple;
        PlayerPrefs.SetFloat("currentMoney", PlayerPrefs.GetFloat("currentMoney") + bepisMoney);
    }

    public void PressStore()
    {
        bepisCanvas.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseCanvas()
    {
        bepisCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
