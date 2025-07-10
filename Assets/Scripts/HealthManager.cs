using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public int healthPoints;
    public int maxHealthPoints;
    public UIManager uiManager;

    public GameObject txtLost;
    public GameObject player;
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
            StartCoroutine(HandleDeath());
        }
        healthPoints -= damagePoints;
        uiManager.UpdateHealth(healthPoints);
    }

    IEnumerator HandleDeath()
    {
        uiManager.UpdateHealth(0);
        txtLost.SetActive(true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("FPS parkour");
    }
}
