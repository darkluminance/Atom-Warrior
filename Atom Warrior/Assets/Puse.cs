using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puse : MonoBehaviour {

	public GameObject pauseMenu;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.P)){
			if(Time.timeScale == 1){
				Time.timeScale =0; pauseMenu.SetActive(true);
			}else if (Time.timeScale == 0){
				Time.timeScale =1; pauseMenu.SetActive(false);
			}
		}

		if(Input.GetKeyDown(KeyCode.Q)){
			if (Time.timeScale == 0){
				Application.Quit();
			}
		}
	}
}
