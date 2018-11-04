using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtomicNumber : MonoBehaviour {

	public GameOver KO;

	public int AtomicNo;

	public Text Z, element;

	List<string> Element_Name = new List <string>();

	Color[] bgColor = new Color [118];


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
		Element_Name.Add("Li");			bgColor[3] = new Color (.5f,.3f,.3f);
		Element_Name.Add("Be");			bgColor[4] = new Color (.5f,.5f,.5f);
		Element_Name.Add("B");			bgColor[5] = new Color (.3f,.5f,.3f);
		Element_Name.Add("C");			bgColor[6] = new Color (.12f,.12f,.12f);
		Element_Name.Add("N");			bgColor[7] = new Color (0.4811f,0.4811f, 0.4811f);
		Element_Name.Add("O");			bgColor[8] = new Color (0.25f,0.35f, 0.4f);
		Element_Name.Add("F");			bgColor[9] = new Color (0.35f,0.35f, 0.2f);
		Element_Name.Add("Ne");			bgColor[10] = new Color (.6f,.45f,.2f);
		Element_Name.Add("Na");			bgColor[11] = new Color (.5f,.5f,.2f);
		Element_Name.Add("Mg");			bgColor[12] = new Color (.6f,.45f,.2f);
		Element_Name.Add("Al");			bgColor[13] = new Color (0.4f,0.5f, 0.5f);		
		Element_Name.Add("Si");			bgColor[14] = new Color (0.4f,0.5f, 0.5f);
		Element_Name.Add("P");			bgColor[15] = new Color (0.4f,0.5f, 0.5f);
		Element_Name.Add("S");			bgColor[16] = new Color (0.2f,0.35f, 0.5f);
		Element_Name.Add("Cl");			bgColor[17] = new Color (0.4f,0.5f, 0.2f);
		Element_Name.Add("Ar");			bgColor[18] = new Color (0.15f,0.5f, 0.5f);
		Element_Name.Add("K");			bgColor[19] = new Color (0.4f,0.3f, 0.55f);
		Element_Name.Add("Ca");			bgColor[20] = new Color (0.5f,0.35f, 0.3f);
		Element_Name.Add("Sc");			bgColor[21] = new Color (0.55f,0.35f, 0.2f);
		Element_Name.Add("Ti");			bgColor[22] = new Color (0.4811f,0.4811f, 0.4811f);
		Element_Name.Add("V");			bgColor[23] = new Color (0.4f,0.5f, 0.15f);
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if(AtomicNo > 0){
			element.text ="" + Element_Name[AtomicNo];
			Z.text = "" + AtomicNo;
		}
		if(KO.GetComponent<GameOver>().gameOver == true){
			element.text ="";
			Z.text = "" ;
		}
		

		RenderSettings.skybox.SetColor("_Tint", bgColor[AtomicNo]);

		

	}
}
