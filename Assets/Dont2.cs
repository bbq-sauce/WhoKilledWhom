using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dont2 : MonoBehaviour
{
    public GameObject parentInfObject;
    public GameObject infPanel;
    public static int completionIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        gameObject.SetActive(false);
        parentInfObject = GameObject.FindGameObjectWithTag("InfContent");
        infPanel = GameObject.FindGameObjectWithTag("InfPanel");
        completionIndex++;
        gameObject.transform.parent = parentInfObject.transform;
        gameObject.GetComponent<RectTransform>().localScale = new Vector3(1,1,1);
        if(completionIndex>=2)
        {
            infPanel.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
