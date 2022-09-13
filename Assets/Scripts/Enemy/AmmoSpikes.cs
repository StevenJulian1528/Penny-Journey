using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoSpikes : MonoBehaviour {
	public float speed = 20;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate((-Vector3.down * speed * Time.deltaTime));
	}
	
	void OnCollisionEnter2D(Collision2D col)
    {
		if(col.gameObject.tag.Equals("stage") || col.gameObject.tag.Equals("Enemy") || col.gameObject.tag.Equals("Player"))
        {
			Destroy(gameObject);
        }
    }
}
