using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repel : MonoBehaviour {

	public float repelForce;

	public GameObject neutron;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator OnTriggerEnter(Collider other)
	{
		if(other.tag == "Proton" && gameObject.tag == "Proton"  ||
			other.tag == "Neutron" && gameObject.tag == "Neutron"){
			//Repel
			Vector3 force = (transform.position - other.transform.position).normalized;

			GetComponent<Rigidbody>().AddForce(-force * repelForce);
		}

		if (other.tag == "Electron" && gameObject.tag == "Electron"){
			Vector3 force = (transform.position - other.transform.position).normalized;

			GetComponent<Rigidbody>().AddForce(-force * repelForce);
			yield return new WaitForSeconds(3);
			Destroy(other.gameObject);
			Destroy(gameObject);
		}

		if(other.tag == "Proton" && gameObject.tag == "Electron"){
			int i = Random.Range (1,3);

			if(i == 1){
				//Disintegrate proton and beta decay
				Destroy(other.gameObject);
			}else if(i == 2){
				//Bounce of
				Vector3 force = (transform.position - other.transform.position).normalized;

				GetComponent<Rigidbody>().AddForce(-force * repelForce * 10);

				yield return new WaitForSeconds(3);
				Destroy(other.gameObject);
				Destroy(gameObject);

			}else if (i == 3){
				//form neutron and beta decay
				Instantiate(neutron, transform.position, Quaternion.identity);
				Destroy(other.gameObject);
				Destroy(gameObject);
			}
		}

		if(other.tag == "Proton" && gameObject.tag == "Neutron"){
			//beta decay and destroy
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
	}
}
