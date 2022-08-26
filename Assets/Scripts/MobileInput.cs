using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MobileInput : MonoBehaviour
{
    // public DoorScript doorScript;
    // Update is called once per frame
    void Update()
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

#if UNITY_EDITOR

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
#endif       
    }
}
