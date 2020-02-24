using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PunchyRoll : MonoBehaviour
{
    public float punchyRollCost = 900f;
    public Text ownership;
    public float textTimer = 10f;
    public float timerPrinciple = 1f;
    float timer;
    public float punchyMoney = 100f;
    bool textActive = false;

    public GameObject punchyCanvas;
    public Text punchyText;

    void Start()
    {
        timer = timerPrinciple;
        punchyCanvas.gameObject.SetActive(false);
        if(PlayerPrefs.GetInt("ownPunchyRoll") != 1)
        {
            punchyText.text = "PunchyRoll, a cartoon distribution service. Makes $100 per cycle. Buy for $900?";
        }
        else
        {
            punchyText.text = "PunchyRoll, a cartoon distribution service. Makes $100 per cycle.";
        }
    }

    
    void Update()
    {
        if(PlayerPrefs.GetInt("ownPunchyRoll") == 1)
        {
            timer -= Time.deltaTime;
            if(timer < 0)
            {
                RunPunchyRoll();
            }
        }
        if(textActive)
        {
            textTimer -= Time.deltaTime;
            if(textTimer < 0)
            {
                textTimer = 10f;
                ownership.text = "";
                textActive = false;
            }
        }
    }

    public void PurchasePunchyRoll()
    {
        if (PlayerPrefs.GetFloat("currentMoney") < punchyRollCost && PlayerPrefs.GetInt("ownPunchyRoll") == 0)
        {
            Debug.Log("not enough bling");
            return;
        }
        else if (PlayerPrefs.GetInt("ownPunchyRoll") == 1)
        {
            Debug.Log("already owned");
            ownership.text = "You already own PunchyRoll!";
            textActive = true;
        }
        else
        {
            Debug.Log("success!");
            PlayerPrefs.SetInt("ownPunchyRoll", 1);
            PlayerPrefs.SetFloat("currentMoney", PlayerPrefs.GetFloat("currentMoney") - punchyRollCost);
            ownership.text = "Congratulations! You now own PunchyRoll.";
            textActive = true;
            punchyText.text = "PunchyRoll, a cartoon distribution service. Makes $100 per cycle. Buy for $900?";
        }
    }

    void RunPunchyRoll()
    {
        Debug.Log("$100 collected");
        timer = timerPrinciple;
        PlayerPrefs.SetFloat("currentMoney", PlayerPrefs.GetFloat("currentMoney") + punchyMoney);
    }

    public void PressStore()
    {
        punchyCanvas.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseCanvas()
    {
        punchyCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
