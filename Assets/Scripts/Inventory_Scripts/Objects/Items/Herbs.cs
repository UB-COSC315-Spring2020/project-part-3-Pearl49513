using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Herb Item", menuName = "Objects/Herbs")]
public class Herbs : ItemObject
{
    public void Awake()
    {
        //Types of herb
        type = ItemObjectType.Herb;
    }
}
