using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour {

    public int damage = 1;
    public float speed;

    private void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //player takes damage
            other.GetComponent<player>().health -= damage;
            Debug.Log(other.GetComponent<player>().health);
            Destroy(gameObject);
        }
    }

}
