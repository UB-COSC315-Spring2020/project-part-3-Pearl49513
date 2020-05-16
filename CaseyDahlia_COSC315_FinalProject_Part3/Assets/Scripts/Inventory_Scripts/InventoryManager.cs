using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    private static InventoryManager instance;
    public static InventoryManager MyInstance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<InventoryManager>();
            }

            return instance;
        }
    }

    private List<Bag> bags = new List<Bag>();

    private OpenCloseInventory[] openCloseInventorys;

    [SerializeField]
    private Item[] items;



    private void Awake()
    {
        Bag bag = (Bag)Instantiate(items[0]);
        bag.Initialize(10);
        bag.Use();
    }

   /* private void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            Bag bag = (Bag)Instantiate(items[0]);
            bag.Initialize(2);
            AddItem(bag);
            Debug.Log("Item added");
        }

    }*/

    public void AddItem(Item item)
    {
        foreach (Bag bag in bags)
        {
            if (bag.MyBagManager.AddItem(item))
            {
                return;
            }
        }
    }

    /*public void OnTriggerEnter2D(Collider2D collision)
    {
        Bag bag = (Bag)Instantiate(items[0]);
        bag.Initialize(20);
        var item = collision.GetComponent<Item>();
        if (item)
        {
            AddItem(bag);
            Destroy(collision.gameObject);
            Debug.Log("Touched item)");
        }


    }*/




    /*public void OpenClose()
    {
        bool closedBag = bags.Find(x => !x.MyBagManager.IsOpen);

        foreach (Bag bag in bags)
        {
            if (bag.MyBagManager.IsOpen != closedBag)
            {
                bag.MyBagManager.OpenClose();
            }
        }
    }*/

}
