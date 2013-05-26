using UnityEngine;
using System.Collections;

public class AutoRotate : MonoBehaviour {

    public float time;
	// Use this for initialization
	void Start () {
        iTween.RotateAdd(this.gameObject, iTween.Hash("y", 360, "time",time, "looptype", "loop", "easetype", iTween.EaseType.linear));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
