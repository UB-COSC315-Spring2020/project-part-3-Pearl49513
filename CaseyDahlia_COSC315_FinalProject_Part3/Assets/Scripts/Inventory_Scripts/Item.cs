using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item : MonoBehaviour
{
    public ItemObject item;


    private void Awake()
    {
        if (item.Image.Equals(null) || item.Image.Equals(""))
        {
            Debug.LogWarning(item.name + "does not have an image applied");
        }

        gameObject.GetComponent<SpriteRenderer>().sprite = item.Image;

    }
}
