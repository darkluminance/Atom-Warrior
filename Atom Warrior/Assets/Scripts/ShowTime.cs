using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTime : MonoBehaviour {

	public Text time;

	public GameOver KO;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(KO.GetComponent<GameOver>().gameOver == false){			
			time.text = ("" +  Time.time);
		}

		Debug.ClearDeveloperConsole();
	}
}
