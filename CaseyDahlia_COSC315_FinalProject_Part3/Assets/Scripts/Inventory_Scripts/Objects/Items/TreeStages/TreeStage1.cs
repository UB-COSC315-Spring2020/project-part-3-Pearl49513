using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Tree Stage", menuName = "Tree Stage/Stage 1", order = 4)]
public class TreeStage1 : ItemPlants
{
    public void Awake()
    {
        type = ItemPlantType.Stage1;
    }
}
