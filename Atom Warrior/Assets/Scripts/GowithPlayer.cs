using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GowithPlayer : MonoBehaviour {

	public Transform atomPos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (atomPos.position.x + 1, atomPos.position.y, 0);
	}
}
