using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class UFOMovement : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {




		if ( Input.GetKey ( KeyCode.W ) )
		{
			transform.position += new Vector3( 0f, 0f, 70f ) * Time.deltaTime;
		}
		if ( Input.GetKey ( KeyCode.S ) )
		{
			transform.position += new Vector3( 0f, 0f, -70f ) * Time.deltaTime;
		}
		if ( Input.GetKey ( KeyCode.A ) )
		{
			transform.position += new Vector3( -70f, 0f, 0f ) * Time.deltaTime;
		}
		if ( Input.GetKey ( KeyCode.D ) )
		{
			transform.position += new Vector3( 70f, 0f, 0f ) * Time.deltaTime;
		}



		//floatDist = Vector3.Distance( 0f, 0f, 800f, transform.position ) {
		//}



	
	}
}
