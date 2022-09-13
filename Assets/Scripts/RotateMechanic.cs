using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMechanic : MonoBehaviour {

	// Use this for initialization
	public GameObject map;
	public GameObject tutorial;
	public GameObject flag;
	public GameObject[] spikesrantai, spikespatrol;
	public float speedchar,speedmap;
	Quaternion currentAngle, currentAngleMap, currentSpikes;
	int zanjing;
	int zanjingmap;
	int zanjingspike;
	Animator anim;
	public AudioSource pagingSound;


	void Start () {
		anim = GetComponent<Animator>();
	}
	// Update is called once per frame
	void Update () {


		if (Input.GetKeyDown(KeyCode.D))
		{
			RotateAngleCharRight();
			if (pagingSound != null)
			pagingSound.Play();

		}
		if (Input.GetKeyDown(KeyCode.A))
		{
			RotateAngleCharLeft();
			pagingSound.Play();

		}
		//if (Input.GetKeyDown(KeyCode.W))
		//{
		//	RotateAngleCharUp();
		//	pagingSound.Play();

		//}
		//if (Input.GetKeyDown(KeyCode.S))
		//{
		//	RotateAngleCharUp();
		//	pagingSound.Play();

		//}
		this.transform.rotation = Quaternion.Slerp(this.transform.rotation, currentAngle, 0.08f);
		map.transform.rotation = Quaternion.Slerp(map.transform.rotation, currentAngleMap, 0.03f);
		if (spikesrantai != null)
			for (int i = 0;i<spikesrantai.Length;i++)
        {
			spikesrantai[i].transform.rotation = Quaternion.Slerp(spikesrantai[i].transform.rotation, currentAngle, 0.03f);
		}
		if(spikespatrol != null)
		for (int i = 0; i < spikespatrol.Length; i++)
		{
			spikespatrol[i].transform.rotation = Quaternion.Slerp(spikespatrol[i].transform.rotation, currentAngle, 0.03f);
		}
		if (tutorial != null)
        {
			tutorial.transform.rotation = Quaternion.Slerp(map.transform.rotation, currentAngleMap, 0.03f);
		}
		//flag.transform.rotation = Quaternion.Slerp(map.transform.rotation, currentAngleMap, 0.03f);
		//spikesammo.transform.rotation = Quaternion.Slerp(spikes.transform.rotation, currentAngle, 0.03f);


	}
	void RotateAngleCharRight()
    {
		if (zanjingmap == 0)
		{
			zanjingmap = 270;
			zanjing = 0;
		}
		else if (zanjingmap == 270)
		{
			zanjing = 0;
			zanjingmap = 180;
		}
		else if (zanjingmap == 180)
		{
			zanjing = 0;
			zanjingmap = 90;
		}
		else if(zanjingmap == 90)
		{
			zanjing = 0;
			zanjingmap = 0;
		}
		currentAngle = Quaternion.Euler(0, 0, zanjing);
		currentAngleMap = Quaternion.Euler(0, 0, zanjingmap);
	}
	void RotateAngleCharLeft()
	{
		if (zanjingmap == 0)
		{
			zanjingmap = 90;
			zanjing = 0;
		}
		else if (zanjingmap == 90)
		{
			zanjing = 0;
			zanjingmap = 180;
		}
		else if (zanjingmap == 180)
		{
			zanjing = 0;
			zanjingmap = 270;
		}
		else if (zanjingmap == 270)
		{
			zanjing = 0;
			zanjingmap = 0;
		}
		currentAngle = Quaternion.Euler(0, 0, zanjing);
		currentAngleMap = Quaternion.Euler(0, 0, zanjingmap);
	}
	void RotateAngleCharUp()
	{
		if (zanjingmap == 0)
		{
			zanjingmap = 180;
			zanjing = 0;
		}
		else if (zanjingmap == 90)
		{
			zanjing = 0;
			zanjingmap = 270;
		}
		else if (zanjingmap == 180)
		{
			zanjing = 0;
			zanjingmap = 0;
		}
		else if (zanjingmap == 270)
		{
			zanjing = 0;
			zanjingmap = 90;
		}
		currentAngle = Quaternion.Euler(0, 0, zanjing);
		currentAngleMap = Quaternion.Euler(0, 0, zanjingmap);
	}
	void RotateAngleCharDown()
	{
		if (zanjingmap == 0)
		{
			zanjingmap = 180;
			zanjing = 0;
		}
		else if (zanjingmap == 180)
		{
			zanjing = 0;
			zanjingmap = 0;
		}
		else if (zanjingmap == 90)
		{
			zanjing = 0;
			zanjingmap = 270;
		}
		else if (zanjingmap == 270)
		{
			zanjing = 0;
			zanjingmap = 90;
		}
		currentAngle = Quaternion.Euler(0, 0, zanjing);
		currentAngleMap = Quaternion.Euler(0, 0, zanjingmap);
	}
}
