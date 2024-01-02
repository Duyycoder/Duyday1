using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]private Rigidbody2D yb;

    private float jumpForce = 3f;
    // Start is called before the first frame update
    void Start()
    {
        // yb.AddForce(new Vector2(x:0 ,y:100));
        yb.velocity = new Vector2(0 ,2 );
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            yb.velocity = new Vector2(0, jumpForce);
        }
        
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        // if (other.gameObject.name == "Square")
        // {
        //     Debug.Log(message:"Collided with Square");
        // }
        if (other.gameObject.CompareTag("block"))
        {
            Debug.Log(message:"Collided with block");
        }
    }

    // private void OnTriggerEnter2D(Collider2D other)
    // {
    //     if (other.gameObject.CompareTag("block"))
    //     {
    //         Debug.Log(message:"Collided with block");
    //     }
    // }
}
