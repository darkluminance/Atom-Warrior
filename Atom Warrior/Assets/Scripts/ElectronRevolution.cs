using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectronRevolution : MonoBehaviour {

	public float spinSpeed;
	public Vector3 spinDirection;

	public Transform nucleusPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround(nucleusPosition.position, spinDirection, spinSpeed * Time.deltaTime);
	}
}
