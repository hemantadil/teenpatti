using UnityEngine;
using System.Collections;



public class menu : MonoBehaviour {



	public string IP = "127.0.0.1";
	public int Port = 25001;


	void OnGUI()
	{
		var useNat = !Network.HavePublicAddress ();
		if (Network.peerType == NetworkPeerType.Disconnected) {

						if (GUI.Button (new  Rect (100, 100, 100, 25), "Join the Game")) {

								Network.Connect (IP, Port);

						}
						if (GUI.Button (new  Rect (100, 50, 100, 25), "Start Server")) {
				
								Network.InitializeServer (10, Port, useNat);
				
						}

				}
			else if (Network.peerType == NetworkPeerType.Client) {


			//GUI.Label(new  Rect (150, 100, 100, 25), "Client it is");
			string eds = "name";
			string str = GUI.TextField (new Rect (150, 100, 20, 100), eds);
		if (GUI.Button (new  Rect (150, 30, 100, 25), "Logout")) {
				
						Network.Disconnect(250);
				
					}
			
;

			
		}
		else if (Network.peerType == NetworkPeerType.Server) {
			
			GUI.Label(new  Rect (150, 100, 100, 25), "Server it is");
			GUI.Label(new  Rect (150, 80, 100, 25), "Connections : "+ Network.connections.Length );
			if (GUI.Button (new  Rect (150, 30, 100, 25), "Logout")) {
				
				Network.Disconnect(250);
				
			}
			
		}



	}



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

public class Player: MonoBehaviour{


	private int balance;
	private string name;
	private bool hasPacked;
	private int mybet;
	//private Card mycards[3];

	public Player(string name)
	{
		balance = 1000;
		hasPacked = false;
		this.name =  name;
		mybet = 0;
 
	}

	void placeBet(int amt)
	{
		//if(amt > balance)
			//print error message in client
		//else
				balance -= amt;



	}


}




