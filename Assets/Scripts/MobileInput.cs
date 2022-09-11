using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MobileInput : MonoBehaviour
{
    public Animator showAnimator;
    public bool isShowing = false;
    // public DoorScript doorScript;
    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            DoorTouch();
        }
        if(SceneManager.GetActiveScene().buildIndex == 2)
        {
            LicenseViewTouch();
        }
        

#if UNITY_EDITOR

        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            DoorClick();
        }
        if(SceneManager.GetActiveScene().buildIndex == 2)
        {
            LicenseViewClick();
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
                        SceneManager.LoadScene(2);
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
                        SceneManager.LoadScene(2);
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
