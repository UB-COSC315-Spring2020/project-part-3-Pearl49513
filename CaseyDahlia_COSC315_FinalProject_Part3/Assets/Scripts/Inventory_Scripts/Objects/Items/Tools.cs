using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Tool Item", menuName = "Tool/Tools", order =2)]
public class Tools : ItemTool
{
    public void Awake()
    {
        type = ItemToolType.Tool;
    }
}
