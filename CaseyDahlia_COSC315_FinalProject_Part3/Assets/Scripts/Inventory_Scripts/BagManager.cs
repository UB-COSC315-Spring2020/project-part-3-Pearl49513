using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagManager : MonoBehaviour
{
    [SerializeField]
    private GameObject slotPrefab;

    private CanvasGroup canvasGroup;

    private List<SlotManager> slots = new List<SlotManager>();

    /*public bool IsOpen
    {
        get
        {
            return canvasGroup.alpha > 0;
        }
    }*/


    private void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void AddSlots(int slotCount)
    {
        for (int i = 0; i < slotCount; i++)
        {
            SlotManager slot = Instantiate(slotPrefab, transform).GetComponent<SlotManager>();
            slots.Add(slot);
        }
    }

    public bool AddItem(Item item)
    {
        foreach (SlotManager slot in slots)
        {
            if (slot.IsEmpty)
            {
                slot.AddItem(item);

                return true;
            }
        }

        return false;
    }



    /*public void OpenClose()
    {
        canvasGroup.alpha = canvasGroup.alpha > 0 ? 0 : 1;
        canvasGroup.blocksRaycasts = canvasGroup.blocksRaycasts == true? false : true;
    }*/


}
