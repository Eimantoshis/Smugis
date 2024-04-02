using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class krumas : MonoBehaviour
{
    public GameObject sakalys;
    
    public void Iskirsti()
    {
        Debug.Log("Cut");
        Instantiate(sakalys, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
        
    }
}
