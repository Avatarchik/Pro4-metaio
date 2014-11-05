using UnityEngine;
using System.Collections;

public class SoundManagerScript : MonoBehaviour {

	private GameObject[] arCharacters;

	// Use this for initialization
	void Start () {
		arCharacters = GameObject.FindGameObjectsWithTag("ARModel");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void ChangeAudio(bool isRinging){
		foreach (GameObject arModel in arCharacters) {
			arModel.SendMessage("SetAudio",isRinging); 
		}

	}
	
}
