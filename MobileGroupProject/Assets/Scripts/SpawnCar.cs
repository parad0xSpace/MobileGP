using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCar : MonoBehaviour
{
    public GameObject[] cars;
    float timer;
    public float timerStart = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        timer = timerStart;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 0)
        {
            CarSpawn();
        }
    }

    void CarSpawn()
    {
        int i = Random.Range(0, cars.Length - 1);
        int t = Random.Range(1, 5);

        Instantiate(cars[i], transform.position, transform.rotation);
        timer = t;
    }
}
