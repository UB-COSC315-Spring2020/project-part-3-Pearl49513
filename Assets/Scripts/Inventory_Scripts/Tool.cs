using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Tool : MonoBehaviour
{
    //Detects scriptable object
    public ItemTool tool;

    private void Awake()
    {
        //Develops an render image of the picked up tool
        if (tool.Image.Equals(null) || tool.Image.Equals(""))
        {
            Debug.LogWarning(tool.name + "does not have an image applied");
        }

        gameObject.GetComponent<SpriteRenderer>().sprite = tool.Image;
    }
}
