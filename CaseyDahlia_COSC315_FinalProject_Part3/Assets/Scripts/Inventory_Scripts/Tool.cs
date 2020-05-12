using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Tool : MonoBehaviour
{
    public ItemTool tool;

    private void Awake()
    {
        if (tool.Image.Equals(null) || tool.Image.Equals(""))
        {
            Debug.LogWarning(tool.name + "does not have an image applied");
        }

        gameObject.GetComponent<SpriteRenderer>().sprite = tool.Image;
    }
}
