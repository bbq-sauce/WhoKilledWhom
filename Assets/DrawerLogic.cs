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
                        isBLOpen = !isBLOpen;
                    }
                    else
                    {
                        drawerBL.SetTrigger("BLClose");
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
                        isBLOpen = !isBLOpen;
                    }
                    else
                    {
                        drawerBL.SetTrigger("BLClose");
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
                        isBROpen = !isBROpen;
                    }
                    else
                    {
                        drawerBR.SetTrigger("BRClose");
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
                        isBROpen = !isBROpen;
                    }
                    else
                    {
                        drawerBR.SetTrigger("BRClose");
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
                        isCXOpen = !isCXOpen;
                    }
                    else
                    {
                        drawerCX.SetTrigger("CXClose");
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
                        isCXOpen = !isCXOpen;
                    }
                    else
                    {
                        drawerCX.SetTrigger("CXClose");
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
                        isTLOpen = !isTLOpen;
                    }
                    else
                    {
                        drawerTL.SetTrigger("TLClose");
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
                        isTLOpen = !isTLOpen;
                    }
                    else
                    {
                        drawerTL.SetTrigger("TLClose");
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
                        isTROpen = !isTROpen;
                    }
                    else
                    {
                        drawerTR.SetTrigger("TRClose");
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
                        isTROpen = !isTROpen;
                    }
                    else
                    {
                        drawerTR.SetTrigger("TRClose");
                        isTROpen = !isTROpen;
                    }
                }
            }
        }
    }


}
