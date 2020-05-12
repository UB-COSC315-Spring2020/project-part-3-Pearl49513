using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemObject : ScriptableObject
{
    public ItemObjectType type;
    public Sprite Image;
    public string description;
    public int sellCost;
    public int stackSize;
}

public enum ItemObjectType
{
    Berries,
    Herb,
    Mushroom,
}


