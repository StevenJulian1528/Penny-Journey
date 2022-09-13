using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public GameObject[] lifeSprites;
	public GameObject canvasVictory, canvasGameOver;
	public AudioSource soundbg;
	int life = 3;
	// Use this for initialization
	void Start () {
		Time.timeScale = 1f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void deathManager(bool death)
    {
		print(life);
		if(death)
        {
			if (life > 0)
			{
				life--;
				lifeSprites[life].SetActive(false);
			}
			else
            {
				gameOver();
            }
        }
    }
	void gameOver()
    {
		soundbg.Stop();
		canvasGameOver.SetActive(true);
    }


}
