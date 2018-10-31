using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MassNumber : MonoBehaviour {

	public AtomicNumber Z;

	public GameOver KO;

	public int MassNo, NeutronNo;

	public Text massNumber;
	// Use this for initialization
	void Start () {
		 Z = GameObject.FindWithTag("Z").GetComponent<AtomicNumber>();
		 KO = GameObject.FindWithTag("Finish").GetComponent<GameOver>();
		 MassNo = 1;
		 NeutronNo = 0;		
	}
	
	// Update is called once per frame
	void Update () {
		MassNo = NeutronNo + Z.AtomicNo;

		if(NeutronNo<0){
			KO.GetComponent<GameOver>().enabled = true;
			KO.GetComponent<GameOver>().gameOver = true;
		}

		if(Z.AtomicNo != 0){
			massNumber.text = ("") + MassNo;
		}if(KO.GetComponent<GameOver>().gameOver == true) {
			massNumber.text = ("");
		}
		
	}
}
