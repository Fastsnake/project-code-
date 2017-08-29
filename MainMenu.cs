using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public GameObject rules;
	public GameObject mainmenu;

	public GameObject rules1;
	public GameObject rules2;
	public GameObject rules3;
	public GameObject chose;

	public void LoadScene(string name){
		Application.LoadLevel (name);
	}

	public void QuitGame(){
		Application.Quit();
	}

	public void ReadRules(){
		rules.SetActive (true);
		mainmenu.SetActive (false);
	}

	public void Rule1Next(){
		rules1.SetActive (false);
		rules2.SetActive (true);
	}

	public void Rule2Next(){
		rules2.SetActive (false);
		rules3.SetActive (true);
	}

	public void Rule3Next(){
		rules3.SetActive (false);
		mainmenu.SetActive (true);
	}

	public void ChoseLv(){
		mainmenu.SetActive (false);
		chose.SetActive (true);
	}

	public void ChoseLvBack(){
		mainmenu.SetActive (true);
		chose.SetActive (false);
	}
}