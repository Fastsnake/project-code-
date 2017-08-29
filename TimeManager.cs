using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour {

	public float startingTime;

	private Text theText;

	public GameObject gameOverScreen;


	
	void Start () 
	{
		theText = GetComponent<Text> ();

	}

	void Update () 
	{
		startingTime -= Time.deltaTime;

		if (startingTime <= 0) 
		{
			gameOverScreen.gameObject.SetActive(true);
		}

		theText.text = "" +Mathf.Round (startingTime);
	}
}
 