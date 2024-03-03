using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRB : MonoBehaviour
{
    public float speed = 10f;
    

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        HandleInput();
    }

    

    void HandleInput()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, 0f, verticalInput);
        rb.AddForce(direction * speed);

       
    }

   
}
