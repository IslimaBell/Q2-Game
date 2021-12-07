using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCursor : MonoBehaviour
{
    public GameObject Slime;
    private SpriteRenderer sr;
    private BoxCollider2D coll;
    public bool InSomething;

    public LayerMask Ground;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        coll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        InSomething = Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.up, 0f, Ground);

        if (Slime.GetComponent<SizeChanging>().CanShrink == true)
        {
            sr.enabled = true;
        }
        else
        {
            sr.enabled = false;
        }
    }

    
    
}
