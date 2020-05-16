using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName ="Bag",menuName ="Items/Bag",order =1)]
public class Bag: Item, IUseable
{
    private int slots;

    [SerializeField]
    private GameObject bagPrefab;

    public BagManager MyBagManager { get; set; }

    public int Slots
    {
        get
        {
            return slots;
        }
    }

    public void Initialize(int slots)
    {
        this.slots = slots;
    }

    public void Use()
    {
        MyBagManager = Instantiate(bagPrefab, InventoryManager.MyInstance.transform).GetComponent<BagManager>();
        MyBagManager.AddSlots(slots);
    }
}
