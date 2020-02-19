using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitializeBalance : MonoBehaviour
{
    public Text balanceText;

    void Update()
    {
        if (PlayerPrefs.GetFloat("currentMoney") > 999999999999f)
        {
            balanceText.text = "$" + (Mathf.RoundToInt(PlayerPrefs.GetFloat("currentMoney") / 10000000000)) / 100 + " trillion";
        }
        else if (PlayerPrefs.GetFloat("currentMoney") > 999999999f)
        {
            balanceText.text = "$" + (Mathf.RoundToInt(PlayerPrefs.GetFloat("currentMoney") / 10000000)) / 100 + " billion";
        }
        else if(PlayerPrefs.GetFloat("currentMoney") > 999999f)
        {
            balanceText.text = "$" + (Mathf.RoundToInt(PlayerPrefs.GetFloat("currentMoney") / 10000)) /100 + " million";
        }
        else
        {
            balanceText.text = "$" + PlayerPrefs.GetFloat("currentMoney");
        }
    }
}
