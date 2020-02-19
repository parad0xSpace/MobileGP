using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnarchyEventButtons : MonoBehaviour
{
    public GameObject warningCanvas;
    public GameObject threatCanvas;
    public GameObject uhohCanvas;

    public GameObject badEnd;

    public void Warned()
    {
        warningCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void Threatened()
    {
        threatCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void TrueEnd()
    {
        uhohCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
        badEnd.gameObject.GetComponent<Animator>().SetTrigger("Burn");
    }

    void LoadLose()
    {
        //load lose scene
    }
}
