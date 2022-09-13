using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonBeautifier : MonoBehaviour
{
	Button but;
	Vector3 vectbut;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void exitButton()
    {
		Application.Quit();
	}

	//public void OnPointerUp(PointerEventData pointerEventData)
	//{
	//	but.transform.localScale = vectbut;
	//}

}
