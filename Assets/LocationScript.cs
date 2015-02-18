using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LocationScript : MonoBehaviour {
	


	bool foundBasket = false;
	bool foundSeesaw = false;
	bool foundApple = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		string textBuffer = "Head north?";
		if ( foundBasket == true ) {
			textBuffer = "Oh noes! An apple is missing! go and find it somewhere to the west!";
		}
		if ( foundBasket == true && foundSeesaw == true ) {
			textBuffer = "They say if you find a seesaw, you're probably going in the right direction. Keep it up!";
		}


		Vector3 ballPit = new Vector3( 925f, 26f, 1327 );
		Vector3 seeSaw = new Vector3( 675.1f, 79.1f, 1320.1f );
		Vector3 apple = new Vector3( 399.1f, 104.3f, 1195.7f );

		float dist1 = Vector3.Distance ( GameObject.Find ("ufocatcherproto2").transform.position, ( GameObject.Find("ballpitmodel").transform.position));
		float dist2 = Vector3.Distance ( GameObject.Find ("ufocatcherproto2").transform.position, ( GameObject.Find("seesawmodel").transform.position));
		float dist3 = Vector3.Distance ( GameObject.Find ("ufocatcherproto2").transform.position, ( GameObject.Find("applemodel").transform.position));
		Debug.Log (dist1);
		//textBuffer += dist1;
		Debug.Log (transform.position);

		if ( dist1 < 100 )  {
			foundBasket = true;
		}

		if ( dist2 < 50 ) {
			textBuffer = "They say if you find a seesaw, you're probably going in the right direction. Keep it up!";
			foundSeesaw = true;
		}

		if ( dist3 < 50 ) {
			textBuffer = "found the apple! if you found the basket and the seesaw, hit spacebar to win!";
			foundApple = true;
			if ( foundBasket == true && foundSeesaw == true && foundApple == true ) {
				if ( Input.GetKey (KeyCode.Space) ) {
					textBuffer = "you won!";
				}
			}
		}

		//if ( 100f < Vector3.Distance (seeSaw, transform.position) ) {
		//	textBuffer += "maybe?";
		//}1

		GetComponent<Text>().text = textBuffer;


	}
}
