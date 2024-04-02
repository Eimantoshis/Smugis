using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zaidejas : MonoBehaviour
{
    public static Zaidejas zaidejas;

    public GameObject invPanel;
    public InventoryManager inventory;
    public bool invPanelActive = false;


    public GameObject zaidalas;
    private BoxCollider2D boxCollider;
    private Vector3 judaDelta;
    public float zaidejoGreitis = 1f;
    private RaycastHit2D smugis;
    public Animator animator;
    public Transform platforma;
    public Transform kastoks;
    public Transform pos2;
    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        
    }
    private void FixedUpdate()
    {
        // reset judadelta
        judaDelta = Vector3.zero;
        float xKryptis = Input.GetAxisRaw("Horizontal");
        float yKryptis = Input.GetAxisRaw("Vertical");

        judaDelta = new Vector3(xKryptis, yKryptis, 0);
        //sukimosi keitimas judant i kaire arba desine
        if (judaDelta.x > 0)
            transform.localScale = new Vector3(1.5f, 1.7f, 1);
        else if (judaDelta.x < 0)
            transform.localScale = new Vector3(-1.5f, 1.7f, 1);
        //kad judetume reikia numesti dezute, jeigu dezute nulis galim judet
        smugis = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(0, judaDelta.y), Mathf.Abs(judaDelta.y * Time.deltaTime * zaidejoGreitis), LayerMask.GetMask("Veikejas", "Blokavimas", "Griovimo"));
        if (smugis.collider == null)
        {
            animator.SetFloat("ZaidejoGreitis", Mathf.Abs(judaDelta.y));
            //judejimas
            transform.Translate(0, judaDelta.y * Time.deltaTime * zaidejoGreitis, 0);
        }
        smugis = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(judaDelta.x, 0), Mathf.Abs(judaDelta.x * Time.deltaTime * zaidejoGreitis), LayerMask.GetMask("Veikejas", "Blokavimas", "Griovimo"));
        if (smugis.collider == null)
        {
            animator.SetFloat("ZaidejoGreitis", Mathf.Abs(judaDelta.x));
            //judejimas
            transform.Translate(judaDelta.x * Time.deltaTime * zaidejoGreitis, 0, 0);
        }
       
    }

    public void Greiciaujuda(float judesys)
    {
        zaidejoGreitis += judesys;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //use the item
            if(inventory.selectedItem != null)
            {
                inventory.selectedItem.Use(this);
                //inventory.gameObject.GetComponent<InventoryManager>().UseSelected();
            }
           
        }
        
       
    }
    public void OnTriggerEnter2D(Collider2D collider)
   {
        if (collider.gameObject.CompareTag("Platforma"))
        {

           
            zaidalas.transform.parent = collider.gameObject.transform;
          kastoks.position = platforma.position;
        // if (pos2.position.y - platforma.position.y > 5 )
          // {
            //   zaidejoGreitis = 0f;
         //  }
            
          //  zaidalas = GameObject.FindWithTag("Platforma");
        }
   }
  public void OnTriggerExit2D(Collider2D collider)
    { 
        if (collider.gameObject.CompareTag("Platforma"))
       {
           zaidalas.transform.parent = null;
        }
    }



}

