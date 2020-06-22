using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoarderCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Removes the touching game object

        if (!collision.gameObject.tag.Equals("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
}
