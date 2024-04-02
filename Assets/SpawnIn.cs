using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnIn : MonoBehaviour
{
    public GameObject krumas;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(krumas, Vector3.zero, Quaternion.identity);
        }
    }
}
