using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemTool : ScriptableObject
{
    public ItemToolType type;
    public Sprite Image;
    public string description;
}

public enum ItemToolType
{
    Tool,
}

