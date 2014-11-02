using UnityEngine;
using System.Collections;

public class WebCamBehaviourScript : MonoBehaviour
{
	public int Width = 1920;
	public int Height = 1080;
	public int FPS = 30;
	
	// Use this for initialization
	void Start()
	{
		var devices = WebCamTexture.devices;
		if ( devices.Length == 0 ) {
			Debug.LogError( "Webカメラが検出できませんでした。" );
			return;
		}

		print (devices[1].name);
		
		// WebCamテクスチャを作成する
		var webcamTexture = new WebCamTexture( devices[1].name, Width, Height, FPS );
		renderer.material.mainTexture = webcamTexture;
		webcamTexture.Play();
	}
	
	// Update is called once per frame
	void Update()
	{
		
	}
}
