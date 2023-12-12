using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public MainCharacter mainCharacter;
    public int maxHealth = 3;
    public int currentHealth;
    public HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (mainCharacter.life == 3)
        {
            currentHealth = 3;
            healthBar.SetHealth(currentHealth);
        } else if (mainCharacter.life == 2)
        {
            currentHealth = 2;
            healthBar.SetHealth(currentHealth);
        } else if (mainCharacter.life == 1)
        {
            currentHealth = 1;
            healthBar.SetHealth(currentHealth);
        } else if (mainCharacter.life == 0)
        {
            currentHealth = 0;
            healthBar.SetHealth(currentHealth);
        }
    }
}
