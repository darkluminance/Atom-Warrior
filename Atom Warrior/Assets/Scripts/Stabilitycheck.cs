using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stabilitycheck : MonoBehaviour {

	public AtomicNumber Z; public GameOver KO;

	public Charge E;

	public MassNumber M;

	public bool stable, unstable, dead;

	public int AtomicNumber, NeutronNumber, ElectronNumber;

	public  Text stabilityState, protonStats, neutronStats, electronStats, showRatio, maxRatio;

	public GameObject player;



	// Use this for initialization
	void Start () {
		 Z = GameObject.FindWithTag("Z").GetComponent<AtomicNumber>();
		 M = GameObject.FindWithTag("M").GetComponent<MassNumber>();
		 E = GameObject.FindWithTag("E").GetComponent<Charge>();
		 KO = GameObject.FindWithTag("Finish").GetComponent<GameOver>();
		 player = GameObject.FindWithTag("Player");

		 stable = true; unstable = false;	dead = false;

		 stabilityState.text= "";
		
	}
	
	// Update is called once per frame
	void Update () {

		AtomicNumber = Z.AtomicNo;	NeutronNumber = M.NeutronNo;	ElectronNumber = E.electronNo;

			if(AtomicNumber > 0 && AtomicNumber<=20){
				Checkstability(1.25f);
			}else if (AtomicNumber>20 && AtomicNumber<=40){
				Checkstability(1.4f);
			}else if (AtomicNumber>40 && AtomicNumber<=50){
				Checkstability(1.5f);
			}else if (AtomicNumber>50 && AtomicNumber<=60){
				Checkstability(1.6f);
			}else if (AtomicNumber>60 && AtomicNumber<82){
				Checkstability(1.8f);
			}else if (AtomicNumber>82){
				Checkstability(2.0f);
			}
		
	}

	void Checkstability(float Ratio){

		float x = (float)NeutronNumber; float y = (float)AtomicNumber;

		float divisn = x/y;		float dedRatio = 2.05f;
		if(!dead){
			if( y == 1 && x == 0){
				stable = true;	unstable= false;	dead = false;
			}else if(divisn<1){
				stable = false;	unstable= false;	dead = true;}
			 else if( divisn>=1  && divisn<=Ratio){
				stable = true;	unstable= false;	dead = false;
			}else if (divisn>Ratio && divisn<=dedRatio){
				stable = false;	unstable= true;	dead = false;
			}else {
				stable = false;	unstable= false;	dead = true;
				KO.enabled = true;
				KO.gameOver = true;
			}
		}
		

		
		if(player.activeInHierarchy == false){
			stable = false; unstable = false;	dead = true;
		}

		if(dead == true){
			stabilityState.text = "";
			KO.enabled = true;
			KO.gameOver = true;
		}else if(stable == true){
			stabilityState.text= "Stable";
			stabilityState.color = Color.green;
		}else if (unstable == true){
			stabilityState.text= "Unstable";
			stabilityState.color = Color.red;
		}

		DisplayStats(Ratio);
	}

	void DisplayStats(float Ratio){
		protonStats.text = "Proton: " + AtomicNumber;
		neutronStats.text = "Neutron: " + NeutronNumber;
		electronStats.text = "Electron: " + ElectronNumber;
	}
}
