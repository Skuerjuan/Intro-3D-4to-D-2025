using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirObstaculo : MonoBehaviour
{
    public HealthManager healthManager;
    public int damagePoints = 10;

    private void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            Destroy(gameObject);
            healthManager.TakeDamage(damagePoints);
        }
    }
}
