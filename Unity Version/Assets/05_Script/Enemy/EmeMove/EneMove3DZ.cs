using UnityEngine;
using System.Collections;

public class EneMove3DZ : MonoBehaviour {

	// Use this for initialization

	public int x1;
	public int x2;
	public int moveX;
	

	// Use this for initialization
	void Start () {
	this.transform.renderer.material.color = Color.red;
	}
	
	
	
	// Update is called once per frame
	void Update () {
	
		this.transform.position = new Vector3(this.transform.position.x +moveX * Time.deltaTime,
                                              this.transform.position.y ,
                                              this.transform.position.z 
                                              );
		
		
		if (this.transform.position.x>x1 || this.transform.position.x<x2)
			moveX = -moveX;
		
		
		
	}}

