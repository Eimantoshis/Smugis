using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class bosas : MonoBehaviour
{
    public Enemy enemy;
    
    public bool HealthCanvasActive = false;
    public TMP_Text bossHealth;

    public gyvybes healthBar;

    private int healthBoss;

    void Start()
    {
        
        healthBoss = enemy.EnemyMaxHealth;
        
        healthBar.SetMaxHealth(enemy.EnemyMaxHealth);
        bossHealth.text = enemy.EnemyMaxHealth.ToString();
        

    }

    // Update is called once per frame
    void Update()
    {
        healthBoss = enemy.EnemyCurrentHealth;
        
        bossHealth.text = enemy.EnemyCurrentHealth.ToString();
        healthBar.SetHealth(enemy.EnemyCurrentHealth);

        
    }
}
