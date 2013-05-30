using UnityEngine;
using System.Collections;

public class EmenyCreater : MonoBehaviour {

    public int interalTime;
    private float time;
    public Transform Enemy;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Time.time >= time + interalTime)
        {
            //Create Food 
            if(Enemy)
             Instantiate(Enemy);
            time = Time.time;
        }
    }
}
