using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPlayerWithEnemyController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Monster"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
