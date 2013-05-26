using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

    public int MinX, MaxX;
    public int MinY, MaxY;
    int i;
    // Use this for initialization
    void Start()
    {
        //NEW POSITION
        newPosition();
        //AUTO ROTATE
        newAction();

    }

    void newPosition()
    {
        i = Random.Range(0, 2);
        if (i == 0)
            this.transform.position = new Vector3(MinX, this.transform.position.y, Random.Range(MinY, MaxY));
        else
            this.transform.position = new Vector3(Random.Range(MinX, MaxX), this.transform.position.y, MinY);
    }


    void newAction()
    {
        if (i == 0)
            iTween.MoveTo(this.gameObject, iTween.Hash("x", MaxX, "y", this.transform.position.y, "z", this.transform.position.z,
                                                            "time", 5, "looptype", "pingpong", "easetype", iTween.EaseType.linear));
        if (i == 1)
            iTween.MoveTo(this.gameObject, iTween.Hash("x", this.transform.position.x, "y", this.transform.position.y, "z", MaxY,
                                                            "time", 5, "looptype", "pingpong", "easetype", iTween.EaseType.linear));

    }

    // Update is called once per frame
    void Update()
    {

    }


}
