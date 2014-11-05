using UnityEngine;
using System.Collections;

public class ARModelScript : MonoBehaviour {

	private Animator m_Animator;
	// Use this for initialization
	void Start () {
		m_Animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SetAnimation(bool ringing){
		Debug.Log ("path");
		m_Animator.SetBool("isRinging",ringing);
	}
}
