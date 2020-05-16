using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryMenu : MonoBehaviour
{
    //Status that Inventory is open
    public static bool IsClosed = false;
    public GameObject inventoryMenuUI;

    // Update is called once per frame
    void Update()
    {
        //Player press the I key on the keyboard to open/close the inventory
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (IsClosed)
            {
                Close();
            }
            else
            {
                Open();
            }
        }
    }

    //Inventory is closed
    void Close()
    {
        Time.timeScale = 1f;
        inventoryMenuUI.SetActive(false);
        IsClosed = false;
        Debug.Log("Inventory suppose to close");
        //InventoryManager.MyInstance.OpenClose();
    }

    //Inventory is opened
    void Open()
    {
        Time.timeScale = 1f;
        inventoryMenuUI.SetActive(true);
        IsClosed = true;
        Debug.Log("Inventory suppose to open.");
        //InventoryManager.MyInstance.OpenClose();
    }
}
