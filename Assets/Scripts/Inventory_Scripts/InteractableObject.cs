using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableObject : MonoBehaviour
{
    //If this is true, then this object this object can be stored in inventory
    public bool canStoreInBag;


    //Object Picked up and put in inventory and hidden from the game scene
    public void DoInteraction()
    {
        
        gameObject.SetActive(false);
    }
}
