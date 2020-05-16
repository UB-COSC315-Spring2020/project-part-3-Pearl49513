using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryMenu : MonoBehaviour
{
    public static bool IsClosed = false;
    public GameObject inventoryMenuUI;

    // Update is called once per frame
    void Update()
    {
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

    void Close()
    {
        Time.timeScale = 1f;
        inventoryMenuUI.SetActive(false);
        IsClosed = false;
        Debug.Log("Inventory suppose to close");
        //InventoryManager.MyInstance.OpenClose();
    }

    void Open()
    {
        Time.timeScale = 1f;
        inventoryMenuUI.SetActive(true);
        IsClosed = true;
        Debug.Log("Inventory suppose to open.");
        //InventoryManager.MyInstance.OpenClose();
    }
}
