using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonopening : MonoBehaviour {

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void buttonskipanimasi()
    {
		//ldt = GameObject.FindGameObjectWithTag("savedatatemp").GetComponent<LoadDataTemp>().
		SceneManager.LoadScene("Main Menu");
    }
}
