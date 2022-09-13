using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class LoadDataTemp : MonoBehaviour
{
	public bool isStage1 = true;
	public bool isStage2 = false;
	public bool isStage3 = false;
	public bool isStage4 = false;
	public bool isStage5 = true;
	public bool isSoundActive = true;
	public bool isAnimasiplay = false;
	public bool isDonePlayAnim = false;

	private static LoadDataTemp ldt;
	void Awake()
	{
		DontDestroyOnLoad(transform.root.gameObject);

		if (ldt == null)
		{
			ldt = this;
		}
		else
		{
			DestroyObject(gameObject);
		}
	}
	// Use this for initialization
	void Start()
	{
		LoadGame();
	}

	// Update is called once per frame
	void Update()
	{
		SaveGame();
	}

	public void LoadGame()
	{
		// 1
		if (File.Exists(Application.persistentDataPath + "/gamesave.save"))
		{

			// 2
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/gamesave.save", FileMode.Open);
			Save save = (Save)bf.Deserialize(file);
			file.Close();

			// 
			// 4
			isStage1 = save.isStage1;
			isStage2 = save.isStage2;
			isStage3 = save.isStage3;
			isStage4 = save.isStage4;
			isStage5 = save.isStage5;
			isSoundActive = save.isSoundActive;
			isAnimasiplay = save.isAnimasiplay;
			isDonePlayAnim = save.isDonePlayAnim;

			Debug.Log("Game Loaded");

		}
		else
		{
			Debug.Log("No game saved!");
		}
	}

	public void SaveGame()
	{
		// 1
		Save save = CreateSaveGameObject();

		// 2
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(Application.persistentDataPath + "/gamesave.save");
		bf.Serialize(file, save);
		file.Close();

		// 3
		Debug.Log("Game Saved");
	}
	private Save CreateSaveGameObject()
	{
		Save save = new Save();
		save.isStage1 = isStage1;
		save.isStage2 = isStage2;
		save.isStage3 = isStage3;
		save.isStage4 = isStage4;
		save.isStage5 = isStage5;
		save.isSoundActive = isSoundActive;
		save.isAnimasiplay = isAnimasiplay;
		save.isDonePlayAnim = isDonePlayAnim;

		return save;
	}

}
