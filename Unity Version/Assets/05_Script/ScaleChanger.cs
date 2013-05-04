using UnityEngine;
using System.Collections;

public class ScaleChanger : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.transform.localScale *= SystemVaribles.ST.screenRatio;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
