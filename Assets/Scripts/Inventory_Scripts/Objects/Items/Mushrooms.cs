using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Mushroom Item", menuName = "Objects/Mushrooms")]
public class Mushrooms : ItemObject
{
    public void Awake()
    {
        //Types of mushrooms
        type = ItemObjectType.Mushroom;
    }
}
