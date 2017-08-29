using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	public GameObject pausemenu;
	bool gamepaused;

	// Use this for initialization
	void Start () {
		gamepaused = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (gamepaused == false) {
			if(Input.GetKeyDown(KeyCode.Escape)){
				pausemenu.SetActive(true);
				Time.timeScale=0;
				gamepaused=true;
			}
		}
		else
		if (Input.GetKeyDown (KeyCode.Escape)) {
			pausemenu.SetActive (false);
			Time.timeScale = 1;
			gamepaused = false;
		}
		//if(Input.GetKeyDown (KeyCode.Escape)){
		//	pausemenu.SetActive (true);
		//	Time.timeScale=0;
		//}
	}

	public void ResumeGame(){
		pausemenu.SetActive (false);
		Time.timeScale = 1;
		gamepaused=false;
	}
}
