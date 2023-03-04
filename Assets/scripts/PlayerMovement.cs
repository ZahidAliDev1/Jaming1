using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //[SerializeField] private float movementSpeed = 5f;
    //[SerializeField] private float jumpForce = 10f;

    //private Rigidbody rb;

    //private void Awake()
    //{
    //    rb = GetComponent<Rigidbody>();
    //}

    //private void FixedUpdate()
    //{
    //    Move();
    //    Jump();
    //}

    //private void Move()
    //{
    //    float horizontalMovement = Input.GetAxis("Horizontal");
    //    float verticalMovement = Input.GetAxis("Vertical");

    //    Vector3 movement = new Vector3(horizontalMovement, 0f, verticalMovement);

    //    rb.AddForce(movement * movementSpeed, ForceMode.Acceleration);
    //}

    //private void Jump()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.01f)
    //    {
    //        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    //    }
    //}



}
