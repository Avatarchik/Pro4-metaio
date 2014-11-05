using UnityEngine;
using System.Collections;

public class FingerPositionScript : MonoBehaviour {

    //前回のオブジェクト位置格納用変数
    private float beforePosition;
	private GameObject inputManager;

	// Use this for initialization
	void Start () {
		beforePosition = this.transform.position.y;
		inputManager = GameObject.Find ("InputManager");
		//AudioSourceコンポーネントを取得し、変数に格納	}
	}	
	// Update is called once per frame
	void Update () {
        if (System.Math.Abs(beforePosition - this.transform.position.y) > 0.6 ){
			inputManager.SendMessage("ChangeConductFlag",true);
        }else if ( System.Math.Abs(beforePosition - this.transform.position.y) == 0 ){
			inputManager.SendMessage("ChangeConductFlag",false);
        }
        beforePosition = this.transform.position.y;
    }
}