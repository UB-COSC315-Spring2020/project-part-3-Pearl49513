using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ScriptableObject
public abstract class ItemObject : ScriptableObject
{
    //What type of object is it?
    public ItemObjectType type;

    //What does the image look like?
    public Sprite Image;

    //What is the description of the object?
    public string description;

    //How much does it sell?
    public int sellCost;

    //What is the stack size?
    public int stackSize;
}

//Types of Objects
public enum ItemObjectType
{
    Berries,
    Herb,
    Mushroom,
}


