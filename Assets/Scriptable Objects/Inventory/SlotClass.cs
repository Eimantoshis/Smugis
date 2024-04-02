using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SlotClass
{
    [field: SerializeField] public ItemClass item { get; private set; } = null;
    [field: SerializeField] public int quantity { get; private set; } = 0;
    [field: SerializeField] public Sprite sprite { get; private set; } = null;
    [field: SerializeField] public string name { get; private set; } = null;
    //public SlotType slotType { get; private set; } = SlotType.def;

    public SlotClass()
    {
        item = null;
        quantity = 0;
        sprite = null;
    }
    public SlotClass(ItemClass _item, int _quantity)
    {
        item = _item;
        quantity = _quantity;
    }
    public SlotClass(SlotClass slot)
    {
        this.item = slot.GetItem();
        this.quantity = slot.GetQuantity();
    }
    public void Clear()
    {
        this.item = null;
        this.quantity = 0;
    }

    public ItemClass GetItem() { return item; }
    public int GetQuantity() { return quantity; }
    public void AddQuantity(int _quantity) { quantity += _quantity; }
    public void SubQuantity(int _quantity)
    {
        quantity -= _quantity;
        if (quantity <= 0)
        {
            Clear();
        }
    }
    public void AddItem(ItemClass item, int quantity)
    {
        this.item = item;
        this.quantity = quantity;
    }
}

