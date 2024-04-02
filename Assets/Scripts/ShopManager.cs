using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopManager : MonoBehaviour
{
    public float coins;
    public TMP_Text coinUI;
    public ShopItemSO[] shopItemsSO;
    public GameObject[] shopPanelsGO;
    public ShopTemplate[] shopPanels;
    public Button[] MyPurchaseBtns;
    public Transform Zaidejas1;

    public static ShopManager shopManager;

    void Start()
    {
        for (int i = 0; i < shopItemsSO.Length; i++)
            shopPanelsGO[i].SetActive(true);
        coinUI.text = "Monetos: " + coins.ToString();
        LoadPanels();
        CheckPurchasable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddCoins()
    {
        coins++;
        coinUI.text = "Monetos: " + coins.ToString();
        CheckPurchasable();

    }

    public void CheckPurchasable()
    {
        for (int i=0; i <shopItemsSO.Length; i++)
        {
            if (coins >= shopItemsSO[i].baseCost)
            {
                MyPurchaseBtns[i].interactable = true;
            }
            else
                MyPurchaseBtns[i].interactable = false;
        }
    }

    public void PurchaseItem(int btnNr)
    {
        if (coins >= shopItemsSO[btnNr].baseCost)
        {
            coins = coins - shopItemsSO[btnNr].baseCost;
            coinUI.text = "Monetos: " + coins.ToString();
            CheckPurchasable();

            if (btnNr == 0)
            {
                Zaidejas1.GetComponent<gyvybes1>().BonusMaxHealth(5);
            }

            if (btnNr == 1)
                         {
                   Zaidejas1.GetComponent<gyvybes1>().BonusHealth(25);
            }
            if (btnNr == 2)
            {
                Zaidejas1.GetComponent<Zaidejas>().Greiciaujuda(0.1f);
            }
             
            
                
            

        }

    }

    public void LoadPanels()
    {
        for (int i =0; i< shopItemsSO.Length; i++)
        {
            shopPanels[i].titleTxt.text = shopItemsSO[i].title;
            shopPanels[i].descriptionTxt.text = shopItemsSO[i].description;
            shopPanels[i].costTxt.text = "Monetos: " + shopItemsSO[i].baseCost.ToString();
        }
    }

    public void TakeCoins(float take)
    {
        coins += take;
        coinUI.text = "Monetos: " + coins.ToString();
        CheckPurchasable();
    }
    
}
