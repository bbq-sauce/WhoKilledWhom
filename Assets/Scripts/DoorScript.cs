using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DoorScript : MonoBehaviour
{
    public static bool isDoorTriggered = false;
    void OnTriggerEnter(Collider other)
    {
        isDoorTriggered = !isDoorTriggered;       
    }
    // void OnTriggerExit(Collider other1)
    // {
    //     isDoorTriggered = false;       
    // }    
}



