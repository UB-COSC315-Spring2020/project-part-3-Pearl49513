using System;
using UnityEngine;

[Serializable]
public class SaveData
{
    public PlayerData MyDateCount{ get; set; }

    public SaveData()
    {

    }
}

[Serializable]
public class PlayerData
{
    public int DateCount { get; set; }
    public Vector2 direction;

    public PlayerData(int date)
    {
        this.DateCount = date;
    }

    public PlayerData(Vector2 direction)
    {
        this.direction = direction;
    }
}