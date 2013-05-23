using UnityEngine;
using System.Collections;

public class warcry : MonoBehaviour {

	public int cryrange;
	public float warcryx;
	public float warcryz;
	public int cryrangecount;
		
	
	
	// Use this for initialization
	void Start () {
		
		this.transform.renderer.material.color = Color.blue;
		cryrangecount = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate(){
	
		
		
		this.transform.localScale = new Vector3(this.transform.localScale.x + warcryx, 
				                                this.transform.localScale.y , 
			                                  	this.transform.localScale.z + warcryz);
	
		cryrangecount++;
		if(cryrangecount >= cryrange){
			DestroyObject(this.gameObject);
		}
		
	
	}	




}


