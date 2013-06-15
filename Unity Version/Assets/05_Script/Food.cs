using UnityEngine;
using System.Collections;

public class Food : MonoBehaviour {

    public int MinX , MaxX;
    public int MinY , MaxY;
	// Use this for initialization
	void Start () {
	    //NEW POSITION
        newPosition();
        //AUTO ROTATE
        iTween.RotateAdd(this.gameObject, iTween.Hash("y", 360, "time", 1.5, "looptype", "loop", "easetype", iTween.EaseType.linear));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void newPosition()
    {
        this.transform.position = new Vector3(Random.Range(MinX, MaxX), this.transform.position.y, Random.Range(MinY, MaxY));
    }
}
