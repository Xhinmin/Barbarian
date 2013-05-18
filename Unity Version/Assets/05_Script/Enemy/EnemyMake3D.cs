using UnityEngine;
using System.Collections;

public class EnemyMake3D : MonoBehaviour {

	// Use this for initialization
	public Transform newEnemy1;
	public bool createEnemy;
	public Vector2 randonPosition;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
		if(createEnemy)
		{
			float newPositionX = Random.Range(randonPosition.x,randonPosition.y);
			createEnemy = false;
			Instantiate(newEnemy1,new Vector3(newPositionX,0,110),newEnemy1.rotation);
		}
		
		
	}

}
