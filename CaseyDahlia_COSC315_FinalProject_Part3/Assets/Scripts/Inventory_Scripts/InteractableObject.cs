using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableObject: MonoBehaviour
{
    public bool canStoreInBag;  //If true this object this object can be stored in inventory



    public void DoInteraction()
    {
        //Object Picked up and put in inventory
        gameObject.SetActive(false);
    }
}
