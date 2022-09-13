using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class LoadingScript : MonoBehaviour {

	public VideoPlayer vp;
	public GameObject objvp, allgo;
	// Use this for initialization
	void Start () {
		vp = objvp.GetComponent<VideoPlayer>();
		vp.loopPointReached += playafterFinish;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void playafterFinish(VideoPlayer vp)
    {
		print("loading end");
		allgo.SetActive(true);
		objvp.SetActive(false);
	}
}
