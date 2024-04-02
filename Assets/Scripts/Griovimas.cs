using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Griovimas : MonoBehaviour
{
    public Transform griovimoTaskas;
    public float griovimoRange = 1f;
    public LayerMask griovimoLayers;
    public GameObject medis;
    
     
    void Start() {
        medis = GameObject.FindWithTag("Medis");
      
        
    }
    void Update()
    {

        Transform  medziukas = GameObject.FindWithTag("Medis").transform;
        Transform griovejas = transform;
        if (transform.parent.gameObject.CompareTag("Zaidejas"))
        {
           griovejas = GameObject.FindWithTag("Zaidejas").transform;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && transform.parent.gameObject.CompareTag("Zaidejas") && medziukas.position.x - griovejas.position.x <= 1)
        {
            Destroy(medis);
        }




    }
    
void Griauk()
    {

        Destroy(medis);
        Collider2D[] griaukMedi = Physics2D.OverlapCircleAll(griovimoTaskas.position, griovimoRange, griovimoLayers);

        foreach (Collider2D griauk in griaukMedi)
        {
          if(  griauk.gameObject.CompareTag("Medis"))
            {
                Destroy(gameObject);
            }
        }




    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(griovimoTaskas.position, griovimoRange);
    }

}
