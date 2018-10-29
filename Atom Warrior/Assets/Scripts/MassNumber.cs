using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MassNumber : MonoBehaviour {

	public AtomicNumber Z;

	public int MassNo, NeutronNo;

	public Text massNumber;
	// Use this for initialization
	void Start () {
		 Z = GameObject.FindWithTag("Z").GetComponent<AtomicNumber>();

		 MassNo = 1;
		 NeutronNo = 0;		
	}
	
	// Update is called once per frame
	void Update () {
		MassNo = NeutronNo + Z.AtomicNo;

		if(Z.AtomicNo != 0){
			massNumber.text = ("") + MassNo;
		}
		
	}
}
