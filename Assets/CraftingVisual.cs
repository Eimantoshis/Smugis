using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CraftingVisual : MonoBehaviour
{
    public CraftingRecipeClass recipe;

    public GameObject value1;
    public GameObject product1;

    public GameObject value2;
    public GameObject product2;
    public GameObject value3;
    public GameObject product3;


    public GameObject name1;
    public GameObject name2;
    public GameObject name3;


    // Start is called before the first frame update
    void Start()
    {
        value1.gameObject.GetComponent<TextMeshProUGUI>().text = recipe.inputItems[0].quantity.ToString();
        product1.gameObject.GetComponent<Image>().sprite = recipe.inputItems[0].sprite;
        name1.gameObject.GetComponent<TextMeshProUGUI>().text = recipe.inputItems[0].name;
        value2.gameObject.GetComponent<TextMeshProUGUI>().text = recipe.inputItems[1].quantity.ToString();
        product2.gameObject.GetComponent<Image>().sprite = recipe.inputItems[1].sprite;
        name2.gameObject.GetComponent<TextMeshProUGUI>().text = recipe.inputItems[1].name;
        value3.gameObject.GetComponent<TextMeshProUGUI>().text = recipe.outputItem.quantity.ToString();
        product3.gameObject.GetComponent<Image>().sprite = recipe.outputItem.sprite;
        name3.gameObject.GetComponent<TextMeshProUGUI>().text = recipe.outputItem.name;
       

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
