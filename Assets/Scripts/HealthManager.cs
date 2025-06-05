using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int healthPoints;
    public int maxHealthPoints;
    public UIManager uiManager;
    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
        maxHealthPoints = 100;  
        healthPoints = maxHealthPoints;
    }

    public void TakeDamage(int damagePoints)
    {
        if (healthPoints <= damagePoints)
        {
            //gameover
            return;
        }
        healthPoints -= damagePoints;
        uiManager.UpdateHealth(healthPoints);
    }
}
