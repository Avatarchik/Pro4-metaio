using UnityEngine;
using System.Collections;

public class GameManagerScript : MonoBehaviour {

	enum    RingingState{
		WAIT = 0,
		RINGING
	}

	private GameObject   soundManager;

	private bool         m_isRinging;
	private RingingState ringingState;
	private GameObject[] arModelObjects;

	private bool         debug_KeyState_Space = false;

	private float        executionTime;
	public  float        maxConductTime = 2.0f;

	// Use this for initialization
	void Start () {

		m_isRinging  = false;
		ringingState = RingingState.RINGING;
		soundManager = GameObject.Find ("SoundManager");
		arModelObjects = GameObject.FindGameObjectsWithTag("ARModel");

	}
	
	// Update is called once per frame
	void Update () {
		// Action from input.
		DecreaseConduct ();
		ChangeAnimation ();	
		ChangeBGM ();
	}

	void DecreaseConduct(){
		if (executionTime - Time.time <= -maxConductTime) {
			m_isRinging = false;
		} else {
			m_isRinging = true;
		}
	}


	void ManageConduct(bool conductFlag){
		if (conductFlag) {
			executionTime = Time.time;
 		}
	}

	void ChangeAnimation(){
		foreach (GameObject arModel in arModelObjects) {
			arModel.SendMessage ("SetAnimation", m_isRinging);
		}
	}

	void ChangeBGM(){
		soundManager.SendMessage("ChangeAudio",m_isRinging); 
	}
	
}
