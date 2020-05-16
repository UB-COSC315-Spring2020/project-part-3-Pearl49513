using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item : MonoBehaviour
{
    //Detects scriptable object
    public ItemObject item;


    private void Awake()
    {
        //Develops an render image of the picked up item
        if (item.Image.Equals(null) || item.Image.Equals(""))
        {
            Debug.LogWarning(item.name + "does not have an image applied");
        }

        gameObject.GetComponent<SpriteRenderer>().sprite = item.Image;

    }
}
