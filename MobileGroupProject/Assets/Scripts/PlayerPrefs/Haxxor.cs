using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Haxxor : MonoBehaviour
{
    public Text clearText;
    public void TheEnd()
    {
        PlayerPrefs.SetFloat("currentMoney", 0);
        PlayerPrefs.SetInt("ownPunchyRoll", 0);
        PlayerPrefs.SetInt("ownNick", 0);
        PlayerPrefs.SetInt("ownBank", 0);
        clearText.text = "";
    }

    public void AllDaMunniez()
    {
        PlayerPrefs.SetFloat("currentMoney", PlayerPrefs.GetFloat("currentMoney") + 10000);
    }
}
