using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    private bool pickUp;

    [SerializeField]
    private bool HasStick;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pickUp && Input.GetKeyDown(KeyCode.X))
        {
            PickUp();
            HasStick = true;
        }
           
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            pickUp = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            pickUp = false;
        }
    }

    private void PickUp()
    {
        Destroy(gameObject);
    }
}
