using UnityEngine;
using System.Collections;

public class restartLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Application.LoadLevel(0);
        Time.timeScale = 1;
		FUI.HP = 3;
		if(FUI.score >= FUI.highestscore)  FUI.highestscore = FUI.score;
		FUI.score = 0;
		FUI.FoodCount = 0;
        Destroy(this.gameObject);
//		Application.Quit();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
