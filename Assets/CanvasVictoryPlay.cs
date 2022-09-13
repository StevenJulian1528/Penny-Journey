using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasVictoryPlay : MonoBehaviour {

	public AudioSource audiosource;
	// Use this for initialization
	void Start () {
		Time.timeScale = 0;
		audiosource.Stop();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
