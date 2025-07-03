using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    public GameObject UIInteractionMessage;
    public bool canInteract;
    public MercaderiaScript mercaderia;

    void Start(){
        UIInteractionMessage.SetActive(false);
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.E) && canInteract){
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
