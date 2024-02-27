using System;
using System.Collections;
using System.Collections.Generic;
using GameTool;
using Unity.Mathematics;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]private Rigidbody2D yb;

    private float jumpForce = 4.0f;
    public float cooldown;
    public float timeShoot = 0.5f;
    public float boundTop = 2.5f;
    public float boundBottom = -2.5f;
    

    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        // yb.AddForce(new Vector2(x:0 ,y:100));
        //yb.velocity = new Vector2(0 ,2 );
        cooldown = timeShoot;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            yb.velocity = new Vector2(0, jumpForce);

           
        }
        var pos = transform.position;
        if (pos.y >= boundTop)
        {
            transform.position = new Vector2(transform.position.x, boundTop);
        }

        if (pos.y <= boundBottom)
        {
            transform.position = new Vector2(transform.position.x, boundBottom);
        }

        cooldown -= Time.deltaTime;
        if (cooldown <= 0.0f)
        {
            PoolingManager.Instance.GetObject(NamePrefabPool.Bullet, parent: null, transform.position).Disable(1.3f);
            cooldown = timeShoot;
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

        // Instantiate(prefab, new Vector3(0f, -1.4f, 0f), quaternion.identity);
        // Destroy(other.gameObject);
    }

    // private void OnTriggerEnter2D(Collider2D other)
    // {
    //     if (other.gameObject.CompareTag("block"))
    //     {
    //         Debug.Log(message:"Collided with block");
    //     }
    // }
   
}
