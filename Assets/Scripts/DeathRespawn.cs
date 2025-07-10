using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathRespawn : MonoBehaviour
{
    public float deathHeight = -20;
    
    void Update()
    {
        if (transform.position.y < deathHeight)
        {
            Debug.Log("Respawn");
            SceneManager.LoadScene("FPS parkour");
        }
    }
}
