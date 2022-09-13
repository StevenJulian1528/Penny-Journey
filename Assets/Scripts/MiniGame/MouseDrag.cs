using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour {
	public GameObject detector;
	Vector3 pos_awal;
	public bool on_pos = false, on_tempel = false;
	// Use this for initialization
	void Start () {
		pos_awal = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDrag()
    {
		Vector3 pos_mouse = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));
		transform.position = new Vector3(pos_mouse.x, pos_mouse.y, transform.position.z);
    }

	void OnMouseUp()
    {
		if(on_pos)
        {
			transform.position = detector.transform.position;
			on_tempel = true;
        }
		else
        {
			transform.position = pos_awal;
			on_tempel = false;
		}
    }
	void OnTriggerStay2D(Collider2D objek)
    {
		if(objek.gameObject == detector)
        {
			on_pos = true;
        }
    }
	
	void OnTriggerExit2D(Collider2D objek)
    {
		if(objek.gameObject == detector)
        {
			on_pos = false;
        }
    }
}
