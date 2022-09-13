using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafixed : MonoBehaviour {
	public LoadDataTemp ldt;

	// Use this for initialization
	void Start () {
		ldt = GameObject.FindWithTag("savedatatemp").GetComponent<LoadDataTemp>();
		Camera.main.aspect = 20f / 11.25f;
	}
	
	// Update is called once per frame
	void Update () {
		if(ldt.isSoundActive)
        {
			AudioListener.volume = 1;
        }
		if (!ldt.isSoundActive)
		{
			AudioListener.volume = 0;
		}
	}
}
