using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject griovejuLimitas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B) && !griovejuLimitas.activeInHierarchy)
        {
            griovejuLimitas.SetActive(true);
            Debug.Log("ahah");
        }

       else if (Input.GetKeyDown(KeyCode.B) && griovejuLimitas.activeInHierarchy)
       {
            Debug.Log("ojoj");
            griovejuLimitas.SetActive(false);
       }
    }
}
