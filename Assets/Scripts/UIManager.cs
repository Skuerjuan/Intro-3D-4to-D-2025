using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtScore;
    public TextMeshProUGUI txtHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void UpdateScore(int score)
    {
        txtScore.text = score.ToString();
    }

    public void UpdateHealth(int health)
    {
        txtHealth.text = health.ToString();
    }
}
