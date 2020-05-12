using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Tree Stage", menuName = "Tree Stage/Stage 3", order = 4)]
public class TreeStage3 : ItemPlants
{
    public void Awake()
    {
        type = ItemPlantType.Stage3;
    }
}
