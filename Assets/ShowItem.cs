using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowItem : MonoBehaviour
{
    public static ShowItem instance;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowDrivingLicense()
    {
        animator.SetTrigger("ShowDL");
    }

    public void ShowObituary()
    {
        animator.SetTrigger("ShowObituary");
    }

    public void ShowFamilyPhoto()
    {
        animator.SetTrigger("ShowFamily");
    }

    public void ShowJournel()
    {
        animator.SetTrigger("ShowJournel");
    }
}
