using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canastaPounds : MonoBehaviour
{
      private float speed = 10f;
    private Rigidbody2D myBody;
	// Use this for initialization
    
    void Awake(){
		myBody = GetComponent<Rigidbody2D> ();
	}

	
	// Update is called once per frame
	void FixedUpdate () {
		Vector2 vel =myBody.velocity;
        vel.x = Input.GetAxis ("Horizontal") * speed;
        myBody.velocity = vel;
	}
}


