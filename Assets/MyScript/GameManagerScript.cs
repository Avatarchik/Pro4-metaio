using UnityEngine;
using System.Collections;

public class GameManagerScript : MonoBehaviour {

	enum    RingingState{
		WAIT = 0,
		RINGING
	}

	private bool         m_isRinging;
	private RingingState ringingState;
	private GameObject[] arModelObjects;

	private bool         debug_KeyState_Space = false;

	// Use this for initialization
	void Start () {

		m_isRinging  = true;
		ringingState = RingingState.RINGING;

		arModelObjects = GameObject.FindGameObjectsWithTag("ARModel");
		foreach (GameObject arModel in arModelObjects){
			Debug.Log (arModel.name);
		}

	}
	
	// Update is called once per frame
	void Update () {
		// Action from input.
		if ( Input.GetKey(KeyCode.Space) )
			ChangeAnimation ();	
	}

	void ChangeAnimation(){
		foreach (GameObject arModel in arModelObjects) {
			arModel.SendMessage ("SetAnimation", !m_isRinging);
			Debug.Log (arModel.name);
		}
		m_isRinging = !m_isRinging;
	}
	
}
