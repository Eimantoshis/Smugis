using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopCloser : MonoBehaviour
{
    public GameObject Canvas;

    public void CloseCanvas()
    {
        if (Canvas != null)
        {
            Canvas.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
