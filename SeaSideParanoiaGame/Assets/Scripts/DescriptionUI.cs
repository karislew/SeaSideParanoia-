using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DescriptionUI : MonoBehaviour
{
    Inventory inventory;
    public GameObject descriptionUI;
    public TMP_Text itemNameTxt;
    public TMP_Text descriptionText;
    public Image icon;
    public Button closeButton;

    // Start is called before the first frame update
    void Start()
    {
        inventory = Inventory.instance;
        descriptionUI.SetActive(false);
        inventory.onItemClickedCallback += UpdateDescriptionUI;



    }

    // Update is called once per frame
    void Update()
    {

    }
    void UpdateDescriptionUI(Items item)
    {

        descriptionUI.SetActive(true);
        closeButton.interactable = true;
        icon.sprite = item.imageIcon;
        itemNameTxt.text = item.itemName;
        descriptionText.text = item.itemDescription;


        Debug.Log("Ayo");

    }
    public void OnClose()
    {
        descriptionUI.SetActive(false);
        closeButton.interactable = false;
    }
}
