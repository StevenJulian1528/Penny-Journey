using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using UnityEngine;

public class OpeningScript : MonoBehaviour
{

	public VideoPlayer vp;
	public GameObject objvp;
	public AudioSource audio;
	// Use this for initialization
	void Start()
	{
		audio.Stop();
		vp = objvp.GetComponent<VideoPlayer>();
		vp.loopPointReached += playafterFinish;
	}

	// Update is called once per frame
	void Update()
	{
		
	}
	void playafterFinish(VideoPlayer vp)
	{

		print("end opening");
		SceneManager.LoadScene("Main Menu");
	}
}
