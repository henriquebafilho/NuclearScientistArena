﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {
	public  float Speed;
	private Rigidbody2D rb;
	Vector2 move;
	private bool faceRight;
	public bool canshot;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		faceRight = false;
        canshot = false;
	}
	
	// Update is called once per frame
	void Update () {
        
	}
	public void FixedUpdate()
	{
        move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rb.velocity = move * Speed;

		if (move.x < 0 && !faceRight) Flip();
		else if (move.x > 0 && faceRight) Flip();
	}
	private void Flip()
	{
		faceRight = !faceRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "Flor") {
			canshot = true;
		} 
	}
	void OnTriggerExit2D(Collider2D coll)
	{
		if(coll.gameObject.tag == "Flor")
		{
			canshot = false;
		}
	}
}
