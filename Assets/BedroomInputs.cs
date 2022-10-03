using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedroomInputs : MonoBehaviour
{
    public Animator doorAnim;
    public bool isOpened = false;
    public AudioSource audioSource;
    public AudioClip doorOpen;
    public AudioClip doorClose;
    public AudioClip doorLocked;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DoorTouch();

#if UNITY_EDITOR
        DoorClick();
#endif
    }

    void DoorTouch()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                if((hit.collider != null) && hit.transform.gameObject.tag == "Door")
                {
                        if(!isOpened  && InventoryManager.itemCount == 6)
                        {
                            doorAnim.SetTrigger("DoorOpen");
                            audioSource.PlayOneShot(doorOpen);
                            isOpened = !isOpened;
                        }
                        else if(isOpened  && InventoryManager.itemCount == 6)
                        {
                            doorAnim.SetTrigger("DoorClose");
                            audioSource.PlayOneShot(doorClose);
                            isOpened = !isOpened;
                        }
                        else if(InventoryManager.itemCount < 6)
                        {
                            doorAnim.SetTrigger("Locked");
                            audioSource.PlayOneShot(doorLocked);
                            Debug.Log("Some items need to be found to Progress!");
                        }

                }
                
            }
        }
    }

    void DoorClick()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                if((hit.collider != null) && hit.transform.gameObject.tag == "Door")
                {
                       if(!isOpened  && InventoryManager.itemCount == 6)
                        {
                            doorAnim.SetTrigger("DoorOpen");
                            audioSource.PlayOneShot(doorOpen);
                            isOpened = !isOpened;
                        }
                        else if(isOpened  && InventoryManager.itemCount == 6)
                        {
                            doorAnim.SetTrigger("DoorClose");
                            audioSource.PlayOneShot(doorClose);
                            isOpened = !isOpened;
                        }
                        else if(InventoryManager.itemCount < 6)
                        {
                            doorAnim.SetTrigger("Locked");
                            audioSource.PlayOneShot(doorLocked);
                            Debug.Log("Some items need to be found to Progress!");
                        }
                }
            }
        }
    }
}
