using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerController))]
public class Player : MonoBehaviour
{
    PlayerController pc;

    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        pc = GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        // Movement
        Vector3 moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        Vector3 moveVelocity = moveInput.normalized * speed;
        pc.Move(moveVelocity);
    }
}
