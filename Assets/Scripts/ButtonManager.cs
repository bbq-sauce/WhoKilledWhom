using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Animator animator;
    public GameObject mobileButton;
    public Text buttonText;
    public GameObject mobile;

    
    public void RemoveDL()
    {
        animator.SetTrigger("RemoveDL");
        mobileButton.GetComponent<Button>().enabled = true;
        mobileButton.GetComponent<Image>().enabled = true;
        buttonText.enabled = true;
    }

    public void RemoveFamily()
    {
        animator.SetTrigger("RemoveFamily");
        mobileButton.GetComponent<Button>().enabled = true;
        mobileButton.GetComponent<Image>().enabled = true;
        buttonText.enabled = true;
    }

    public void RemoveObituary()
    {
        animator.SetTrigger("RemoveObituary");
        mobileButton.GetComponent<Button>().enabled = true;
        mobileButton.GetComponent<Image>().enabled = true;
        buttonText.enabled = true;
    }

    public void RemoveJournel()
    {
        animator.SetTrigger("RemoveJournel");
        mobileButton.GetComponent<Button>().enabled = true;
        mobileButton.GetComponent<Image>().enabled = true;
        buttonText.enabled = true;
    }

    public void RemoveAid()
    {
        animator.SetTrigger("RemoveAid");
        mobileButton.GetComponent<Button>().enabled = true;
        mobileButton.GetComponent<Image>().enabled = true;
        buttonText.enabled = true;
    }

    public void RemoveCan()
    {
        animator.SetTrigger("RemoveCan");
        mobileButton.GetComponent<Button>().enabled = true;
        mobileButton.GetComponent<Image>().enabled = true;
        buttonText.enabled = true;
    }

    public void RemovePills()
    {
        animator.SetTrigger("RemovePills");
        mobileButton.GetComponent<Button>().enabled = true;
        mobileButton.GetComponent<Image>().enabled = true;
        buttonText.enabled = true;
    }

    public void RemoveBottle()
    {
        animator.SetTrigger("RemoveBottle");
        mobileButton.GetComponent<Button>().enabled = true;
        mobileButton.GetComponent<Image>().enabled = true;
        buttonText.enabled = true;
    }

    public void RemoveKeroseneCan()
    {
        animator.SetTrigger("RemoveKerosene");
        mobileButton.GetComponent<Button>().enabled = true;
        mobileButton.GetComponent<Image>().enabled = true;
        buttonText.enabled = true;
    }

    public void RemoveSponge()
    {
        animator.SetTrigger("RemoveSponge");
        mobileButton.GetComponent<Button>().enabled = true;
        mobileButton.GetComponent<Image>().enabled = true;
        buttonText.enabled = true;
    }

    public void RemoveTowel()
    {
        animator.SetTrigger("RemoveTowel");
        mobileButton.GetComponent<Button>().enabled = true;
        mobileButton.GetComponent<Image>().enabled = true;
        buttonText.enabled = true;
    }

    public void RemoveKnife()
    {
        animator.SetTrigger("RemoveKnife");
        mobileButton.GetComponent<Button>().enabled = true;
        mobileButton.GetComponent<Image>().enabled = true;
        buttonText.enabled = true;
    }

    public void RemoveKey()
    {
        animator.SetTrigger("RemoveKey");
        mobileButton.GetComponent<Button>().enabled = true;
        mobileButton.GetComponent<Image>().enabled = true;
        buttonText.enabled = true;
    }
}
