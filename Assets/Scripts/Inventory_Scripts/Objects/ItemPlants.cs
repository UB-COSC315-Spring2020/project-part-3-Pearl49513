using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ScriptableObject
public abstract class ItemPlants : ScriptableObject
{
    //What type of plant is it?
    public ItemPlantType type;

    //What does the image look like?
    public Sprite Image;

    //What is the description of the object?
    public string description;
}

//Types of Objects
public enum ItemPlantType
{
    Stage1,
    Stage2,
    Stage3,
    Stage4,
    Stage5,
}
