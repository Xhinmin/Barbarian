using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

    public int MinX, MaxX;
    public int MinY, MaxY;
	public int moveZ,moveX;
    int i;
	float XX,ZZ;
    // Use this for initialization
    void Start()
    {
        //NEW POSITION
        newPosition();
        //AUTO ROTATE
		
//        newAction();

    }

    void newPosition()
    {
        i = Random.Range(0, 2);
        if (i == 0){
            this.transform.position = new Vector3(MinX, this.transform.position.y, Random.Range(MinY, MaxY));
			//X�b�ĤH����V90��
			transform.Rotate(0, 0, -90);		    
		    }
	    if (i != 0)
            this.transform.position = new Vector3(Random.Range(MinX, MaxX), this.transform.position.y, MinY);
    }
	
	
	
/*
    void newAction()
    {
        if (i == 0)
            iTween.MoveTo(this.gameObject, iTween.Hash("x", MaxX, "y", this.transform.position.y, "z", this.transform.position.z,
                                                            "time", 5, "looptype", "pingpong", "easetype", iTween.EaseType.linear));
        if (i == 1)
            iTween.MoveTo(this.gameObject, iTween.Hash("x", this.transform.position.x, "y", this.transform.position.y, "z", MaxY,
                                                            "time", 5, "looptype", "pingpong", "easetype", iTween.EaseType.linear));

    }
 */
	
	

    // Update is called once per frame
    void Update()
    {
		//X�b�ĤH����
	    if (i == 0){
            this.transform.position = new Vector3(this.transform.position.x +moveX * Time.deltaTime,
                                                  this.transform.position.y ,
                                                  this.transform.position.z 
                                                  );
		//�P�_��ɤϦV	
	    XX = this.transform.position.x;
		if (XX>MaxX || XX<MinX){
			moveX = -moveX;
			transform.Rotate(0, 0, 180);
			}
			
		}
		
		
		
	   //Y�b�ĤH����
					
       if (i != 0) 
		{
            this.transform.position = new Vector3(this.transform.position.x ,
                                                  this.transform.position.y ,
                                                  this.transform.position.z +moveZ * Time.deltaTime
    	                                          );
	    //�P�_��ɤϦV			
	    ZZ = this.transform.position.z;
		if (ZZ>MaxY || ZZ<MinY){
			moveZ = -moveZ;
			transform.Rotate(0, 0, 180);
			}
		          }
		
		}		
    


}



