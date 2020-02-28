using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public int x;
    public int y;
    public int speed;
    public GameObject car;

    void Update()
    {
        car.transform.position = new Vector2 (car.transform.position.x + x * speed, car.transform.position.y + y * speed);
    }
}
