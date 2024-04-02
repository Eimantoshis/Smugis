using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BosoDurys : MonoBehaviour
{
    public bool ZaidejasKovoje = false;
    int enemy;
    public GameObject Durys;
    public void Start()
    {
        enemy = 0;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Zaidejas"))
        {
            ZaidejasKovoje = true;
            
            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Zaidejas"))
        {
            ZaidejasKovoje = false;
        }
    }

    private void Update()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("bosas");
        enemy = enemies.Length;
        Ziurim();
    }
    public void Ziurim()
    {
        if (ZaidejasKovoje == true && enemy == 1)
        {
            Durys.SetActive(true);
        }
        else if (ZaidejasKovoje == false || enemy == 0)
        {
            Durys.SetActive(false);
        }
    }
    
}
