using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    //Detects the closest object
    public GameObject currentInteractionObject = null;
    //Detects the last closest object
    public InteractableObject currentInteractionObjectscript = null;
    //Detect players bag
    public InventoryManager Bag;


    void Update()
    {
        //Players press the "M" key to pick up and collect an object.
        if (Input.GetButtonDown("Interact") && currentInteractionObject)
        {

            //Is this object storagable in the bag?
            if (currentInteractionObjectscript.canStoreInBag)
            {
                //Item stores in bag
                Bag.AddItem(currentInteractionObject);
            }
        }
    }


    
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Player go close to the object
        if (other.CompareTag("InteractableObject"))
        {
            Debug.Log(other.name);
            currentInteractionObject = other.gameObject;
            currentInteractionObjectscript = currentInteractionObject.GetComponent<InteractableObject>();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        //Player goes away from the object
        if (other.CompareTag("InteractableObject"))
        {
            if (other.gameObject == currentInteractionObject)
            {
                currentInteractionObject = null;
            }
        }
    }
}
