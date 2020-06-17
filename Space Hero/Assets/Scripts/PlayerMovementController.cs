using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public float Speed = 10.0f;
    new Rigidbody2D rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Fixed count of calls per second.
    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 direction = new Vector2(horizontal, vertical);

        // Normalized for length one in each directions
        rigidbody.velocity = direction.normalized * Speed;
    }
}
