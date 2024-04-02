using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazda : MonoBehaviour
{
    
    public Rigidbody2D rb;
    public Camera cam;
    public Transform ugniesTaskas;
    public GameObject saudaloPrefab;
     public float saudaloJega = 20f;
    private float nextAttack;
    private float attackRate = 1f;
    
    Vector2 mousePos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetKeyDown(KeyCode.Mouse0) && transform.parent.gameObject.CompareTag("Zaidejas")&& Time.time >= nextAttack)
        {
            Saudyk();
            nextAttack = Time.time + attackRate;
        }
    }
    void Saudyk()
    {
        GameObject saudalas = Instantiate(saudaloPrefab, ugniesTaskas.position, ugniesTaskas.rotation);
        Rigidbody2D rb = saudalas.GetComponent<Rigidbody2D>();
        rb.AddForce(ugniesTaskas.up * saudaloJega, ForceMode2D.Impulse);
    }
    private void FixedUpdate()
    {
        if (transform.parent.gameObject.CompareTag("Zaidejas"))
        {
            Vector2 ziurejimoKryptis = mousePos - rb.position;
            float kampas = Mathf.Atan2(ziurejimoKryptis.y, ziurejimoKryptis.x) * Mathf.Rad2Deg - 90f;
            rb.rotation = kampas;

        }

    }
}
