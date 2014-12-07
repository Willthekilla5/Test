using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public bool touchingGround; 
	public float sphereRadius = 0.5f;

	public Vector3 bounceVelocity = new Vector3 ( 0, 10, 0 );

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		touchingGround = IsTouching();
		Debug.Log (IsTouching () );

		if (touchingGround == true ) {
			Bounce ( bounceVelocity  );
		}
	}
  void Function1  () {
		Debug.Log ("This is a function");
		float tempVar = 1.1f;
		tempVar = 5.4f; 


	}

	void Bounce ( Vector3 bounceVelocity ) {
		rigidbody.velocity = bounceVelocity;
	}

	bool IsTouching () {
		return Physics.Raycast (transform.position, Vector3.down, sphereRadius );
	}	
}
