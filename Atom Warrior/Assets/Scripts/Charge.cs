using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Charge : MonoBehaviour {

	public int electronNo, charge;

	public AtomicNumber Z;

	public Text chargeText;

	// Use this for initialization
	void Start () {
		Z = GameObject.FindWithTag("Z").GetComponent<AtomicNumber>();
		electronNo = 1;		
	}
	
	// Update is called once per frame
	void Update () {
		charge = - electronNo + Z.AtomicNo;

		if(charge == 0){
			chargeText.text = "";
		}else if (charge == 1){
			chargeText.text = "+";
		}else if (charge == -1){
			chargeText.text = "-";
		}else if (charge > 0){
			chargeText.text = "" + charge + "+";
		}else if (charge < 0){
			chargeText.text = "" + -charge + "-" ;
		}

		

	}
}
