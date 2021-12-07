using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    [SerializeField]
    GameObject door;

    bool isOpened = false;
    bool isClosed = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isOpened)
        {
            isOpened = true;
            isClosed = false;
            door.transform.position += new Vector3(0, 4, 0);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!isClosed)
        {
            isOpened = false;
            isClosed = true;
            door.transform.position -= new Vector3(0, 4, 0);
        }
    }

}
