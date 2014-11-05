using UnityEngine;
using System.Collections;

public class ARModelScript : MonoBehaviour {

	private Animator m_Animator;
	private AudioSource m_RinginBGM;
	// Use this for initialization
	void Start () {
		m_Animator  = GetComponent<Animator> ();
		m_RinginBGM = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SetAnimation(bool ringing){
		m_Animator.SetBool("isRinging",ringing);
	}

	void SetAudio(bool flag){

		if (m_RinginBGM.isPlaying != flag) {
			switch (flag) {
			case true:
					m_RinginBGM.Play ();
 					break;
			case false:
					m_RinginBGM.Stop ();
					break;
			}
		}

	}
}
