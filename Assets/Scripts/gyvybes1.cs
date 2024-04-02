using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class gyvybes1 : MonoBehaviour
{
    public static gyvybes1 gyvybes;
    public int maxHealth = 100;
    public int currentHealth;
    public gyvybes healthBar;
    public TMP_Text HealthText;

    private float delaybeforeload = 10f;
    private float timeElapsed;
    void Start()
    {
        
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        HealthText.text = maxHealth.ToString();
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        
    }
    public void BonusHealth(int bonushealth)
    {
        currentHealth += bonushealth;
        healthBar.SetHealth(currentHealth);
        
    }
    public void BonusMaxHealth (int bonusmaxhealth)
    {
        maxHealth +=  bonusmaxhealth;
        healthBar.SetHealth(currentHealth);
        healthBar.SetMaxHealth(maxHealth);
        
    }
    private void Update()
    {
        timeElapsed += Time.deltaTime;
        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }
        
        healthBar.SetHealth(currentHealth);
        HealthText.text = currentHealth.ToString();
        if (currentHealth <= 0 )
        {
            timeElapsed += Time.deltaTime;
            if (timeElapsed > delaybeforeload)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            
        }
    }
}