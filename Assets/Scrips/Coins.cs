using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour

{
    private int speed_z = 2;
    private float speed_rotation = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Coin").transform.position.y <= 0.484)
        {
            speed_z = -2;
        }

        if (GameObject.FindGameObjectWithTag("Coin").transform.position.y >= 1.5)
        {
            speed_z = 2;
        }

        transform.Translate(0, 0, speed_z * Time.deltaTime);

        transform.Rotate(0, 0, speed_rotation);
    }
}

