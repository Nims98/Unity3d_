using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    private bool jumpKeyPressed;
    private float horizontalPosition;
    private Rigidbody playerBdy;
    // Start is called before the first frame update
    void Start()
    {
        playerBdy = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyPressed = true;
        }
        horizontalPosition = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        if (jumpKeyPressed)
        {
            playerBdy.AddForce(0, 5, 0, ForceMode.VelocityChange);
            jumpKeyPressed = false;
        }
        playerBdy.velocity = new Vector3(horizontalPosition, playerBdy.velocity.y, 0);

    }
}
