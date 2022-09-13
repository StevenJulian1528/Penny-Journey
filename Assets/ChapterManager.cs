using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChapterManager : MonoBehaviour {
	public LoadDataTemp ldt;

	public Image stage2, stage3, stage4, stage5;
	public Button btnstage2, btnstage3, btnstage4, btnstage5;

	// Use this for initialization
	void Start () {
		ldt = GameObject.FindWithTag("savedatatemp").GetComponent<LoadDataTemp>();
	}
	
	// Update is called once per frame
	void Update () {
		checkStage2Chap1();
		checkStage3Chap1();
		checkStage4Chap1();
		checkStage5Chap1();
	}

	public void checkStage2Chap1()
    {
		if(ldt.isStage2)
        {
			stage2.color = new Color32(255, 255, 255, 255);
			btnstage2.interactable = true;
		}
		if (!ldt.isStage2)
		{
			stage2.color = new Color32(255, 255, 255, 155);
			btnstage2.interactable = false;
		}
    }
	public void checkStage3Chap1()
	{
		if (ldt.isStage3)
		{
			stage3.color = new Color32(255, 255, 255, 255);
			btnstage3.interactable = true;
		}
		if (!ldt.isStage3)
		{
			stage3.color = new Color32(255, 255, 255, 155);
			btnstage3.interactable = false;
		}
	}

	public void checkStage4Chap1()
	{
		if (ldt.isStage4)
		{
			stage4.color = new Color32(255, 255, 255, 255);
			btnstage4.interactable = true;
		}
		if (!ldt.isStage4)
		{
			stage4.color = new Color32(255, 255, 255, 155);
			btnstage4.interactable = false;
		}
	}
	public void checkStage5Chap1()
	{
		if (ldt.isStage5)
		{
			stage5.color = new Color32(255, 255, 255, 255);
			btnstage5.interactable = true;
		}
		if (!ldt.isStage5)
		{
			stage5.color = new Color32(255, 255, 255, 155);
			btnstage5.interactable = false;
		}
	}
}
