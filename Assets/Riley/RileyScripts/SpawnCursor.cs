using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCursor : MonoBehaviour
{
    public GameObject Slime;
    private SpriteRenderer sr;
    public bool InThings;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Slime.GetComponent<SizeChanging>().CanShrink == true)
        {
            sr.enabled = true;
        }
        else
        {
            sr.enabled = false;
        }
    }

    // lets us know if the cursor is in ANYTHING
    private void OnTriggerEnter2D(Collider2D collision)
    {
        InThings = true;
    }

    //lets us know if the cursor isnt in anything
    private void OnTriggerExit2D(Collider2D collision)
    {
        InThings = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        InThings = true;
    }


}
