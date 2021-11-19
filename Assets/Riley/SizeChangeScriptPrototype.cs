using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChangeScriptPrototype : MonoBehaviour
{
    public float size;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(-size, size, 0);

        // increase and decrease size
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            size += 0.1f;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            size -= 0.1f;
        }
    }
}
