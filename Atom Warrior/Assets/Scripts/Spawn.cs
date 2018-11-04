using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public GameObject[] particles;

	public Transform player;

	// Use this for initialization
	void Start () {
		StartCoroutine(Spawnparticles());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public IEnumerator Spawnparticles(){

		while(true){
		Vector2 pos =new Vector2 (player.position.x, player.position.y);
		pos += Random.insideUnitCircle * 20f;

		int i = Random.Range(0, particles.Length);

		Instantiate(particles[i], pos, Quaternion.identity);

		yield return new WaitForSeconds(2.5f);
		}
	}
}
