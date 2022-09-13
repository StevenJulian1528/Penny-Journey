using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeGun : MonoBehaviour {
	public GameObject spikebullet,firepoint;
	// Use this for initialization
	void Start () {
		InvokeRepeating("ShootProjectiles", 6f, 6f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void ShootProjectiles()
    {
		Instantiate(spikebullet, firepoint.transform.position, firepoint.transform.rotation);
	}
}
