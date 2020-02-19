using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventButtons : MonoBehaviour
{
    public GameObject bepisCanvas;
    public GameObject polaCanvas;
    public GameObject fcscCanvas;
    public GameObject wizneyCanvas;
    public GameObject damsungCanvas;
    public GameObject mestleCanvas;
    public GameObject bamazonCanvas;

    public void BepisBad()
    {
        PlayerPrefs.SetInt("bepisBad", 1);
        PlayerPrefs.SetInt("bepisEvent", 1);
        PlayerPrefs.SetInt("image", PlayerPrefs.GetInt("image") - 1);
        bepisCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    public void BepisGood()
    {
        PlayerPrefs.SetInt("bepisGood", 1);
        PlayerPrefs.SetInt("bepisEvent", 1);
        PlayerPrefs.SetInt("image", PlayerPrefs.GetInt("image") + 1);
        bepisCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void PolaBad()
    {
        PlayerPrefs.SetInt("polaBad", 1);
        PlayerPrefs.SetInt("polaEvent", 1);
        PlayerPrefs.SetInt("image", PlayerPrefs.GetInt("image") - 1);
        polaCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void PolaGood()
    {
        PlayerPrefs.SetInt("polaGood", 1);
        PlayerPrefs.SetInt("polaEvent", 1);
        PlayerPrefs.SetInt("image", PlayerPrefs.GetInt("image") + 1);
        polaCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void CarBad()
    {
        PlayerPrefs.SetInt("carBad", 1);
        PlayerPrefs.SetInt("carEvent", 1);
        PlayerPrefs.SetInt("image", PlayerPrefs.GetInt("image") - 5);
        fcscCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void CarNeutral()
    {
        PlayerPrefs.SetInt("carEvent", 1);
        fcscCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void WizneyBad()
    {
        PlayerPrefs.SetInt("wizneyBad", 1);
        PlayerPrefs.SetInt("wizneyEvent", 1);
        PlayerPrefs.SetInt("image", PlayerPrefs.GetInt("image") - 5);
        wizneyCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void WizneyNeutral()
    {
        PlayerPrefs.SetInt("wizneyEvent", 1);
        wizneyCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void DamsungBad()
    {
        PlayerPrefs.SetInt("damsungBad", 1);
        PlayerPrefs.SetInt("damsungEvent", 1);
        PlayerPrefs.SetInt("image", PlayerPrefs.GetInt("image") - 5);
        damsungCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void DamsungGood()
    {
        PlayerPrefs.SetInt("damsungGood", 1);
        PlayerPrefs.SetInt("damsungEvent", 1);
        PlayerPrefs.SetInt("image", PlayerPrefs.GetInt("image") + 1);
        damsungCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void MestleBad()
    {
        PlayerPrefs.SetInt("mestleBad", 1);
        PlayerPrefs.SetInt("mestleEvent", 1);
        PlayerPrefs.SetInt("image", PlayerPrefs.GetInt("image") - 10);
        mestleCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void MestleNeutral()
    {
        PlayerPrefs.SetInt("mestleEvent", 1);
        mestleCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void BamazonBad()
    {
        PlayerPrefs.SetInt("bamazonBad", 1);
        PlayerPrefs.SetInt("bamazonEvent", 1);
        PlayerPrefs.SetInt("image", PlayerPrefs.GetInt("image") - 10);
        bamazonCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void BamazonNeutral()
    {
        PlayerPrefs.SetInt("bamazonEvent", 1);
        bamazonCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
