using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    public static int points = 0;

    [SerializeField] private Transform Player;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private Transform respawnPoint2;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Coin")
        {
            points = points + 1;
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Lava" && points < 4)
        {
             Player.transform.position = respawnPoint2.transform.position;
        }
    }

    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return) && points < 4 && Player.transform.position.y < 0)
        {
            Player.transform.position = respawnPoint.transform.position;
        }
    }
}
