using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnarchyEventButtons : MonoBehaviour
{
    public GameObject warningOne;
    public GameObject warningTwo;
    public GameObject warningThree;
    public GameObject warningFour;

    public GameObject threatOne;
    public GameObject threatTwo;
    public GameObject threatThree;
    public GameObject threatFour;
    public GameObject threatFive;
    public GameObject threatSix;

    public GameObject endOne;
    public GameObject endTwo;
    public GameObject endThree;
    public GameObject endFour;
    public GameObject endFive;

    public GameObject badEnd;

    public void WTwo()
    {
        warningOne.gameObject.SetActive(false);
        warningTwo.gameObject.SetActive(true);
    }

    public void WThree()
    {
        warningTwo.gameObject.SetActive(false);
        warningThree.gameObject.SetActive(true);
    }

    public void WFour()
    {
        warningThree.gameObject.SetActive(false);
        warningFour.gameObject.SetActive(true);

    }

    public void WarningEnd()
    {
        warningFour.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void TTwo()
    {
        threatOne.gameObject.SetActive(false);
        threatTwo.gameObject.SetActive(true);
    }

    public void TThree()
    {
        threatTwo.gameObject.SetActive(false);
        threatThree.gameObject.SetActive(true);
    }

    public void TFour()
    {
        threatThree.gameObject.SetActive(false);
        threatFour.gameObject.SetActive(true);
    }

    public void TFive()
    {
        threatFour.gameObject.SetActive(false);
        threatFive.gameObject.SetActive(true);
    }

    public void TSix()
    {
        threatFive.gameObject.SetActive(false);
        threatSix.gameObject.SetActive(true);
    }

    public void CloseT()
    {
        threatSix.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void TETwo()
    {
        endOne.gameObject.SetActive(false);
        endTwo.gameObject.SetActive(true);
    }

    public void TEThree()
    {
        endTwo.gameObject.SetActive(false);
        endThree.gameObject.SetActive(true);
    }

    public void TEFour()
    {
        endThree.gameObject.SetActive(false);
        endFour.gameObject.SetActive(true);
    }

    public void TEFive()
    {
        endFour.gameObject.SetActive(false);
        endFive.gameObject.SetActive(true);
    }

    public void ThisIsTheEnd()
    {
        endFive.gameObject.SetActive(false);
        badEnd.gameObject.GetComponent<Animator>().SetTrigger("Burn");
    }
    void LoadLose()
    {
        //load lose scene
    }
}
