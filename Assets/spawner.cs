using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

    public GameObject obstacle;

    private float timeBtwSpawn;
    public float startTimeBtwSpawn;

    private void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            Instantiate(obstacle, transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
        } else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
