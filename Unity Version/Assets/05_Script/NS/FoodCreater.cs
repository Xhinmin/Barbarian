using UnityEngine;
using System.Collections;

public class FoodCreater : MonoBehaviour {

    public int interalTime;
    private float time;
    public Transform Food;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Time.time >= time + interalTime)
        {
            //Create Food 
            if(Food)
             Instantiate(Food);
            time = Time.time;
        }
    }
}
