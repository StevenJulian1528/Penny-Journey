using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeball : MonoBehaviour {

	public GameObject[] spikeaktif;
	// Use this for initialization
	void Start () {
		for(int i =0;i<spikeaktif.Length;i++)
        {
			spikeaktif[i].SetActive(true);
        }
	}
	
	// Update is called once per frame
	void Update () {
	}
}
