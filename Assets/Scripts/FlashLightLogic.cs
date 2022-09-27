using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightLogic : MonoBehaviour
{
    public Light flashLight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Dim();
    }

    void Dim()
    {
        if(flashLight.intensity > 0.02f)
        {
            flashLight.intensity = flashLight.intensity - Time.deltaTime/20;
        }
        else
        {
            flashLight.intensity = 0;
        }
    }
}
