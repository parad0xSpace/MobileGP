using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTexts : MonoBehaviour
{
    public Text exText;
    
    void Start()
    {
        exText.text = "Congrats! Welcome to " + PlayerPrefs.GetString("corpName") + " Corp!";
    }
}
