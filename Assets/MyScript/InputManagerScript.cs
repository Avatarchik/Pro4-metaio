using UnityEngine;
using System.Collections;
using Leap;

public class InputManagerScript : MonoBehaviour {

	private GameObject gameManager;

	private bool conductFlag = false;
	// Use this for initialization
	void Start () {
		gameManager = GameObject.Find ("GameManager");
	}
	
	void Update ()
	{
		ReportConductFlag ();
	}

	void ReportConductFlag(){
		gameManager.SendMessage ("ManageConduct",conductFlag);
	}

	void ChangeConductFlag(bool flag_condition){
		conductFlag = flag_condition;
	}

	void DebugKey(){
		//if( 
	}
}
