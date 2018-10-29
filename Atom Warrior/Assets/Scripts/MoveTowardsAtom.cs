using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsAtom : MonoBehaviour {

	public GameObject atomPos;

	public AtomicNumber Z;

	public Charge E;

	public MassNumber M;

	Vector3 target; 
	public float moveSpeed;

	int touchcountInt =0;

	// Use this for initialization
	void Start () {
		 atomPos = GameObject.FindWithTag("Player");
		 Z = GameObject.FindWithTag("Z").GetComponent<AtomicNumber>();
		 M = GameObject.FindWithTag("M").GetComponent<MassNumber>();
		 E = GameObject.FindWithTag("E").GetComponent<Charge>();
		 
	}
	
	// Update is called once per frame
	void Update () {
		target = atomPos.transform.position;
		transform.position = Vector3.MoveTowards(transform.position, target, moveSpeed*Time.deltaTime);
	
	}
	
	void OnTriggerEnter(Collider other)
	{
		touchcountInt++;

		if(other.tag == "Player"){
			
		if(gameObject.tag == "Proton"){
			//Add atomic no by one
			if(touchcountInt<=1){Z.AtomicNo++;}			
		}

		if(gameObject.tag == "Neutron"){
			//Add neutron no by one
			if(touchcountInt<=1){M.NeutronNo++;}			
		}

		if(gameObject.tag == "Electron"){
			//Add electron no by one
			if(touchcountInt<=1){E.electronNo++;}			
		}
				//Destroy 
				Destroy(gameObject);
		}

	}

}
