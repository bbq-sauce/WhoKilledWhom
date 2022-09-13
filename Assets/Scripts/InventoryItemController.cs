using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItemController : MonoBehaviour
{
    public Item item;
    public Animator animator;
    public GameObject mobile;
    public GameObject mobileButton;
    void Start()
    {
        animator = GameObject.FindGameObjectWithTag("Animator").GetComponent<Animator>();
        mobile = GameObject.FindGameObjectWithTag("Mobile");
        mobileButton = GameObject.FindGameObjectWithTag("MobileButton");
    }

    public void AddItem(Item newItem)
    {
        item = newItem;
    }
    public void UseItems()
    {
        switch (item.itemType)
        {
            case Item.ItemType.DrivingLicense:
                animator.SetTrigger("ShowDL");
                mobile.SetActive(false);
                mobileButton.SetActive(true);
                break;
            case Item.ItemType.FamilyPhoto:
                animator.SetTrigger("ShowFamily");
                mobile.SetActive(false);
                mobileButton.SetActive(true);
                break;
            case Item.ItemType.Obituary:
                animator.SetTrigger("ShowObituary");
                mobile.SetActive(false);
                mobileButton.SetActive(true);
                break;
            case Item.ItemType.Journel:
                animator.SetTrigger("ShowJournel");
                mobile.SetActive(false);
                mobileButton.SetActive(true);
                break;
            
            
            default:
                break;
        }
    }
}
