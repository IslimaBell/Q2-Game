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
        if (Input.GetKey(KeyCode.UpArrow) && size < 4)
        {
            size += 0.01f;
        }
        if (Input.GetKey(KeyCode.DownArrow) && size > 0.2)
        {
            size -= 0.01f;
        }
    }
}
