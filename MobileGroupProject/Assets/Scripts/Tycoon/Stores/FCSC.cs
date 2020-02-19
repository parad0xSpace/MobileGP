using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FCSC : MonoBehaviour
{
    public float carCost = 600000f;
    public Text ownership;
    public float textTimer = 10f;
    public float timerPrinciple = 4f;
    float timer;
    public float carMoney = 1500f;
    bool textActive = false;

    void Start()
    {
        timer = timerPrinciple;
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("ownCar") == 1)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                RunCar();
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

    public void PurchaseCar()
    {
        if (PlayerPrefs.GetFloat("currentMoney") < carCost && PlayerPrefs.GetInt("ownCar") == 0)
        {
            Debug.Log("not enough bling");
            return;
        }
        else if (PlayerPrefs.GetInt("ownCar") == 1)
        {
            Debug.Log("already owned");
            ownership.text = "You already own the Fast Car Spaceship Company!";
            textActive = true;
        }
        else
        {
            Debug.Log("success!");
            PlayerPrefs.SetInt("ownCar", 1);
            PlayerPrefs.SetFloat("currentMoney", PlayerPrefs.GetFloat("currentMoney") - carCost);
            ownership.text = "Congradulations! You now own the Fast Car Spaceship Company.";
            textActive = true;
        }
    }

    void RunCar()
    {
        if(PlayerPrefs.GetInt("carBad") == 1)
        {
            timerPrinciple = 3f;
        }
        Debug.Log("$1500 collected");
        timer = timerPrinciple;
        PlayerPrefs.SetFloat("currentMoney", PlayerPrefs.GetFloat("currentMoney") + carMoney);
    }
}
