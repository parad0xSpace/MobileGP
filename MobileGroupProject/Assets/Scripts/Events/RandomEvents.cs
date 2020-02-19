using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomEvents : MonoBehaviour
{
    int n;
    public float corpTimerPrinciple = 300f;
    float corpTimer;
    public float anarchyTimerPrinciple = 600f;
    float anarchyTimer;
    public float nezzosTimerPrinciple = 200f;
    float nezzosTimer;

    public GameObject bepisCanvas;
    public GameObject polaCanvas;
    public GameObject fcscCanvas;
    public GameObject wizneyCanvas;
    public GameObject damsungCanvas;
    public GameObject mestleCanvas;
    public GameObject bamazonCanvas;

    public GameObject warningCanvas;
    public GameObject threatCanvas;
    public GameObject uhohCanvas;

    public GameObject bankGratz;
    public GameObject congratz;
    public GameObject nezzosDefeat;

    void Start()
    {
        corpTimer = corpTimerPrinciple;
        anarchyTimer = anarchyTimerPrinciple;
        nezzosTimer = nezzosTimerPrinciple;

        bepisCanvas.gameObject.SetActive(false);
        polaCanvas.gameObject.SetActive(false);
        fcscCanvas.gameObject.SetActive(false);
        wizneyCanvas.gameObject.SetActive(false);
        damsungCanvas.gameObject.SetActive(false);
        mestleCanvas.gameObject.SetActive(false);
        bamazonCanvas.gameObject.SetActive(false);
        warningCanvas.gameObject.SetActive(false);
        threatCanvas.gameObject.SetActive(false);
        uhohCanvas.gameObject.SetActive(false);
        bankGratz.gameObject.SetActive(false);
        congratz.gameObject.SetActive(false);
        nezzosDefeat.gameObject.SetActive(false);
    }

    void Update()
    {
        corpTimer -= Time.deltaTime;
        if(corpTimer < 0)
        {
            CorperateEvent();
        }

        if(PlayerPrefs.GetInt("image") < 0)
        {
            anarchyTimer -= Time.deltaTime;
            if(anarchyTimer < 0)
            {
                AnarchyEvent();
            }
        }

        if(PlayerPrefs.GetInt("ownBank") == 1)
        {
            nezzosTimer -= Time.deltaTime;
            if(nezzosTimer < 0)
            {
                NezzosEvent();
            }
        }

        if(PlayerPrefs.GetInt("ownBamazon") == 1)
        {
            NezzosEvent();
        }
    }

    void CorperateEvent()
    {
        n = Random.Range(0, 100);
         if(n < 5)
        {
            if(PlayerPrefs.GetInt("ownBepis") == 1 && PlayerPrefs.GetInt("bepisEvent") != 1)
            {
                corpTimer = corpTimerPrinciple;
                Time.timeScale = 0;
                bepisCanvas.gameObject.SetActive(true);
            }
            else
            {
                return;
            }
        }
         else if(n < 10 && n > 4)
        {
            if(PlayerPrefs.GetInt("ownPola") == 1 && PlayerPrefs.GetInt("polaEvent") != 1)
            {
                corpTimer = corpTimerPrinciple;
                Time.timeScale = 0;
                polaCanvas.gameObject.SetActive(true);
            }
            else
            {
                return;
            }
        }
         else if (n < 15 && n > 9)
        {
            if (PlayerPrefs.GetInt("ownCar") == 1 && PlayerPrefs.GetInt("carEvent") != 1)
            {
                corpTimer = corpTimerPrinciple;
                Time.timeScale = 0;
                fcscCanvas.gameObject.SetActive(true);
            }
            else
            {
                return;
            }
        }
         else if (n < 20 && n > 14)
        {
            if (PlayerPrefs.GetInt("ownWizney") == 1 && PlayerPrefs.GetInt("wizneyEvent") != 1)
            {
                corpTimer = corpTimerPrinciple;
                Time.timeScale = 0;
                wizneyCanvas.gameObject.SetActive(true);
            }
            else
            {
                return;
            }
        }
         else if (n < 25 && n > 19)
        {
            if (PlayerPrefs.GetInt("ownDamsung") == 1 && PlayerPrefs.GetInt("damsungEvent") != 1)
            {
                damsungCanvas.gameObject.SetActive(true);
            }
            else
            {
                return;
            }
        }
         else if (n < 30 && n > 24)
        {
            if (PlayerPrefs.GetInt("ownMestle") == 1 && PlayerPrefs.GetInt("mestleEvent") != 1)
            {
                mestleCanvas.gameObject.SetActive(true);
            }
            else
            {
                return;
            }
        }
        else if (n < 35 && n > 29)
        {
            if (PlayerPrefs.GetInt("ownBamazon") == 1 && PlayerPrefs.GetInt("bamazonEvent") != 1)
            {
                bamazonCanvas.gameObject.SetActive(true);
            }
            else
            {
                return;
            }
        }
         else
        {
            return;
        }
    }

    void AnarchyEvent()
    {
        anarchyTimer = anarchyTimerPrinciple;
        Time.timeScale = 0;
        if(PlayerPrefs.GetInt("image") <= 11)
        {
            uhohCanvas.gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("image") <= 5 && PlayerPrefs.GetInt("superWarned") != 1)
        {
            threatCanvas.gameObject.SetActive(true);
            PlayerPrefs.SetInt("superWarned", 1);
        }
        else if(PlayerPrefs.GetInt("warned") != 1)
        {
            warningCanvas.gameObject.SetActive(true);
            PlayerPrefs.SetInt("warned", 1);
        }
        else
        {
            return;
        }
    }

    void NezzosEvent()
    {
        if (PlayerPrefs.GetInt("ownBamazon") == 1 && PlayerPrefs.GetInt("nezzosDefeated") != 1)
        {
            Time.timeScale = 0;
            nezzosDefeat.gameObject.SetActive(true);
            PlayerPrefs.SetInt("nezzosDefeated", 1);
        }
        else if (PlayerPrefs.GetFloat("currentMoney") > 1000000 && PlayerPrefs.GetInt("congrats") != 1)
        {
            Time.timeScale = 0;
            congratz.gameObject.SetActive(true);
            PlayerPrefs.SetInt("congrats", 1);
        }
        else if(PlayerPrefs.GetInt("bankGratz") != 1)
        {
            Time.timeScale = 0;
            bankGratz.gameObject.SetActive(true);
            PlayerPrefs.SetInt("bankGratz", 1);
        }
        else
        {
            return;
        }
    }
}
