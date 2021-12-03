using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeStopper : MonoBehaviour
{
    public GameObject Slime;
    public float SizeRequired;
    private Rigidbody2D rb2;
    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Slime.GetComponent<SizeChanging>().SLevel >= SizeRequired)
        {
            rb2.drag = 0;
            rb2.mass = 1;
        }
        else
        {
            rb2.drag = 10000;
            rb2.mass = 10000;
        }
    }
}
