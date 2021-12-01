using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChangeScriptPrototype : MonoBehaviour
{
    public float size;
    public bool CanGrow;
    public bool CanShrink;
    public float ChangeRate;
    public float MaxSize;
    public float MinSize;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ensures the scaling of the object is equal to the size variable
        transform.localScale = new Vector3(-size, size, 0);

        //keeps track of wether the object can shrink or grow
        if (size<MaxSize)
        {
            CanGrow = true;
        }
        else
        {
            CanGrow = false;
        }

        if (size > MinSize)
        {
            CanShrink = true;
        }
        else
        {
            CanShrink = false;
        }

        // increase and decrease size variable for debug purposes
        if (Input.GetKey(KeyCode.UpArrow) && CanGrow==true)
        {
            size += ChangeRate;
        }
        if (Input.GetKey(KeyCode.DownArrow) && CanShrink==true)
        {
            size -= ChangeRate;
        }
    }
}
