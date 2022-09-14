using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dont1 : MonoBehaviour
{
    public GameObject parentObject;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        gameObject.SetActive(false);
        parentObject = GameObject.FindGameObjectWithTag("Content");
        gameObject.transform.parent = parentObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
