using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutScene2ToGame : MonoBehaviour
{
    public void ButtonMoveScene(string level)
    {
        SceneManager.LoadScene(level);
    }
}
