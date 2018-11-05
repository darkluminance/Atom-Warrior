using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	public GameObject atom, spawner, explosionPrefab, sound, explode;

	public Text Z, element, gameOverYOOOO, M, charge, restartText;

	public bool gameOver = false;

	// Use this for initialization
	void Start () {
		StartCoroutine(GameOverFunc());
	}
	
	// Update is called once per frame
	void Update () {
		if(gameOver){
			if(Input.GetKeyDown(KeyCode.R)){
				restartgame();
			}else if (Input.GetKeyDown(KeyCode.C)){
				closegame();
			}
		}
				
	}

	public IEnumerator GameOverFunc(){
			Instantiate(explosionPrefab, atom.transform.position, Quaternion.identity);
			sound.SetActive(false);		Instantiate(explode, Vector2.zero, Quaternion.identity);
			
			element.text = "";
			Z.text =""; M.text = ""; charge.text = "";
			
			atom.SetActive(false); Destroy(spawner);

			yield return new WaitForSeconds(3);

			gameOverYOOOO.text = "GAME OVER";

			restartText.text = "Press R to restart, C to Close";

			

	}

	void restartgame(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	void closegame(){
		Application.Quit();
	}
}
