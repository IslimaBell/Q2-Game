using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashtoMenu : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(Proceed());
    }

    IEnumerator Proceed()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("JScene");
    }

}
