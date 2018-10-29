using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtomicNumber : MonoBehaviour {

	public int AtomicNo;

	public GameObject atom, spawner;

	public Text Z, element, gameOverYOOOO, M, charge;

	List<string> Element_Name = new List <string>();

	Color[] bgColor = new Color [30];


	public Camera bg;
	
	void Awake()
	{
		

	}

	// Use this for initialization
	void Start () {
		AtomicNo = 1;

		Element_Name.Add("");			bgColor[0] = Color.black;
		Element_Name.Add("H");			bgColor[1] = new Color (0.4811f,0.4811f, 0.4811f);
		Element_Name.Add("He");			bgColor[2] = new Color(0.1682093f, 0.3660365f, 0.5660378f);
		Element_Name.Add("Li");			bgColor[3] = new Color (.45f,.45f,.45f);
		Element_Name.Add("Be");			bgColor[4] = new Color (.5f,.5f,.5f);
		Element_Name.Add("B");			bgColor[5] = new Color (.2f,.2f,.2f);
		Element_Name.Add("C");			bgColor[6] = new Color (.12f,.12f,.12f);
		Element_Name.Add("N");			bgColor[7] = new Color (0.4811f,0.4811f, 0.4811f);
		Element_Name.Add("O");			bgColor[8] = new Color (0.25f,0.35f, 0.4f);
		Element_Name.Add("F");			bgColor[9] = new Color (0.35f,0.35f, 0.2f);
		Element_Name.Add("Ne");
		Element_Name.Add("Na");
		Element_Name.Add("Mg");
		Element_Name.Add("Al");
		Element_Name.Add("Si");
		Element_Name.Add("P");
		Element_Name.Add("S");
		Element_Name.Add("Cl");
		Element_Name.Add("Ar");
		Element_Name.Add("K");
		Element_Name.Add("Ca");
		Element_Name.Add("Sc");
		Element_Name.Add("Ti");
		Element_Name.Add("V");
		
	}
	
	// Update is called once per frame
	void Update () {
		element.text ="" + Element_Name[AtomicNo];
		Z.text = "" + AtomicNo;

		RenderSettings.skybox.SetColor("_Tint", bgColor[AtomicNo]);

		if (AtomicNo == 0){
			gameOverYOOOO.text = "GAME OVER";
			element.text = "";
			Z.text =""; M.text = ""; charge.text = "";
			Destroy(atom); Destroy(spawner);
			
			Time.timeScale = 0;
		}

	}
}
