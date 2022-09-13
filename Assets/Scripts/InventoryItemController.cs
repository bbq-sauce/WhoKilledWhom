﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemController : MonoBehaviour
{
    public bool isShowing = false;
    public Item item;
    public Item tempItem;
    public Animator animator;
    public GameObject mobile;
    public GameObject mobileButton;
    public Text buttonText;
    void Start()
    {
        animator = GameObject.FindGameObjectWithTag("Animator").GetComponent<Animator>();
        mobile = GameObject.FindGameObjectWithTag("Mobile");
        mobileButton = GameObject.FindGameObjectWithTag("MobileButton");
        buttonText = mobileButton.GetComponentInChildren<Text>();
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
                mobileButton.GetComponent<Button>().enabled = false;
                mobileButton.GetComponent<Image>().enabled = false;
                buttonText.enabled = false;
                isShowing = !isShowing;
                break;
            case Item.ItemType.FamilyPhoto:
                animator.SetTrigger("ShowFamily");
                mobile.SetActive(false);
                mobileButton.GetComponent<Button>().enabled = false;
                mobileButton.GetComponent<Image>().enabled = false;
                buttonText.enabled = false;
                isShowing = !isShowing;
                break;
            case Item.ItemType.Obituary:
                animator.SetTrigger("ShowObituary");
                mobile.SetActive(false);
                mobileButton.GetComponent<Button>().enabled = false;
                mobileButton.GetComponent<Image>().enabled = false;
                buttonText.enabled = false;
                isShowing = !isShowing;
                break;
            case Item.ItemType.Journel:
                animator.SetTrigger("ShowJournel");
                mobile.SetActive(false);
                mobileButton.GetComponent<Button>().enabled = false;
                mobileButton.GetComponent<Image>().enabled = false;
                buttonText.enabled = false;
                isShowing = !isShowing;
                break;
            
            
            default:
                break;
        }
    }
}
