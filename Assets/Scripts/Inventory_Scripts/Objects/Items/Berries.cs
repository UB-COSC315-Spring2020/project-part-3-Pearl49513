using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Berries Item", menuName = "Objects/Berries", order =3)]
public class Berries : ItemObject
{
    public void Awake()
     {
        //Types of berries
         type = ItemObjectType.Berries;
     }
}
