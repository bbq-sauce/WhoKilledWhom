using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastSceneScript : MonoBehaviour
{
    public Animator openAnim;
    public Camera cam1;
    public Camera mainCam;
    public bool isPlayed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(InventoryManager.itemCount >= 13)
        {
            LastScene();
        }
    }

    void LastScene()
    {
        openAnim.SetTrigger("OpenSesame");
        if(!isPlayed)
        {
            StartCoroutine(CamSwitch());
            isPlayed = !isPlayed;
        }
        
    }

    public IEnumerator CamSwitch()
    {
        mainCam.enabled = false;
        cam1.enabled = true;
        yield return new WaitForSeconds(5);
        cam1.enabled = false;
        mainCam.enabled = true;
    }
}
