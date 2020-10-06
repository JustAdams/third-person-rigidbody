using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    Rigidbody rb;

    Vector3 velocity;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + velocity * Time.fixedDeltaTime);
    }

    public void Move(Vector3 movementVelocity)
    {
        velocity = movementVelocity;
    }

}
