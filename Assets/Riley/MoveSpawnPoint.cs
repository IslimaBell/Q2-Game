using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpawnPoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.localPosition = new Vector3(-2, 0, 0);
        }

        //Move left
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.localPosition = new Vector3(2, 0, 0);
        }
    }
}
