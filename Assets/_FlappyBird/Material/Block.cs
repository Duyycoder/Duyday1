using System;
using System.Collections;
using System.Collections.Generic;
using GameTool;
using UnityEngine;

public class Block : BasePooling
{
    // private void OnTrigg
    // {
    //     if (other.gameObject.CompareTag("Bullet"))
    //     {
    //         Debug.Log(message:"Hit block");
    //         other.gameObject.SetActive(false);
    //     }   
    // }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Debug.Log(message:"Hit block");
            other.gameObject.SetActive(false);
        }   
    }
}
