using UnityEngine;
using System.Collections;

public class PlayerInput3D : MonoBehaviour {

	
		public int x;
		public int z;

	
	// Use this for initialization
	void Start () {
	

		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void FixedUpdate(){
		
		
	
	
		if(Input.GetKey("up"))
{
		 rigidbody.AddForce(x, 0, 0);
}
if(Input.GetKey("down"))
{
		 rigidbody.AddForce(-x, 0, 0);
}
if(Input.GetKey("left"))
{
		 rigidbody.AddForce(0, 0, z);
}
if(Input.GetKey("right"))
{
		 rigidbody.AddForce(0, 0, -z);
}
	}
	
	
	
	
	
	
}
