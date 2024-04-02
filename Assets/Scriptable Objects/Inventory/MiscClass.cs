using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Tool Class", menuName = "Item/Misc")]
public class MiscClass : ItemClass
{

    public override void Use(Zaidejas caller) { }
    
    public override MiscClass getMisc() { return this; }
   
}
