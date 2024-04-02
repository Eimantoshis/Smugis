using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Tool Class", menuName = "Item/Tool/Tool")]
public class ToolClass : ItemClass
{
    [Header("Tool")]
    public ToolType toolType;
    public enum ToolType
    {
        weapon,
        pickaxe,
        hammer,
        axe
    }

    public override void Use(Zaidejas caller)
    {
        
        base.Use(caller);
        
    }

    public override ToolClass getTool() { return this; }
    
  
}
