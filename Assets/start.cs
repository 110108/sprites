using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour {
	public Scene scene;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseOver()
	{
		//If your mouse hovers over the GameObject with the script attached, do this
		if (Input.GetMouseButtonDown(0)){
			//SceneManager.SetActiveScene ("ssb");
			SceneManager.LoadScene("ssb", LoadSceneMode.Single);
		}
	}
}
