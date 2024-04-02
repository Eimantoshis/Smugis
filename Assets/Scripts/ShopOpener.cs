using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopOpener : MonoBehaviour
{
    public GameObject Canvas;

    public void OpenCanvas()
    {
        if (Canvas != null)
        {
            Canvas.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Zaidejas"))
        {
            OpenCanvas();
        }
    }
}
