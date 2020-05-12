using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemPlants : ScriptableObject
{
    public ItemPlantType type;
    public Sprite Image;
    public string description;
}

public enum ItemPlantType
{
    Stage1,
    Stage2,
    Stage3,
    Stage4,
    Stage5,
}
