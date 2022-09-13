using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

	public GameObject tutorial;
	public GameObject bgtutorial;
	public GameObject playertutorial;
	public GameObject Gameplay;
	public GameObject bgmainmenu;
	public GameObject pause;
	public string nextLevel;


	public LoadDataTemp ldt;

	public Image soundbuttonImage;
	public Sprite[] soundbuttonSprite;

	public GameObject openinganimasi;
	public GameObject allobjects;
	public AudioSource bgsound;
    // Use this for initialization
    void Start () {
		ldt = GameObject.FindWithTag("savedatatemp").GetComponent<LoadDataTemp>();
	}
	
	// Update is called once per frame
	void Update () {
		if (ldt.isSoundActive)
		{
			soundbuttonImage.sprite = soundbuttonSprite[0];
			
		}
		if (!ldt.isSoundActive)
		{
			soundbuttonImage.sprite = soundbuttonSprite[1];
		}
	}
	public void buttonMainMenu()
    {
		SceneManager.LoadScene("Main Menu");
    }
	public void buttonRestart()
    {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
	public void buttonStage()
    {
		SceneManager.LoadScene("Chapter");
	}
	public void buttonLevel1()
	{
		if (ldt.isAnimasiplay)
		{
			SceneManager.LoadScene("Level1");
		}
		else
		{
			allobjects.SetActive(false);
			openinganimasi.SetActive(true);
			ldt.isAnimasiplay = true;
			bgsound.Stop();
		}
	}
	public void buttonTutorial()
    {
		bgmainmenu.SetActive(false);
		Gameplay.SetActive(false);
		tutorial.SetActive(true);
		bgtutorial.SetActive(true);
		playertutorial.SetActive(true);
	}
	public void buttonbackTutorial()
	{
		bgmainmenu.SetActive(true);
		Gameplay.SetActive(true);
		tutorial.SetActive(false);
		bgtutorial.SetActive(false);
		playertutorial.SetActive(false);
	}
	public void nextLevelFromMiniGame()
    {
		SceneManager.LoadScene(nextLevel);
    }

	public void buttonPause()
    {
		pause.SetActive(true);
		Time.timeScale = 0;
	}
	public void buttonResume()
    {
		pause.SetActive(false);
		Time.timeScale = 1;
    }

	public void buttonSound()
    {
		if (GameObject.FindGameObjectWithTag("savedatatemp").GetComponent<LoadDataTemp>().isSoundActive)
		{
			GameObject.FindGameObjectWithTag("savedatatemp").GetComponent<LoadDataTemp>().isSoundActive = false;
			print(GameObject.FindGameObjectWithTag("savedatatemp").GetComponent<LoadDataTemp>().isSoundActive);

		}
		else
		{
			GameObject.FindGameObjectWithTag("savedatatemp").GetComponent<LoadDataTemp>().isSoundActive = true;
			print(GameObject.FindGameObjectWithTag("savedatatemp").GetComponent<LoadDataTemp>().isSoundActive);
		}
	}
}
