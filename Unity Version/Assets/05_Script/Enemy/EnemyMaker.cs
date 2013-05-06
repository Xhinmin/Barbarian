using UnityEngine;
using System.Collections;

public class EnemyMaker : MonoBehaviour {
	
	public Transform newEnemy;
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
			Instantiate(newEnemy,new Vector3(newPositionX,0,1),newEnemy.rotation);
		}
		
		
	}
}
