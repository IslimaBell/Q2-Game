using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceUp : MonoBehaviour
{
    public GameObject Player;
    public float BouncePower;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, BouncePower);
        }
    }

}
