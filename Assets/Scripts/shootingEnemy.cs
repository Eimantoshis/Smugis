using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingEnemy : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    public float retreatDistance;
    public float shootRate = 1f;
    float nextShot = 0.0f;
    public GameObject projectile;
    public Transform player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Zaidejas").transform;

        
    }
    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, player.position)> stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        else if (Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
        {
            transform.position = this.transform.position;
        }
        else if (Vector2.Distance(transform.position, player.position) < retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }

        if (Time.time > nextShot)
        {
            nextShot = Time.time + shootRate;

            Instantiate(projectile, transform.position, Quaternion.identity);
            
        }
    }
}
