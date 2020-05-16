using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
public class OpenCloseInventory : MonoBehaviour
{
    private Bag bag;

    public Bag MyBag
    {
        get
        {
            return bag;
        }

        set
        {
            bag = value;
        }
    }

}
