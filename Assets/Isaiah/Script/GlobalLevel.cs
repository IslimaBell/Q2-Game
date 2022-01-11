using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalLevel : MonoBehaviour
{
    public static int levelNumber = 3;
    public int internalNum;

    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        internalNum = levelNumber;
    }
}
