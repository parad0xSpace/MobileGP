using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerName : MonoBehaviour
{
    public InputField corpName;
    public Animator anim;

    public void NameCorp()
    {
        PlayerPrefs.SetString("corpName", corpName.text);
        anim.GetComponent<Animator>().SetTrigger("FadeOut");
    }
}
