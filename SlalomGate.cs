Salomgates
This Class consists of a salomgate or the Direction gates which direct the user to turn and navigate/maneuver on basis of head-tracking-orientation. This property has two options Left and Right gate, code  also provides and generates gates at a random order so as to make the game interesting. 

using UnityEngine;
using System.Collections;

public class SlalomGate : MonoBehaviour {
	public bool flipToLeft;
	
	bool passed; // So it only activates once per game
	public bool last = false;
	
	// Use this for initialization
	void Start () {
	
	}
	
	public void SetLast(bool l){
		last = l;
	}
	
	// Update is called once per frame
	void Update () {
		if(!GameManager.current.gameInProgress){
			passed = false;
		}
		
		Vector3 playerPos = GameManager.current.player.transform.position;
		
		if(!passed && playerPos.z > transform.position.z ){
			bool success = (playerPos.x < gameObject.transform.position.x);
			if(flipToLeft) success = !success;
			GameManager.current.SlalomGate( success );
			
			passed = true;
			if(last){
				GameManager.current.EndGame();
			}
		}
	}
}
