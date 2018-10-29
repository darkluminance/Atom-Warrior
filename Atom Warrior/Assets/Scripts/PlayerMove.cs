using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	public float moveSpeed;

	// Use this for initialization
	void Start () {
		transform.position = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		float moveX = Input.GetAxis("Horizontal");
		float moveY = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3 (moveX, moveY, 0);

		GetComponent<Rigidbody>().velocity = movement * moveSpeed * Time.fixedDeltaTime;
	}
}
