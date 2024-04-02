using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Stendas : MonoBehaviour
{
    public GameObject tekstoLaukas;
    public Text tekstoTekstas;
    public string Tekstas;
    public bool zaidejasPriestendo;
    // Start is called before the first frame update

    private void Update()
    {
        if (zaidejasPriestendo==true)
        {
          
                tekstoLaukas.SetActive(true);
                tekstoTekstas.text = Tekstas;
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Zaidejas"))
        {
            zaidejasPriestendo = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Zaidejas"))
        {
            zaidejasPriestendo = false;
            tekstoLaukas.SetActive(false);
        }
    }
}
