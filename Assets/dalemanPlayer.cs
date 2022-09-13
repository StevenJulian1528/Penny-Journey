using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dalemanPlayer : MonoBehaviour {
	public Movement mv;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D col)
    {
		if(col.gameObject.tag.Equals("ground"))
        {
			mv.isJump = false;
        }
    }
	void OnCollisionExit2D(Collision2D col)
	{
		if (col.gameObject.tag.Equals("ground"))
		{
			mv.isJump = true;
		}
	}
}
