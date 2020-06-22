using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayerController : MonoBehaviour
{
    public float Speed = 1.0f;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");

        if (player != null)
        {
            // Position player - bullet 
            Vector3 vector3 = (player.transform.position - transform.position).normalized;
            Vector2 vector2 = new Vector2(vector3.x, vector3.y);
            GetComponent<Rigidbody2D>().velocity = vector2 * Speed;
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * Speed;
        }
    }
}
