using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {
	public GameObject helpscreen, loading;

	public Text bestelem;

	List<string> Element = new List <string>();

	// Use this for initialization
	void Start () {
		Element.Add("");
		Element.Add("Hydrogen");
		Element.Add("Helium");
		Element.Add("Lithium");
		Element.Add("Beryllium");
		Element.Add("Boron");
		Element.Add("Carbon");
		Element.Add("Nitrogen");
		Element.Add("Oxygen");
		Element.Add("Fluorine");
		Element.Add("Neon");
		Element.Add("Sodium");
		Element.Add("Magnesium");
		Element.Add("Aluminium");
		Element.Add("Silicon");
		Element.Add("Phosphorus");
		Element.Add("Sulphur");
		Element.Add("Chlorine");
		Element.Add("Argon");
		Element.Add("Potassium");
		Element.Add("Calcium");
		Element.Add("Scandium");
		Element.Add("Titanium");
		Element.Add("Vanadium");
		
	}
	
	// Update is called once per frame
	void Update () {
		if(helpscreen.activeInHierarchy == false){
				bestelem.text = "Best element: " + Element[PlayerPrefs.GetInt("BestElement")];				
			}
		if(Input.GetKeyDown(KeyCode.P)){
			if(helpscreen.activeInHierarchy == false){
				loading.SetActive(true);
				SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
			}
		}

		if(Input.GetKeyDown(KeyCode.H)){
			//Help screen
			helpscreen.SetActive(true);
			bestelem.text = "";
		}

		if(Input.GetKeyDown(KeyCode.Q)){
			if(helpscreen.activeInHierarchy == false){
				Application.Quit();
			}
		
		}
		
	}
}
