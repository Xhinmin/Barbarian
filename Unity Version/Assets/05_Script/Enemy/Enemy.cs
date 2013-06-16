using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

    public int MinX, MaxX;
    public int MinY, MaxY;
    public int moveZ, moveX;
	int MoveSpeedZ , MoveSpeedX;
    int i;
	int CalToofast;
    float XX, ZZ;
    // Use this for initialization
    void Start()
    {
        //NEW POSITION
        newPosition();
        //AUTO ROTATE

        //        newAction();
		
		
		MoveSpeedX = moveX;
		MoveSpeedZ = moveZ;

    }

    void newPosition()
    {
        i = Random.Range(0, 2);
        if (i == 0)
        {
            this.transform.position = new Vector3(MinX+5, this.transform.position.y, Random.Range(MinY, MaxY));
            //X軸敵人先轉向90度
            transform.Rotate(0, 0, -90);
        }
        if (i == 1)
            this.transform.position = new Vector3(Random.Range(MinX, MaxX), this.transform.position.y, MinY+5);
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
        //X軸敵人移動
        if (i == 0)
        {
            this.transform.position = new Vector3(this.transform.position.x + MoveSpeedX * Time.deltaTime,
                                                  this.transform.position.y,
                                                  this.transform.position.z
                                                  );
            //判斷邊界反向	
            if (this.transform.position.x > MaxX && CalToofast > 3 )
            {
                MoveSpeedX = -moveX;
                transform.Rotate(0, 0, 180);
				CalToofast = 0;
            }
			
			if(this.transform.position.x < MinX && CalToofast > 3)
			{
				MoveSpeedX = moveX;
                transform.Rotate(0, 0, 180);	
			    CalToofast = 0;
			}
			
			CalToofast++;
			
			
        }



        //Y軸敵人移動

        if (i == 1)
        {
            this.transform.position = new Vector3(this.transform.position.x,
                                                  this.transform.position.y,
                                                  this.transform.position.z + MoveSpeedZ * Time.deltaTime
                                                  );
            //判斷邊界反向
            if (this.transform.position.z > MaxY && CalToofast > 3)
            {
                MoveSpeedZ = -moveZ;
                transform.Rotate(0, 0, 180);
				CalToofast = 0;
            }
			
			if(this.transform.position.z < MinY && CalToofast > 3)
			{
				MoveSpeedZ = moveZ;
                transform.Rotate(0, 0, 180);
			    CalToofast = 0;
			}
			
			CalToofast++;
        }
		

    }



}



