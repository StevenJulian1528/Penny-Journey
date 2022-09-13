using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	// Use this for initialization
	public Transform target;
	public Vector3 offset;

	public float smoothSpeed = 0.1f;
	void Start () {
		Camera.main.aspect = 20f / 11.25f;
		//offset = transform.position - target.position;
	}
	
	// Update is called once per frame
	void Update () {
	}
	private void LateUpdate()
    {
		SmoothFollow();
	}
	public void SmoothFollow()
	{
		Vector3 targetPos = target.position + offset;
		Vector3 smoothFollow = Vector3.Lerp(transform.position, targetPos, smoothSpeed);

		transform.position = smoothFollow;
		transform.LookAt(target);
	}
}
