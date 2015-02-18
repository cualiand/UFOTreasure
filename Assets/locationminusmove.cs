using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class locationminusmove : MonoBehaviour {
	
	
	bool foundBasket = false;
	bool foundSeesaw = false;
	bool foundApple = false;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		string textBuffer = "welcome!";
		//textBuffer += "djfaskdfjasd";
		
		
		Vector3 ballPit = new Vector3( 925f, 26f, 1327 );
		Vector3 seeSaw = new Vector3( 675.1f, 79.1f, 1320.1f );
		Vector3 apple = new Vector3( 399.1f, 104.3f, 1195.7f );
		
		float dist1 = Vector3.Distance (transform.position, ballPit);
		float dist2 = Vector3.Distance (seeSaw, transform.position);
		float dist3 = Vector3.Distance (apple, transform.position);
		Debug.Log (dist1);
		textBuffer += dist1;
		Debug.Log (transform.position);
		
		if ( dist1 < 1500 )  {
			textBuffer += "something went right!";
		}
		//if ( 100f < Vector3.Distance (seeSaw, transform.position) ) {
		//	textBuffer += "maybe?";
		//}1
		
		GetComponent<Text>().text = textBuffer;
		
		
	}
}