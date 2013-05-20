using UnityEngine;
using System.Collections;

public class EnemyMake3D : MonoBehaviour {

	// Use this for initialization
	public Transform newEnemy1;
	public Transform newEnemy2;
	public bool createEnemy;
	public Vector2 randonPX;
	public Vector2 randonPZ;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
		if(createEnemy)
		{
			int randomemeny = Random.Range(0,2);
			
			
			if(randomemeny == 0){			
			float newPositionX = Random.Range(randonPX.x,randonPX.y);
			createEnemy = false;
			Instantiate(newEnemy1,new Vector3(newPositionX,0,110),newEnemy1.rotation);
			}
			
			
			else if(randomemeny == 1){			
			float newPositionZ = Random.Range(randonPZ.x,randonPZ.y);
			createEnemy = false;
			Instantiate(newEnemy2,new Vector3(80,0,newPositionZ),newEnemy1.rotation);
			}
		
		
	}

}
}