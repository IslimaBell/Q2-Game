using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Growable : MonoBehaviour
{
    public GameObject Slime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //lets see if this works
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player" && Slime.GetComponent<SizeChanging>().CanGrow == true)
        {
            Slime.GetComponent<SizeChanging>().SLevel++;
        }
    }
}
