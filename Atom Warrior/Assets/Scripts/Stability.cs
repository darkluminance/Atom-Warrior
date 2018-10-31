using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stability : MonoBehaviour {

	public AtomicNumber Z; public GameOver KO;

	public Charge E;

	public MassNumber M;

	public bool stable, unstable, closetounstable;


	// Use this for initialization
	void Start () {
		 Z = GameObject.FindWithTag("Z").GetComponent<AtomicNumber>();
		 M = GameObject.FindWithTag("M").GetComponent<MassNumber>();
		 E = GameObject.FindWithTag("E").GetComponent<Charge>();
		 KO = GameObject.FindWithTag("Finish").GetComponent<GameOver>();

		 stable = true; unstable = false; closetounstable = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Z.AtomicNo <= 20){
			if((M.NeutronNo / Z.AtomicNo) >= 1.25f){
				if((M.NeutronNo / Z.AtomicNo) >= 1.25f  && (M.NeutronNo / Z.AtomicNo) <= 1.3f){
					unstable = true; stable = false; closetounstable = false;
				}else{
					KO.GetComponent<GameOver>().enabled = true;
					KO.GetComponent<GameOver>().gameOver = true;
				}			
				
			}else if ((M.NeutronNo / Z.AtomicNo) <= 1.25f && (M.NeutronNo / Z.AtomicNo) >= 1.00f){
				if((M.NeutronNo / Z.AtomicNo) < 1.25f){
					unstable = false; stable = false; closetounstable = true;
				}else if ((M.NeutronNo / Z.AtomicNo) == 1.00f){
					stable = true; unstable = false; closetounstable = false;
				}
			}
		}else if (Z.AtomicNo <= 40){
			if((M.NeutronNo / Z.AtomicNo) >= 1.4f){
				if((M.NeutronNo / Z.AtomicNo) >= 1.4f  && (M.NeutronNo / Z.AtomicNo) <= 1.45f){
					unstable = true; stable = false; closetounstable = false;
				}else{
					KO.GetComponent<GameOver>().enabled = true;
					KO.GetComponent<GameOver>().gameOver = true;
				}			
				
			}else if ((M.NeutronNo / Z.AtomicNo) <= 1.4f && (M.NeutronNo / Z.AtomicNo) >= 1.00f){
				if((M.NeutronNo / Z.AtomicNo) < 1.4f){
					unstable = false; stable = false; closetounstable = true;
				}else if ((M.NeutronNo / Z.AtomicNo) == 1.00f){
					stable = true; unstable = false; closetounstable = false;
				}
			}
		}


		
		
	}
}
