using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	// Use this for initialization
	public bool isTutorial;
	public bool isJump = false;
	public float moveSpeed = 5f;
	Rigidbody2D rb;
	float dirX;
	bool isMoving = false;
	public AudioSource audiowalk;
	Animator an;
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		an = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{
		Jump();
		if (!isTutorial)
		{
			dirX = Input.GetAxis("Horizontal") * moveSpeed;
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			isMoving = true;
			transform.eulerAngles = new Vector3(transform.rotation.x, 0, transform.rotation.y);

		}
		else if (Input.GetKey(KeyCode.LeftArrow))
		{
			isMoving = true;
			transform.eulerAngles = new Vector3(transform.rotation.x, 180, transform.rotation.y);
		}
		//if (rb.velocity.x != 0)
		//{
		//	isMoving = true;
		//}
		//else
		//{
		//	isMoving = false;
		//}
		if(rb.velocity.x==0)
        {
			isMoving = false;
		}

		if (isMoving  && !isTutorial)
		{
			an.SetBool("isWalkRight", true);
			if (!audiowalk.isPlaying)
			{
				audiowalk.Play();
			}

		}
		else
        {
			an.SetBool("isWalkRight", false);
			audiowalk.Stop();
		}
		print(isJump);

	}

	void FixedUpdate()
    {
		rb.velocity = new Vector2(dirX, rb.velocity.y);
    }

	void Jump()
    {
		if (Input.GetKeyDown(KeyCode.UpArrow) && isJump)
		{
			an.SetTrigger("isJump");
			rb.AddForce(new Vector2(0, 5f), ForceMode2D.Impulse);
		}
    }
	void Walk()
    {

	}
	void OnCollisionStay2D(Collision2D col)
    {
		if(col.gameObject.tag.Equals("ground"))
        {
			isJump = true;
        }
    }
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag.Equals("ground"))
		{
			isJump = true;
		}
	}
	void OnCollisionExit2D(Collision2D col)
    {
		if (col.gameObject.tag.Equals("ground"))
		{
			isJump = false;
		}
	}

}
