using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int speed = 10;

    public Rigidbody rb;

    private bool sphereIsOnTheGround = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float moveVertical = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement * speed);

        if (Input.GetKey(KeyCode.Space) && sphereIsOnTheGround)
        {
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            sphereIsOnTheGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            sphereIsOnTheGround = true;
        }
    }
}