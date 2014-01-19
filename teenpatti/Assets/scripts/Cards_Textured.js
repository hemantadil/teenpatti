#pragma strict

function Start () {

}
public var distance : float = 500.0;
function Update () {
        var ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		var hit : RaycastHit;
		Physics.Raycast (ray, hit, 100);
		if (Input.GetButtonDown("Fire1")) {
		//hit.collider.gameObject.renderer.material.color= Color.black;
	//	renderer.material.SetTextureScale("_MainTex",new Vector3(-1,-1,-1));	
		hit.collider.gameObject.renderer.material.mainTexture = Resources.Load("rsz_clubs_3") as Texture;	
	//	hit.collider.gameObject.renderer.material.color = Color.red;	
		Debug.Log(hit.collider.gameObject.name+" lol");
   		//if(hit.collider.gameObject.name == "1")
   		//	hit.collider.gameObject.renderer.material.mainTexture = Resources.Load("cross") as Texture;;

	}
}