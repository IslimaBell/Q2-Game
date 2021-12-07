using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChanging : MonoBehaviour
{
    public float size;
    public bool CanGrow;
    public bool CanShrink;
    public float ChangeRate;
    public float MaxSize;
    public float MinSize;
    public int SLevel;
    public GameObject Slime;
    public GameObject SlimeSpawnpoint;
    public GameObject Cursor;
    public float SlimeSpeed;
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
        if (SLevel < MaxSize)
        {
            CanGrow = true;
        }
        else
        {
            CanGrow = false;
        }

        if (SLevel > MinSize)
        {
            CanShrink = true;
        }
        else
        {
            CanShrink = false;
        }

        //Makes the player change size to the Sclass, probably a better way of doing this, i dont know it though
        if (size > (SLevel * 0.5f))
        {
            size -= ChangeRate;
        }

        if (size < (SLevel * 0.5f))
        {
            size += ChangeRate;
        }

        //player shrinking
        if(Input.GetKeyDown(KeyCode.Space) && CanShrink == true && Cursor.GetComponent<SpawnCursor>().InSomething == false)
        {
            SLevel--;
            GameObject b = Instantiate(Slime, SlimeSpawnpoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2b = b.GetComponent<Rigidbody2D>();
            rb2b.AddForce(SlimeSpeed * transform.up);
        }
    }
    }
