using UnityEngine;
using System.Collections;

public class EneMove3DX : MonoBehaviour {
	
	
	public int z1;
	public int z2;
	public int moveZ;
	

	// Use this for initialization
	void Start () {
	this.transform.renderer.material.color = Color.red;
	}
	
	
	
	// Update is called once per frame
	void Update () {
	
		this.transform.position = new Vector3(this.transform.position.x ,
                                              this.transform.position.y ,
                                              this.transform.position.z +moveZ * Time.deltaTime
                                              );
		
		
		if (this.transform.position.z>z1 || this.transform.position.z<z2)
			moveZ = -moveZ;
		
		
		
	}
}
