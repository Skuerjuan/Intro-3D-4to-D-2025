using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        uiManager.UpdateHealth(healthPoints);
    }

    public void TakeDamage(int damagePoints)
    {
        if (healthPoints <= damagePoints)
        {
            SceneManager.LoadScene("FPS parkour");
        }
        healthPoints -= damagePoints;
        uiManager.UpdateHealth(healthPoints);
    }
}
