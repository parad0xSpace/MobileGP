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
        PlayerPrefs.SetInt("ownBepis", 0);
        PlayerPrefs.SetInt("ownPola", 0);
        PlayerPrefs.SetInt("ownCar", 0);
        PlayerPrefs.SetInt("ownWizney", 0);
        PlayerPrefs.SetInt("ownDamsung", 0);
        PlayerPrefs.SetInt("ownMestle", 0);
        PlayerPrefs.SetInt("ownBamazon", 0);
        PlayerPrefs.SetInt("image", 0);
        PlayerPrefs.SetInt("warned", 0);
        PlayerPrefs.SetInt("superWarned", 0);
    }

    public void AllDaMunniez()
    {
        Debug.Log("STOP!!!! you've violated the law!!!!!!!!!!!!!");
        PlayerPrefs.SetFloat("currentMoney", PlayerPrefs.GetFloat("currentMoney") + 5000000);
    }

    public void OwnTheWorld()
    {
        PlayerPrefs.SetFloat("currentMoney", 1);
        PlayerPrefs.SetInt("ownPunchyRoll", 1);
        PlayerPrefs.SetInt("ownNick", 1);
        PlayerPrefs.SetInt("ownBank", 1);
        PlayerPrefs.SetInt("ownBepis", 1);
        PlayerPrefs.SetInt("ownPola", 1);
        PlayerPrefs.SetInt("ownCar", 1);
        PlayerPrefs.SetInt("ownWizney", 1);
        PlayerPrefs.SetInt("ownDamsung", 1);
        PlayerPrefs.SetInt("ownMestle", 1);
        PlayerPrefs.SetInt("ownBamazon", 1);
    }
}
