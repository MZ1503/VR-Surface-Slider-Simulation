Wipeout 
This code provides condition of wipe out in case of collision, the time or duration for which it stays in air, this further provides feel for jump .

using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class Wipeout : MonoBehaviour {
	public float duration = 2.0F;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other){
		if(other.CompareTag("Player")){
			other.gameObject.GetComponent<RigidbodyFirstPersonController>().Wipeout(duration);
		}
	
	}
}
