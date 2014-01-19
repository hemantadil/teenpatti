using UnityEngine;
using System.Collections;


public class Player: MonoBehaviour{

	private int balance;
	private string name;
	private bool hasPacked;
	private int mybet;
	//private Card mycards[3];
	
	public Player()
	{
		balance = 1000;
		hasPacked = false;
		mybet = 0;
		
	}

	public void setName(string name)
	{
		this.name = name;

	}


	void placeBet(int amt)
	{
		//if(amt > balance)
		//print error message in client
		//else
		balance -= amt;
		
		
		
	}

	public bool isPacked(){
				return hasPacked;
		}
	
	
}


public class Game :MonoBehaviour {
	private int turn=-1;
	private int totalBet = 0;
	private int noPlayer = 4;
	private int activePlayer=4;
	private Player[] peers = new Player[4];

	public int getTurn(){
		return turn;
	}

	public void updateTurn(){
		turn++;
		turn= turn % noPlayer;
		while(peers[turn].isPacked() == true){
			turn++;
			turn = turn % noPlayer;                                                                                                                                   
		}
	}

	public void updateTotalBet(int bet){
		totalBet+=bet;

	}

	public int getTotalBet(){
		return totalBet;
	}

	public void distributeCard(){
		//shuffle;
		// call the players's setter to set the cards they have got
	}

    public int getActivePlayer(){
				return activePlayer;
		}

}

public class menu : MonoBehaviour {

	int turn = -1;
	int totalbet=0;
	public string IP = "127.0.0.1";
	public int Port = 25001;
	string eds = "name";
	public Player p = new Player();
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


			GUI.Label(new  Rect (150, 80, 100, 25), "Set Nick");

			eds = GUI.TextField (new Rect (150, 100, 150, 20), eds,100);
		
			networkView.RPC("getName", RPCMode.Server, eds);

			if (GUI.Button (new  Rect (150, 130, 100, 25), "Logout")) {
				
						Network.Disconnect(250);
				
					}

			if (GUI.Button (new  Rect (280, 130, 100, 25), "Play")) {
				
				Network.Disconnect(250);
				
			}
			
;

			
		}
		else if (Network.peerType == NetworkPeerType.Server) {
			
			GUI.Label(new  Rect (150, 100, 100, 25), "Server it is");
			GUI.Label(new  Rect (150, 80, 100, 25), "Connections : "+ Network.connections.Length );


			for(int i=0;i<Network.connections.Length;i++){
				Debug.Log (Network.connections[i].ipAddress+" "+Network.connections[i].guid);


			}

			if (GUI.Button (new  Rect (150, 30, 100, 25), "Logout")) {
				
				Network.Disconnect(250);
				
			}
			
		}
	

	}


	[RPC]
	public void getName(string name)
	{
		p.setName (name);
		
		
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public int getTurn(){

		return turn;
	}

	public void setTurn()
	{
		if (Network.peerType == NetworkPeerType.Server) {

			turn = turn +1;



				}


	}



}