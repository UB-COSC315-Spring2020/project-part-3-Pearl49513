using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{

    public GameObject currentInteractionObject = null;
    public InteractableObject currentInteractionObjectscript = null;
    public InventoryManager Bag;


    void Update()
    {
        if(Input.GetButtonDown ("Interact") && currentInteractionObject)
        {

            //Is this object storagable in the bag?
            if (currentInteractionObjectscript.canStoreInBag)
            {
                Bag.AddItem(currentInteractionObject);
            }
        }
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("InteractableObject"))
        {
            Debug.Log(other.name);
            currentInteractionObject = other.gameObject;
            currentInteractionObjectscript = currentInteractionObject.GetComponent<InteractableObject>();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("InteractableObject"))
        {   if(other.gameObject == currentInteractionObject)
            {
                currentInteractionObject = null;
            }
        }
    }
}
