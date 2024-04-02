using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Tool Class", menuName = "Item/Consumable")]
public class ConsumableClass : ItemClass
{
    [Header("Consume")]
    public ConsumableType consumableType;
    public enum ConsumableType
    {
        Eatable,
        Castable
    }

    [Header("Consumable")]
    public int healthAdded;

    public override void Use(Zaidejas caller)
    {

        

        base.Use(caller);
        
        caller.inventory.UseSelected();
        caller.gameObject.GetComponent<gyvybes1>().BonusHealth(healthAdded);
        
        
    }
    public override ConsumableClass getConsumable() { return this; }

    
}
