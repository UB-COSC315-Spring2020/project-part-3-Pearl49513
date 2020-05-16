using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Tree Stage", menuName = "Tree Stage/Stage 5", order = 4)]
public class TreeStage5 : ItemPlants
{
    public void Awake()
    {
        //Types of tree stage
        type = ItemPlantType.Stage5;
    }
}
