using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MobileInput : MonoBehaviour
{
    public GameObject mobile;
    public Animator showAnimator;
    public bool isShowing = false;
    public int doorNum = 2;
    // public DoorScript doorScript;
    // Update is called once per frame
    void Update()
    {
        // all required touch behaviour in the "OutDoors" Scene
        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            doorNum = 2;
            DoorTouch();
        }
        // all required touch behaviour in the "LivingRoom" Scene
        if(SceneManager.GetActiveScene().buildIndex == 2)
        {
            doorNum = 3;
            DoorTouch();
            //LicenseViewTouch();
        }
        

#if UNITY_EDITOR

        // all required touch behaviour in the "OutDoors" Scene
        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            doorNum = 2;
            DoorClick();
        }
        // all required touch behaviour in the "LivingRoom" Scene
        if(SceneManager.GetActiveScene().buildIndex == 2)
        {
            doorNum = 3;
            DoorClick();
            //LicenseViewClick();
        }
        
        
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
                    if(Vector3.Distance(hit.transform.gameObject.transform.position,this.transform.position) < 1.5f)
                    {
                        if(SceneManager.GetActiveScene().buildIndex == 2)
                        mobile.SetActive(true);
                        SceneManager.LoadScene(doorNum);
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
                    if(Vector3.Distance(hit.transform.gameObject.transform.position,this.transform.position) < 1.5f)
                    {
                        if(SceneManager.GetActiveScene().buildIndex == 2)
                        mobile.SetActive(true);
                        SceneManager.LoadScene(doorNum);
                    }
                }
            }
        }
    }

    void LicenseViewTouch()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                if((hit.collider != null) && hit.transform.gameObject.tag == "DL")
                {
                    if(Vector3.Distance(hit.transform.gameObject.transform.position,this.transform.position) < 1.5f)
                    {
                        if(!isShowing)
                        {
                            showAnimator.SetTrigger("ShowDL");
                            isShowing = !isShowing;
                        }
                        
                    }
                }
                else if(isShowing)
                {  
                    showAnimator.SetTrigger("RemoveDL");
                    isShowing = !isShowing;      
                }
            }
        }
    }

    void LicenseViewClick()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                if((hit.collider != null) && hit.transform.gameObject.tag == "DL")
                {
                    if(Vector3.Distance(hit.transform.gameObject.transform.position,this.transform.position) < 1.5f)
                    {
                        if(!isShowing)
                        {
                            showAnimator.SetTrigger("ShowDL");
                            isShowing = !isShowing;
                        }
                        
                    }
                }
                else if(isShowing)
                {  
                    showAnimator.SetTrigger("RemoveDL");
                    isShowing = !isShowing;      
                }
            }
        }
    }

}
