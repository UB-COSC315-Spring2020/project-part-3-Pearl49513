using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{

    //public List<Slot> Bag = new List<Slot>();

    //private List<Image> Icon = new List<Image>();

    [SerializeField]
    private GameObject[] Bag = new GameObject[10];

    [SerializeField]
    public Button[] SlotButton = new Button[10];

    //[SerializeField]
    //public Image[] ImageSlot = new Image[10];

    //private Image[] Icon = new Image[10];

    //private Item item;

    //public CanvasGroup canvasGroup;

    //[SerializeField]
    //public GameObject slot = GameObject.Find("Slot");

    //[SerializeField]
    //public GameObject image = GameObject.Find("Image");

    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    public void AddItem(GameObject _object)
    {
        bool itemAdded = false;//Find a free open slot in the bag
        //int _amount = 1;

        for (int i = 0; i < Bag.Length; i++)//foreach (Image slotButton in imageSlot)
        {
            if (Bag[i] == null/*_item*/)
            {
                itemAdded = true;
                Bag[i] = _object;
                SlotButton[i].transform.GetChild(0).GetComponent<Image>().sprite = _object.GetComponent<Item>().item.Image;
                //Bag[i].GetComponent<InteractableObject>().DoInteraction();
               
                //Bag[i].AddAmount(_amount);                
                //Update UI
                //ImageSlot[i].overrideSprite = _object.GetComponent<SpriteRenderer>().sprite;
                //Icon[i].overrideSprite = _item.GetComponent<SpriteRenderer>().sprite;
                Debug.Log(_object.name + "is added.");
                //Doing Something with the object
                _object.SendMessage("DoInteraction");
                Bag[i].GetComponent<InteractableObject>().DoInteraction();
                break;
            }
        }
        if (!itemAdded)
        {
            Debug.Log("Inventory is Full");
        }
    }
}

[System.Serializable]
public class Slot : InventoryManager
{

}
