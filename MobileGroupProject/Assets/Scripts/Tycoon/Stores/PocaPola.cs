using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PocaPola : MonoBehaviour
{
    public float polaCost = 100000f;
    public Text ownership;
    public float textTimer = 10f;
    public float timerPrinciple = 4f;
    float timer;
    public float polaMoney = 1000f;
    bool textActive = false;

    void Start()
    {
        timer = timerPrinciple;
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("ownPola") == 1)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                RunPola();
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

    public void PurchasePola()
    {
        if (PlayerPrefs.GetFloat("currentMoney") < polaCost && PlayerPrefs.GetInt("ownPola") == 0)
        {
            Debug.Log("not enough bling");
            return;
        }
        else if (PlayerPrefs.GetInt("ownPola") == 1)
        {
            Debug.Log("already owned");
            ownership.text = "You already own Poca Pola!";
            textActive = true;
        }
        else
        {
            Debug.Log("success!");
            PlayerPrefs.SetInt("ownPola", 1);
            PlayerPrefs.SetFloat("currentMoney", PlayerPrefs.GetFloat("currentMoney") - polaCost);
            ownership.text = "Congradulations! You now own Poca Pola.";
            textActive = true;
        }
    }

    void RunPola()
    {
        if(PlayerPrefs.GetInt("polaBad") == 1)
        {
            timerPrinciple = 3f;
        }

        if(PlayerPrefs.GetInt("polaGood") == 1)
        {
            polaMoney = 900f;
        }

        Debug.Log("$1000 collected");
        timer = timerPrinciple;
        PlayerPrefs.SetFloat("currentMoney", PlayerPrefs.GetFloat("currentMoney") + polaMoney);
    }
}
