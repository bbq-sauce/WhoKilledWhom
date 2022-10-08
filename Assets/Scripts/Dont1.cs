using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dont1 : MonoBehaviour
{
    public GameObject parentObject;
    public GameObject mobile;
    public static int disableIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        gameObject.SetActive(false);
        parentObject = GameObject.FindGameObjectWithTag("Content");
        mobile = GameObject.FindGameObjectWithTag("Mobile");
        disableIndex++;
        gameObject.transform.parent = parentObject.transform;
        if(disableIndex>=4)
        {
            mobile.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
