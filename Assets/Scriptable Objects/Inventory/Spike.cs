using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Tool Class", menuName = "Item/Consumable/spike")]
public class Spike : ConsumableClass
{
    public GameObject spike;
    public GameObject zaidejas;
    public override void Use(Zaidejas caller)
    {
        base.Use(caller);

       // Instantiate(spike, zaidejas.position , Quaternion);
    }
}
