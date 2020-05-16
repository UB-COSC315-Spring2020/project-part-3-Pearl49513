using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ScriptableObject
public abstract class ItemTool : ScriptableObject
{
    //What type of tool is it?
    public ItemToolType type;

    //What does the image look like?
    public Sprite Image;

    //What is the description of the object?
    public string description;
}

//Types of Objects
public enum ItemToolType
{
    Tool,
}

