using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingButton : MonoBehaviour
{
    public GameObject inventory;
   

        public void craftingButton(int number)
        {
        
            inventory.GetComponent<InventoryManager>().Craft(inventory.GetComponent<InventoryManager>().craftingRecipes[number]);
        
        }
   
}
