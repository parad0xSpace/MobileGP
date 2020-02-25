using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTexts : MonoBehaviour
{
    public Text tutorialTextOne;
    public Text tutorialTextTwo;

    public Text anarchyTextOne;
    public Text anarchyTextTwo;

    public Text nezzosTextOne;
    public Text nezzosTextTwo;
    public Text nezzosTextThree;

    void Start()
    {
        tutorialTextOne.text = "Ah, you're the new owner of " + PlayerPrefs.GetString("corpName") + " Corp? Nice to meet you! Your grandmother asked me to help get you set up before she...";
        tutorialTextTwo.text = "I think you can take it from here. Best of luck with " + PlayerPrefs.GetString("corpName") + " Corp!";

        anarchyTextOne.text = "You're the CEO of " + PlayerPrefs.GetString("corpName") + " Corp, right?";
        anarchyTextTwo.text = "I want this to be the last visit I make to" + PlayerPrefs.GetString("corpName") + " Corp. But if it isn't?";

        nezzosTextOne.text = "Keep it up and maybe " + PlayerPrefs.GetString("corpName") + " Corp will be as big as Bamazon, haha!";
        nezzosTextTwo.text = "Best to you and " + PlayerPrefs.GetString("corpName") + " Corp! Oh, and one more thing.";
        nezzosTextThree.text = "You- you can't do this! " + PlayerPrefs.GetString("corpName") + " Corp is nothing compared to Bamzon!";
    }
}
