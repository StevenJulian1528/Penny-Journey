using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserGun : MonoBehaviour {

	public Vector3 laserScale,posChange,tempScale,tempChange;
	public GameObject laser;
	public float timeShoot;
	bool isShot = false;
	public Animator an;
	public AnimationClip anim;
	float waitTime;
	// Use this for initialization

	private LineRenderer lineRenderer;
	public Transform laserHit;
	void Start () {
		laserScale = new Vector3(0f, 0f, -2f);
		posChange = new Vector3(-1f, 0f, 0f);
		waitTime = anim.length + 6f;
		InvokeRepeating("PlayAnim", 6f, waitTime);
	}
	
	// Update is called once per frame
	void Update () {
		

		timeShoot = timeShoot - Time.deltaTime;
		if(timeShoot <= 0 && timeShoot>=-5f)
		      {
			laser.SetActive(true);

		}
		if(timeShoot<=-5f)
		      {
			laser.SetActive(false) ;
			timeShoot = 7f;
		}
	}
	void ShootLaser(bool getParameterShot)
    {
		if (getParameterShot)
		{
			print("shoot");
			laser.transform.localScale = laserScale;
			laser.transform.position = posChange;
		}
		if(!getParameterShot)
        {
			laser.transform.localScale = tempScale;
			laser.transform.position = tempChange;
		}

	}

	void PlayAnim()
    {
		print("Play Anim Wait");
		an.SetTrigger("Awake");
    }
}
