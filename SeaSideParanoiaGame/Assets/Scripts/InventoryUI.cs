using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    Inventory inventory;
    public Transform itemsParent;
    InventorySlot[] itemSlots;
    public GameObject inventoryUi;
   
    void Start()
    {
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateUI;
        inventoryUi.SetActive(false);
        
        itemSlots = GetComponentsInChildren<InventorySlot>(true);
    }
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E))
        { 
            inventoryUi.SetActive(!inventoryUi.activeSelf);
        }


    }
    void UpdateUI()
    {
        //going through the inventory slots and adding items from the list 
        for (int i = 0; i < itemSlots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                itemSlots[i].AddItem(inventory.items[i]);
            }
            else
            {
                itemSlots[i].ClearSlot();
            }
        }
        Debug.Log("Update that UI");
    }
}
