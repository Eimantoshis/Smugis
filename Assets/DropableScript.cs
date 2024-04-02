using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropableScript : MonoBehaviour
{
    [SerializeField] private ItemClass itemToAdd;
    [SerializeField] private int amount;
    private float delay;

    private InventoryManager inventoryManager = null;
    private void Start()
    {
        //delay = 5f;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //delay = 10f;

        if (other.GetComponentInParent<Zaidejas>() != null && Time.time>=delay )
        {
            //delay = delay + 5f;

            inventoryManager = other.GetComponentInParent<Zaidejas>().inventory;

            inventoryManager.Add(itemToAdd, amount);
            Destroy(gameObject);
        }
    }


}
