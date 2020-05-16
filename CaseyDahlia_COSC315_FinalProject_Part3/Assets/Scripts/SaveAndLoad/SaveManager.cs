using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SaveManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Application.persistentDataPath);
    }

    // Update is called once per frame
    void Update()
    {

        {

        }
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        if (pointerEventData.button == PointerEventData.InputButton.Left)
        {
            SaveDate();
        }
    }

    private void SaveDate()
    {
        try
        {
            BinaryFormatter bf = new BinaryFormatter();

            FileStream file = File.Open(Application.persistentDataPath + "/" + "SaveTest.dat", FileMode.OpenOrCreate);

            SaveData data = new SaveData();

            SavePlayer(data);

            file.Close();
        }
        catch (System.Exception)
        {
            //This is for handling errors
        }
    }

    private void SavePlayer(SaveData data)
    {
       // data.MyDateCount = new PlayerData(PlayerControllerGridDirection.direction);
    }
    private void LoadDate()
    {
        try
        {
            BinaryFormatter bf = new BinaryFormatter();

            FileStream file = File.Open(Application.persistentDataPath + "/" + "SaveTest.dat", FileMode.Open);

            SaveData data = (SaveData)bf.Deserialize(file);

            file.Close();

            LoadPlayer(data);
        }
        catch (System.Exception)
        {
            //This is for handling errors
        }

    }

    private void LoadPlayer(SaveData data)
    {
       // PlayerControllerGridDirection.direction = data.MyDateCount.direction;
    }
}