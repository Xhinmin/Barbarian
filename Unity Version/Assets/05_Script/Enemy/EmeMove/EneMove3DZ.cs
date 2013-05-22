using UnityEngine;
using System.Collections;

public class EneMove3DZ : MonoBehaviour {

	// Use this for initialization

	public int x1;
	public int x2;
	public int moveX;
	private int XX;
	

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
		
	    XX = (int)this.transform.position.x;

		
		if (XX>x1 || XX<x2)
			moveX = -moveX;
		
		
		
	}}

