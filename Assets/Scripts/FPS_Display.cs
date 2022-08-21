using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPS_Display : MonoBehaviour
{
   public Text fpsText;
    float deltaTime = 0.0f;
	int w = Screen.width, h = Screen.height;

 
	void Update()
	{
		deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
		float msec = deltaTime * 1000.0f;
		float fps = 1.0f / deltaTime;
		fpsText.text = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps);
	}
}
