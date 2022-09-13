using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryManager : MonoBehaviour
{
   public AudioSource audioSource;
   public AudioClip vibrateClip;
   public static InventoryManager instance;
   public List<Item> items = new List<Item>();
   public Transform itemContent;
   public GameObject inventoryItem;
   public InventoryItemController[] inventoryItems;

   void Awake()
   {
        instance = this;
   }

   public void Add(Item item)
   {
        items.Add(item);
        audioSource.PlayOneShot(vibrateClip);
   }

   public void ListItems()
   {
        foreach (Transform item in itemContent)
        {
            Destroy(item.gameObject);
        }

        foreach (var item in items)
        {
            GameObject obj = Instantiate(inventoryItem, itemContent);
            var itemName = obj.transform.Find("ItemName").GetComponent<TextMeshProUGUI>();
            var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();

            itemName.text = item.itemName;
            itemIcon.sprite = item.icon;
        }
        SetInventoryItems();
   }

   public void SetInventoryItems()
   {
          inventoryItems = itemContent.GetComponentsInChildren<InventoryItemController>();
          for (int i = 0; i < items.Count; i++)
          {
               inventoryItems[i].AddItem(items[i]);
          }
   }
   
}
