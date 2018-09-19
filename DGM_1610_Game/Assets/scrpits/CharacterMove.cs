using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CharacterMove : MonoBehaviour {
	
	// Player Movement Variables 
	public int MoveSpeed;
	public float JumpHeight;

	// Player grounded variables 
	public Transform GroundCheck;
	public flaot GroundCheckRadius;
	public LayerMask WhatIsGround;
	private bool Grounded;

	// Use this for initialization
	void Start () {
		print("Hello!");
	}
	
	
	void FixedUpdate () {
		Grounded = Physics2D.OverlapCircle (GroundCheck.position, GroundCheckRadius, WhatIsGround);
	}
	
	// Update is called once per frame
	void Update () {
		
		//This code makes the character jump
		if(Input.GetKeyDown (KeyCode.Space)&& Grounded){
			Jump();
		}

		// This code makes the character move from side to side using the A&D keys
		if(Input.GetKey (KeyCode.D)){
			GetComponent<Ridgidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Ridgidbody2D>().velocity.y);

		}
		if(Input.GetKey (KeyCode.A)){
			GetComponent<Ridgidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Ridgidbody2D>().velocity.y);

		}

	}
		Public Void Jump(){
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
		}

	}