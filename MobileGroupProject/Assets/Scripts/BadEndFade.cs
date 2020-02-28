using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BadEndFade : MonoBehaviour
{
    void LoadMenu()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
