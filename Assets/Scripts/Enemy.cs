using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Enemy : MonoBehaviour
{
    [SerializeField] LootTable lootTable;

    

    public int EnemyMaxHealth = 100;
    public int EnemyCurrentHealth;

    public bosas boss;
    public GameObject healthCanvas;

    public RandomSpawner spawner;
    
    public Transform Bosiukas;
    public Transform BossSpawner;

    public GameObject griovejas;
    public bool griovejasAktyvus = false;
    private int bosasMires =0;
    

   



    // Start is called before the first frame update
    void Start()
    {

        spawner = GameObject.FindObjectOfType<RandomSpawner>();
        BossSpawner = GameObject.FindGameObjectWithTag("BossSpawner").transform;

        EnemyCurrentHealth = EnemyMaxHealth;
       

        if (Bosiukas)
        {
            
        }


    }
    private void Update()
    {

        
    }

    

    public void EnemyTakeDamage (int damage)
    {
        
        EnemyCurrentHealth -= damage;
        
        if (EnemyCurrentHealth <= 0)
        {
            spawner.OnKill();
            ItemClass item = lootTable.GetDrop();
           
            Instantiate(item.whatToDrop, transform.position, Quaternion.identity);
            if (item.whatToDrop == griovejas)
            {
                griovejasAktyvus = true;
               
            }
            if (griovejasAktyvus == true){

                DestroyWithTag("Griovejas");
                
                Instantiate(griovejas, new Vector3 (7.63f, 2.11f, 0), Quaternion.identity);
            }

            QuestManager.questManager.AddQuestItem("Nuþudyti prieðai", 1);

            if (gameObject.CompareTag("Goblin"))
            {
                QuestManager.questManager.AddQuestItem("Nuþudyti golemai", 1);
                
            }
            if (gameObject.CompareTag("Wizard"))
            {
                QuestManager.questManager.AddQuestItem("Nuþudytos kaukolës", 1);
                
            }
            if (Bosiukas)
            {
                //spawner.GetComponent<RandomSpawner>().SpawnRate(-999999);
                // BossSpawner.GetComponent<BossSpawner>().BossSpawnRate(-999499);

                spawner.bosasMires = 1;
                healthCanvas.SetActive(false);
            }
           Destroy(gameObject);
            


            

        }
    }
    
    
    public void DestroyWithTag(string destroyTag)
    {
        GameObject[] destroyObject;
        destroyObject = GameObject.FindGameObjectsWithTag(destroyTag);
        foreach (GameObject oneObject in destroyObject)
            Destroy(oneObject);
    }

    public void BosoCanvasON()
    {
        healthCanvas.SetActive(true);
    }
    public void BosoCanvasOff()
    {
        healthCanvas.SetActive(false);
    }

    



}
