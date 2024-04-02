using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class medkirtys : MonoBehaviour
{
    private float nextAttack;
    private float attackRate = 1f;



    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Medis") && Input.GetKeyDown(KeyCode.Mouse0)) //&& Time.time >= nextAttack) 
        {
            Debug.Log("praejo");
            nextAttack = Time.time + attackRate;
            collision.gameObject.GetComponent<krumas>().Iskirsti();
            
        }
    }


}
