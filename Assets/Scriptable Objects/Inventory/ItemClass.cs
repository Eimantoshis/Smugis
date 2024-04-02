using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemClass : ScriptableObject
{
    public string Name;
    public GameObject whatToDrop;
    [Header("item")]//data shared across every item
    public string itemName;
    public Sprite itemIcon;
    public int stackSize = 64;
    public bool isStackable = true;
    
    public virtual void Use(Zaidejas caller)
    {
        
    }
    public virtual ItemClass getItem() { return this; }
    public virtual ToolClass getTool() { return null; }
    public virtual MiscClass getMisc() {return null; }
    public virtual ConsumableClass getConsumable() { return null; }

}
