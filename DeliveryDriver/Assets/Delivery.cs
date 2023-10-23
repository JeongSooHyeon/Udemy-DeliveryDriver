using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;    // default : false

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("��");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Package")
        {
            Debug.Log("Package picked up");
            hasPackage = true;

        }
        if(collision.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package Delivered");
            hasPackage = false;
        }
    }
}