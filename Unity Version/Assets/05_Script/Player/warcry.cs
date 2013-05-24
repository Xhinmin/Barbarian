using UnityEngine;
using System.Collections;

public class warcry : MonoBehaviour {

	public int cryrange;
	public float warcryx;
	public float warcryz;

	
	
	// Use this for initialization
	void Start () {
		
		this.transform.renderer.material.color = Color.blue;

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate(){
	
		
		
		this.transform.localScale = new Vector3(this.transform.localScale.x + warcryx, 
				                                this.transform.localScale.y , 
			                                  	this.transform.localScale.z + warcryz);
	

		if(this.transform.localScale.x >= cryrange){
			DestroyObject(this.gameObject);
		}
		
	
	}	




}


