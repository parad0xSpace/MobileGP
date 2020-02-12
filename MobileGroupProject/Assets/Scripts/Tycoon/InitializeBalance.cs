using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitializeBalance : MonoBehaviour
{
    public Text balanceText;

    void Update()
    {
        balanceText.text = "$" + PlayerPrefs.GetFloat("currentMoney");
    }
}
