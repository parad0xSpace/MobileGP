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

    public void WTwo()
    {

    }

    public void WThree()
    {

    }

    public void WFour()
    {

    }

    public void WarningEnd()
    {
        Time.timeScale = 1;
    }

    public void Threatened()
    {
        threatCanvas.gameObject.SetActive(false);
        
    }

    public void TTwo()
    {

    }

    public void TThree()
    {

    }

    public void TFour()
    {

    }

    public void TFive()
    {

    }

    public void TSix()
    {

    }

    public void CloseT()
    {
        Time.timeScale = 1;
    }

    public void TrueEnd()
    {
        uhohCanvas.gameObject.SetActive(false);
    }

    public void TETwo()
    {

    }

    public void TEThree()
    {

    }

    public void TEFour()
    {

    }

    public void TEFive()
    {

    }

    public void ThisIsTheEnd()
    {
        badEnd.gameObject.GetComponent<Animator>().SetTrigger("Burn");
    }
    void LoadLose()
    {
        //load lose scene
    }
}
