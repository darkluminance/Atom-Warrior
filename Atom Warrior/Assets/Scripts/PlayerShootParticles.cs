using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootParticles : MonoBehaviour {

	public GameObject particleElectron, particleProton, particleNeutron,
	arrow, referencePoint, spawnPoint;

	public float shotSpeed;

	public Charge E;

	public AtomicNumber Z; public MassNumber M;

	public GameOver KO;

	// Use this for initialization
	void Start () {
		
		 E = GameObject.FindWithTag("E").GetComponent<Charge>();		 
		 Z = GameObject.FindWithTag("Z").GetComponent<AtomicNumber>();
		 M = GameObject.FindWithTag("M").GetComponent<MassNumber>();
	}
	
	// Update is called once per frame
	void Update () {
			Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector3 touchPos = new Vector3(mousePos.x, mousePos.y, 0);
			Vector3 refVectorA = (touchPos - transform.position).normalized;
			Vector3 refVectorB = (referencePoint.transform.position - transform.position).normalized;


			float alpha = Vector3.Angle(refVectorB, refVectorA);

			float sign = 1; 

			if(refVectorA.y < refVectorB.y){sign = -1;}

			Quaternion angle = Quaternion.Euler(0,0, alpha * sign );

			arrow.transform.rotation = angle;
			

		if(Input.GetMouseButtonDown(0)){
			//Instantiate bullet and set the velocity of the bullet
			GameObject bullet = Instantiate(particleElectron, transform.position, Quaternion.identity) as GameObject;
			

			Vector3 velocity = (Input.mousePosition - transform.position).normalized;

			bullet.GetComponent<MoveTowardsAtom>().enabled = false;	

			E.electronNo--;
			
			bullet.GetComponent<Rigidbody>().velocity=(touchPos - 
			new Vector3 (transform.position.x, transform.position.y, 0)).normalized*shotSpeed;

			StartCoroutine(Destroyafteramoment(bullet));				
			
		}

		if(Input.GetMouseButtonDown(1)){
			//Instantiate bullet and set the velocity of the bullet
			GameObject bullet = Instantiate(particleProton, transform.position, Quaternion.identity) as GameObject;
			

			Vector3 velocity = (Input.mousePosition - transform.position).normalized;

			bullet.GetComponent<MoveTowardsAtom>().enabled = false;	

			Z.AtomicNo--;
			
			bullet.GetComponent<Rigidbody>().velocity=(touchPos - 
			new Vector3 (transform.position.x, transform.position.y, 0)).normalized*shotSpeed;

			if (Z.AtomicNo == 0){
			KO.GetComponent<GameOver>().enabled = true;
			KO.GetComponent<GameOver>().gameOver = true;
		}

			StartCoroutine(Destroyafteramoment(bullet));
							
			
		}

		if(Input.GetMouseButtonDown(2) || Input.GetKeyDown(KeyCode.Space)){
			//Instantiate bullet and set the velocity of the bullet
			GameObject bullet = Instantiate(particleNeutron, transform.position, Quaternion.identity) as GameObject;
			

			Vector3 velocity = (Input.mousePosition - transform.position).normalized;

			bullet.GetComponent<MoveTowardsAtom>().enabled = false;	

			M.NeutronNo--;
			
			bullet.GetComponent<Rigidbody>().velocity=(touchPos - 
			new Vector3 (transform.position.x, transform.position.y, 0)).normalized*shotSpeed;

			StartCoroutine(Destroyafteramoment(bullet));				
			
		}
		
	}

	IEnumerator Destroyafteramoment(GameObject bullet){
		yield return new WaitForSeconds(2);
		Destroy(bullet);
	}
}
