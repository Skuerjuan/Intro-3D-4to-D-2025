using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionAreaParkour : MonoBehaviour
{
    public GameObject UIInteractionMessage;
    public bool canInteract;
    public MercaderiaScript mercaderia;

    public ScoreManager scoreManager;

    void Start()
    {
        UIInteractionMessage.SetActive(false);
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.E) && canInteract){
            scoreManager.AddScore(mercaderia.scorePoints);
            Destroy(mercaderia.gameObject);
            EndInteraction();
        }
    }

    private void OnTriggerEnter(Collider other){
        Debug.Log(other.gameObject.name);
        mercaderia = other.GetComponent<MercaderiaScript>();
        if(mercaderia){
            UIInteractionMessage.SetActive(true);
            canInteract = true;
        }
    }

    private void OnTriggerExit(Collider other){
        EndInteraction();
    }

    void EndInteraction(){
        UIInteractionMessage.SetActive(false);
        mercaderia = null;
        canInteract = false;
    }
}
