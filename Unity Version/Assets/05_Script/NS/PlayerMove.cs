using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

    Gyroscope myGyro;
    public float speed; 
    Vector3 Force;
	// Use this for initialization
	void Start () {
	  
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {


        if (Input.GetKey(KeyCode.RightArrow))
            Force.x = speed;

        else if (Input.GetKey(KeyCode.UpArrow))
            Force.z = speed;

        else if (Input.GetKey(KeyCode.LeftArrow))
            Force.x = -speed;

        else if (Input.GetKey(KeyCode.DownArrow))
            Force.z = -speed;
        else
        {
            Force.x = 0;
            Force.z = 0;
        }

        this.rigidbody.AddForce(Force);
        //this.rigidbody.AddForce(Input.gyro.userAcceleration.x * speed);

    }
}
