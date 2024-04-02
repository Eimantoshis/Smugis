using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;

    private Transform player;
    private Vector2 target;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Zaidejas").transform;

        target = new Vector2(player.position.x, player.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            if (gameObject.CompareTag("strele"))
            {
                Destroy(gameObject);
            }
        }
    }


    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Zaidejas"))
        {
        Destroy(gameObject);
        other.gameObject.GetComponent<gyvybes1>().TakeDamage(25);
        }
    }
    
}
