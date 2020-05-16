using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{

    //[SerializeField]
    //public Image[] ImageSlot = new Image[10];

    //private Image[] Icon = new Image[10];

    //private Item item;

    //public CanvasGroup canvasGroup;

    //[SerializeField]
    //public GameObject slot = GameObject.Find("Slot");

    //[SerializeField]
    //public GameObject image = GameObject.Find("Image");

    //public List<Slot> Bag = new List<Slot>();

    //private List<Image> Icon = new List<Image>();
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    //Slots for currect gameobjects that can store in bag
    [SerializeField]
    private GameObject[] Bag = new GameObject[10];

    //Slots that can show images of the current item
    [SerializeField]
    public Button[] SlotButton = new Button[10];


    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    
    //Adding Object in the bag
    public void AddItem(GameObject _object)
    {
        //Find a free open slot in the bag
        bool itemAdded = false;
        //int _amount = 1;( Not able to stack)

        for (int i = 0; i < Bag.Length; i++)
        {
            if (Bag[i] == null)
            {
                itemAdded = true;
                Bag[i] = _object;
                SlotButton[i].transform.GetChild(0).GetComponent<Image>().sprite = _object.GetComponent<Item>().item.Image;
                //SlotButton[i].transform.GetChild(0).GetComponent<Image>().sprite = _object.GetComponent<Tool>().tool.Image; (Not able to use it)
                //Bag[i].GetComponent<InteractableObject>().DoInteraction(); (Not able to use it)
                //Bag[i].AddAmount(_amount);  (Not able to stack)              
                //ImageSlot[i].overrideSprite = _object.GetComponent<SpriteRenderer>().sprite;(Old)
                //Icon[i].overrideSprite = _item.GetComponent<SpriteRenderer>().sprite; (Old)

                //Updating UI--------------------------------------------------------------------
                Debug.Log(_object.name + "is added.");
                
                //Picking up the object
                _object.SendMessage("DoInteraction");
                Bag[i].GetComponent<InteractableObject>().DoInteraction();
                break;
            }
        }
        //Item cannot be added will be lefted alone
        if (!itemAdded)
        {
            Debug.Log("Inventory is Full");
        }
    }
}
