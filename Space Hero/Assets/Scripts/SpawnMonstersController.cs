using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonstersController : MonoBehaviour
{
    public GameObject Monster1;
    public GameObject Monster2;
    public float Interval = 3;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnMonster), Interval, Interval);
    }

    private void SpawnMonster()
    {
        float random = Random.value;

        if (random <= 0.2)
        {
            Instantiate(Monster1, transform.position, Quaternion.identity);
        }
        else if (random <= 0.4)
        {
            Instantiate(Monster2, transform.position, Quaternion.identity);
        }
    }
}
