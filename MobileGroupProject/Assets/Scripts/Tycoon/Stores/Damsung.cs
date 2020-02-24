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

    public GameObject damsungCanvas;
    public Text damsungText;

    void Start()
    {
        timer = timerPrinciple;
        damsungCanvas.gameObject.SetActive(false);
        if (PlayerPrefs.GetInt("ownDamsung") != 1)
        {
            damsungText.text = "Damsung, a large technology company. Makes $3000 per cycle. Buy for 3 million?";
        }
        else
        {
            damsungText.text = "Damsung, a large technology company. Makes $3000 per cycle.";
        }
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
            ownership.text = "Congratulations! You now own Damsung.";
            textActive = true;
            damsungText.text = "Damsung, a large technology company. Makes $3000 per cycle.";
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

    public void PressStore()
    {
        damsungCanvas.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseCanvas()
    {
        damsungCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
