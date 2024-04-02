using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingMinimize : MonoBehaviour
{
    public GameObject craftingOpen;
    public GameObject craftingClosed;

    public void closing()
    {
        craftingOpen.SetActive(false);
        craftingClosed.SetActive(true);
    }

    public void opening()
    {
        craftingOpen.SetActive(true);
        craftingClosed.SetActive(false);
    }




}
