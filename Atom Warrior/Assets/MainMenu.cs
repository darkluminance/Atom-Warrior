using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	public GameObject helpscreen;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.P)){
			if(helpscreen.activeInHierarchy == false){
				SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
			}
		}

		if(Input.GetKeyDown(KeyCode.H)){
			//Help screen
			helpscreen.SetActive(true);
		}

		if(Input.GetKeyDown(KeyCode.C)){
			if(helpscreen.activeInHierarchy == false){
				Application.Quit();
			}
		
		}
		
	}
}
