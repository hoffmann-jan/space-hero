using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBulletController : MonoBehaviour
{
    public GameObject Bullet;
    public float Interval = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnBullet), 1f, Interval);   
    }

    void SpawnBullet()
    {
        var underMonsterPosition = new Vector3(transform.position.x, transform.position.y);
        Instantiate<GameObject>(Bullet, underMonsterPosition, Quaternion.identity);
    }
}
