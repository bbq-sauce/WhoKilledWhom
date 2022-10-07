using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerLogic : MonoBehaviour
{
    public Animator drawerBL;
    public bool isBLOpen = false;
    public Animator drawerBR;
    public bool isBROpen = false;
    public Animator drawerCX;
    public bool isCXOpen = false;
    public Animator drawerTL;
    public bool isTLOpen = false;
    public Animator drawerTR;
    public bool isTROpen = false;
    public AudioSource audioSource;
    public AudioClip drawerOpen;
    public AudioClip drawerClose;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        OpenBLTouch();
        OpenBRTouch();
        OpenCXTouch();
        OpenTLTouch();
        OpenTRTouch();

#if UNITY_EDITOR
        OpenBLClick();
        OpenBRClick();
        OpenCXClick();
        OpenTLClick();
        OpenTRClick();
#endif
    }

    void OpenBLTouch()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                if((hit.collider != null) && hit.transform.gameObject.tag == "BL")
                {
                    if(!isBLOpen)
                    {
                        drawerBL.SetTrigger("BLOpen");
                        audioSource.PlayOneShot(drawerOpen);
                        isBLOpen = !isBLOpen;
                    }
                    else
                    {
                        drawerBL.SetTrigger("BLClose");
                        audioSource.PlayOneShot(drawerClose);
                        isBLOpen = !isBLOpen;
                    }
                }
            }
        }
    }

    void OpenBLClick()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                if((hit.collider != null) && hit.transform.gameObject.tag == "BL")
                {
                    if(!isBLOpen)
                    {
                        drawerBL.SetTrigger("BLOpen");
                        audioSource.PlayOneShot(drawerOpen);
                        isBLOpen = !isBLOpen;
                    }
                    else
                    {
                        drawerBL.SetTrigger("BLClose");
                        audioSource.PlayOneShot(drawerClose);
                        isBLOpen = !isBLOpen;
                    }
                }
            }
        }
    }

    void OpenBRTouch()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                if((hit.collider != null) && hit.transform.gameObject.tag == "BR")
                {
                    if(!isBROpen)
                    {
                        drawerBR.SetTrigger("BROpen");
                        audioSource.PlayOneShot(drawerOpen);
                        isBROpen = !isBROpen;
                    }
                    else
                    {
                        drawerBR.SetTrigger("BRClose");
                        audioSource.PlayOneShot(drawerClose);
                        isBROpen = !isBROpen;
                    }
                }
            }
        }
    }
    void OpenBRClick()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                if((hit.collider != null) && hit.transform.gameObject.tag == "BR")
                {
                    if(!isBROpen)
                    {
                        drawerBR.SetTrigger("BROpen");
                        audioSource.PlayOneShot(drawerOpen);
                        isBROpen = !isBROpen;
                    }
                    else
                    {
                        drawerBR.SetTrigger("BRClose");
                        audioSource.PlayOneShot(drawerClose);
                        isBROpen = !isBROpen;
                    }
                }
            }
        }
    }
    void OpenCXTouch()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                if((hit.collider != null) && hit.transform.gameObject.tag == "CX")
                {
                    if(!isCXOpen)
                    {
                        drawerCX.SetTrigger("CXOpen");
                        audioSource.PlayOneShot(drawerOpen);
                        isCXOpen = !isCXOpen;
                    }
                    else
                    {
                        drawerCX.SetTrigger("CXClose");
                        audioSource.PlayOneShot(drawerClose);
                        isCXOpen = !isCXOpen;
                    }
                }
            }
        }
    }
    void OpenCXClick()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                if((hit.collider != null) && hit.transform.gameObject.tag == "CX")
                {
                    if(!isCXOpen)
                    {
                        drawerCX.SetTrigger("CXOpen");
                        audioSource.PlayOneShot(drawerOpen);
                        isCXOpen = !isCXOpen;
                    }
                    else
                    {
                        drawerCX.SetTrigger("CXClose");
                        audioSource.PlayOneShot(drawerClose);
                        isCXOpen = !isCXOpen;
                    }
                }
            }
        }
    }
    void OpenTLTouch()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                if((hit.collider != null) && hit.transform.gameObject.tag == "TL")
                {
                    if(!isTLOpen)
                    {
                        drawerTL.SetTrigger("TLOpen");
                        audioSource.PlayOneShot(drawerOpen);
                        isTLOpen = !isTLOpen;
                    }
                    else
                    {
                        drawerTL.SetTrigger("TLClose");
                        audioSource.PlayOneShot(drawerClose);
                        isTLOpen = !isTLOpen;
                    }
                }
            }
        }
    }
    void OpenTLClick()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                if((hit.collider != null) && hit.transform.gameObject.tag == "TL")
                {
                    if(!isTLOpen)
                    {
                        drawerTL.SetTrigger("TLOpen");
                        audioSource.PlayOneShot(drawerOpen);
                        isTLOpen = !isTLOpen;
                    }
                    else
                    {
                        drawerTL.SetTrigger("TLClose");
                        audioSource.PlayOneShot(drawerClose);
                        isTLOpen = !isTLOpen;
                    }
                }
            }
        }
    }
    void OpenTRTouch()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                if((hit.collider != null) && hit.transform.gameObject.tag == "TR")
                {
                    if(!isTROpen)
                    {
                        drawerTR.SetTrigger("TROpen");
                        audioSource.PlayOneShot(drawerOpen);
                        isTROpen = !isTROpen;
                    }
                    else
                    {
                        drawerTR.SetTrigger("TRClose");
                        audioSource.PlayOneShot(drawerClose);
                        isTROpen = !isTROpen;
                    }
                }
            }
        }
    }
    void OpenTRClick()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                if((hit.collider != null) && hit.transform.gameObject.tag == "TR")
                {
                    if(!isTROpen)
                    {
                        drawerTR.SetTrigger("TROpen");
                        audioSource.PlayOneShot(drawerOpen);
                        isTROpen = !isTROpen;
                    }
                    else
                    {
                        drawerTR.SetTrigger("TRClose");
                        audioSource.PlayOneShot(drawerClose);
                        isTROpen = !isTROpen;
                    }
                }
            }
        }
    }


}
