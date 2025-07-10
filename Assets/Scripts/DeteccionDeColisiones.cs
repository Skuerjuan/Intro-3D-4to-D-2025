using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeteccionDeColisiones : MonoBehaviour
{
    public GameObject txtWon;

    void Start()
    {
        txtWon.SetActive(false);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            StartCoroutine(Reset());
        }
    }

    IEnumerator Reset()
    {
        Destroy(gameObject);
        txtWon.SetActive(true);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("FPS parkour");
    }
}
