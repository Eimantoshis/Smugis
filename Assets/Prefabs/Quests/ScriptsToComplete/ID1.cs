using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ID1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Zaidejas"))
        {
            QuestManager.questManager.AddQuestItem("Parduotuvės apsilankymas", 1);
        }
    }
}
