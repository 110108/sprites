using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour {
	private Vector3 resetPos;
	public GameObject player;
	public GameObject other;
	public int depth;

	// Use this for initialization
	void Start () {
		resetPos = new Vector3 (transform.position.x, transform.position.y+2, transform.position.z);
		other.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		if (player.transform.position.y<depth){
			player.transform.position = resetPos;
		}
		if (player.transform.position.y>=16.00f&&player.transform.position.x<=7){
			other.SetActive (true);
		}
	}
}
