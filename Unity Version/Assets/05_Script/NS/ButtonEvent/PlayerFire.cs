using UnityEngine;
using System.Collections;

public class PlayerFire : MonoBehaviour {

	// Use this for initialization
    public GameObject player;
	void Start () {
        player.GetComponent<Player>().Fire();
		FUI.FoodCount = 0;
        Destroy(this.gameObject);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
