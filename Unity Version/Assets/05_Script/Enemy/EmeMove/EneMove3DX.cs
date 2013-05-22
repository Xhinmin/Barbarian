using UnityEngine;
using System.Collections;

public class EneMove3DX : MonoBehaviour {
	
	
	public int z1;
	public int z2;
	public int moveZ;
	private int ZZ;

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
		
		ZZ = (int)this.transform.position.z;
		
		if (ZZ>z1 || ZZ<z2)
			moveZ = -moveZ;
		
		
		
	}
}
