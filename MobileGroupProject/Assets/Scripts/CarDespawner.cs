using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDespawner : MonoBehaviour
{
    /*
     * 
     *if GameObject tagged car collides w/ object 
     *      destroy collision.gameobject (the car)
     * 
     */

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Car")
        {
            Destroy(collision.gameObject);
        }
    }
}
