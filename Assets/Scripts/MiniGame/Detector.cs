using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Detector : MonoBehaviour {
	bool selesai = false;
	int berapadetector;
	GameObject[] detector;
	public GameObject canvasVictory;
	public int level;
	

	// Use this for initialization
	void Start () {
		detector = GameObject.FindGameObjectsWithTag("detectorpuzzle");
		berapadetector = detector.Length;
	}
	
	// Update is called once per frame
	void Update () {
		if(!selesai)
        {
			cek();
        }
	}
	public void cek()
    {
		int jumlahsudah = 0;
		for (int i=0;i<berapadetector;i++)
        {

			if(transform.GetChild(i).GetComponent<MouseDrag>().on_tempel)
            {
				jumlahsudah++;
            }
			else
			{
				i = berapadetector;
			}

			if(jumlahsudah == berapadetector)
            {
				selesai = true;
            }

			if(selesai)
            {
				cekunlockstage();
				canvasVictory.SetActive(true);


			}
        }
    }

	public void cekunlockstage()
    {
		if(level == 1)
        {
			GameObject.FindGameObjectWithTag("savedatatemp").GetComponent<LoadDataTemp>().isStage2 = true;
        }
		else if (level == 2)
		{
			GameObject.FindGameObjectWithTag("savedatatemp").GetComponent<LoadDataTemp>().isStage3 = true;
		}
		else if (level == 3)
		{
			GameObject.FindGameObjectWithTag("savedatatemp").GetComponent<LoadDataTemp>().isStage4 = true;
		}
		else if (level == 4)
		{
			GameObject.FindGameObjectWithTag("savedatatemp").GetComponent<LoadDataTemp>().isStage5 = true;
		}
		else
		{ }
	}
}
