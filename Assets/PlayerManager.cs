using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

	public class PlayerManager : MonoBehaviour {
	public GameManager gm;
	SpriteRenderer sr;
	public AudioSource enemycol;
	Animator anim;
	Rigidbody2D rb;
	public string minilevel;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		sr = GetComponent<SpriteRenderer>();
		Physics2D.IgnoreLayerCollision(8, 9, false);
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	void OnCollisionEnter2D(Collision2D col)
    {
		if(col.gameObject.tag.Equals("Enemy"))
        {
			rb.AddForce(transform.up * 200 + transform.right * 200);
			anim.SetTrigger("isHit");
			enemycol.Play();
			gm.deathManager(true);
			StartCoroutine("GetInvulnerable");

		}
		if(col.gameObject.tag.Equals("flag"))
        {
			SceneManager.LoadScene(minilevel);
        }
    }
	IEnumerator GetInvulnerable()
    {
		Physics2D.IgnoreLayerCollision(8, 9, true);
		sr.color = new Color(1f, 1f, 1f, 0.5f);
		yield return new WaitForSeconds(3f);
		Physics2D.IgnoreLayerCollision(8, 9, false);
		sr.color = new Color(1f, 1f, 1f, 1f);
	}
}
