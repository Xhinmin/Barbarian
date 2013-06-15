using UnityEngine;
using System.Collections;

public class RestartLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Application.LoadLevel(0);
        Time.timeScale = 1;
		FUI.HP = 3;
		FUI.Score = 0;
		FUI.FoodCount = 0;
        Destroy(this.gameObject);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
