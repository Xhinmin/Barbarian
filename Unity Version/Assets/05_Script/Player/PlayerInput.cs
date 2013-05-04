using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour
{

    public float speed;
    public Vector4 rangeLimit;
    private Vector2 dis;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        dis = Vector2.zero;

        if (Input.GetKey(KeyCode.RightArrow))
            dis.x = speed;
        if (Input.GetKey(KeyCode.LeftArrow))
            dis.x = -speed;
        if (Input.GetKey(KeyCode.DownArrow))
            dis.y = -speed;
        if (Input.GetKey(KeyCode.UpArrow))
            dis.y = speed;


        //移動
        /*
        if (this.transform.position.x >= rangeLimit.x)
            this.transform.position = new Vector3(rangeLimit.x, this.transform.position.y, this.transform.position.z);
        if (this.transform.position.y >= rangeLimit.y)
            this.transform.position = new Vector3(this.transform.position.x, rangeLimit.y, this.transform.position.z);
        if (this.transform.position.x <= rangeLimit.z)
            this.transform.position = new Vector3(rangeLimit.z, this.transform.position.y, this.transform.position.z);
        if (this.transform.position.y <= rangeLimit.w)
            this.transform.position = new Vector3(this.transform.position.x, rangeLimit.w, this.transform.position.z);


        this.transform.position = new Vector3(
            this.transform.position.x + dis.x * Time.deltaTime,
            this.transform.position.y + dis.y * Time.deltaTime,
            this.transform.position.z
            );
        */
        //以預測下次移動目的為判斷基準

        Vector3 newPosition = this.transform.position + new Vector3(dis.x, dis.y, 0) * Time.deltaTime ;
        if (newPosition.x <= rangeLimit.x &&
            newPosition.y <= rangeLimit.y &&
            newPosition.x >= rangeLimit.z &&
            newPosition.y >= rangeLimit.w)
        {
            this.transform.position = new Vector3(
    this.transform.position.x + dis.x * Time.deltaTime,
    this.transform.position.y + dis.y * Time.deltaTime,
    this.transform.position.z
    );
        }





    }
}
