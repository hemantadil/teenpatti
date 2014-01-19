using UnityEngine;
using System.Collections;

public class Cards : MonoBehaviour {
	public Texture2D img1 = null;
//	public WWW t_load = null;
//	string targetFile = "file://C:/Users/user/Documents/GitHub/teenpatti/teenpatti/Assets/Resources/cross";
	void OnGUI(){
	//	t_load = new WWW(targetFile);
	//	img1 = new Texture2D(128,128);
	//	t_load.LoadImageIntoTexture(img1);
	//	img1 = new Texture2D (64, 128, TextureFormat.DXT1, false);
		img1 = Resources.Load("cross") as Texture2D;
	//	img1.Resize(64,128,TextureFormat.DXT1,false);
		GUI.Box(new Rect(260, 80, 45, 70), img1);
		Debug.Log ("Hello");
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {



	}


}
