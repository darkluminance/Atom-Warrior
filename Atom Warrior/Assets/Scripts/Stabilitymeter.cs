using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Stabilitymeter : MonoBehaviour {


	public Text stabilityText;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(GetComponent<Stability>().stable == true && 
		GetComponent<Stability>().closetounstable == false &&
		GetComponent<Stability>().unstable == false){
			stabilityText.text = ("Stable");
			stabilityText.color = Color.green;
		}else if(GetComponent<Stability>().stable == false && 
		GetComponent<Stability>().closetounstable == true &&
		GetComponent<Stability>().unstable == false){
			stabilityText.text = ("Close to Unstable");
			stabilityText.color = Color.magenta;
		}else if (GetComponent<Stability>().stable == false && 
		GetComponent<Stability>().closetounstable == false &&
		GetComponent<Stability>().unstable == true){
			stabilityText.text = ("Unstable");
			stabilityText.color = Color.red;
		}
		
	}
}
