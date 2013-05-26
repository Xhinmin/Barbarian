using UnityEngine;
using System.Collections;

public class restartLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Application.LoadLevel(0);
        Time.timeScale = 1;
        Destroy(this.gameObject);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
