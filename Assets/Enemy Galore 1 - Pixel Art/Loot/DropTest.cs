using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropTest : MonoBehaviour
{

    [SerializeField] LootTable lootTable;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            ItemClass item = lootTable.GetDrop();
            Debug.Log(item.Name);
        }
    }
}
