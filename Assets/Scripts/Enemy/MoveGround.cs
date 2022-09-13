﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGround : MonoBehaviour {

    public Transform pos1, pos2;
    public float speed;
    public Transform startPos;

    Vector3 nextPos;
    // Start is called before the first frame update
    void Start()
    {
        nextPos = startPos.position;
        Vector3 pos = transform.position;
        pos.z = 0;
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == pos1.position)
        {
            nextPos = pos2.position;
        }
        if (transform.position == pos2.position)
        {
            nextPos = pos1.position;
        }
        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);


    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Player")) ;
        //col.gameObject.transform.SetParent(gameObject.transform);
    }
    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Player")) ;
        //col.gameObject.transform.parent = null;
    }

    //private void OnDrawGizmos()
    //{
    //    Gizmos.DrawLine(pos1.position, pos2.position);
    //}
}
