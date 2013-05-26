using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    //http://forum.unity3d.com/threads/133501-check-current-Microphone-input-volume
    Gyroscope myGyro;
    public float speed;
    Vector3 Force;
    public Transform EnemyPrefab;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y >= 10)
            this.transform.position = new Vector3(this.transform.position.x, 10, this.transform.position.z);

        //測試音量大小
        if (FUI.Volume > 0.2)
        {
            iTween.ColorTo(GameObject.Find("Ring"), iTween.Hash("r", 1, "g", 0, "b", 0, "a", 1, "time", 0.25));
            iTween.ColorTo(GameObject.Find("Ring"), iTween.Hash("r", 1, "g", 1, "b", 1, "a", 1, "time", 0.25, "delay", 0.25));
            foreach (GameObject e in GameObject.FindGameObjectsWithTag("Enemy"))
            {
                float dis = Vector3.Distance(this.transform.position, e.transform.position);
                if (dis < 20 + FUI.FoodCount * 5)
                {
                    Destroy(e.gameObject);
                    FUI.FoodCount = 0;
                }
            }

        }
    }

    void FixedUpdate()
    {
        
        
        if (Input.GetKey(KeyCode.RightArrow))
            Force.x = speed;

        else if (Input.GetKey(KeyCode.UpArrow))
            Force.z = speed;

        else if (Input.GetKey(KeyCode.LeftArrow))
            Force.x = -speed;

        else if (Input.GetKey(KeyCode.DownArrow))
            Force.z = -speed;
        else
        {
            Force.x = 0;
            Force.z = 0;
        }

        this.rigidbody.AddForceAtPosition(Force,
            new Vector3( this.transform.position.x , this.transform.position.y + 10F , this.transform.position.z)
                ,ForceMode.Force);
        

        
        if (Input.acceleration.x > 0.3F)
            Force.x = speed + (Input.acceleration.x - 0.3F);

        else if (Input.acceleration.y > 0.1F)
            Force.z = speed + (Input.acceleration.y + 0.1F);

        else if (Input.acceleration.x < -0.3F)
            Force.x = -speed - (Input.acceleration.x + 0.3F);

        else if (Input.acceleration.y < -0.5F)
            Force.z = -speed - (Input.acceleration.y - 0.5F);
        else
        {
            Force.x = 0;
            Force.z = 0;
        }

        this.rigidbody.AddForceAtPosition(Force,
            new Vector3(this.transform.position.x, this.transform.position.y + 10F, this.transform.position.z)
                , ForceMode.Force);

    }


    void OnTriggerEnter(Collider obj)
    {
        if (obj.transform.name == "EnemyPrefab" || obj.transform.name == "EnemyPrefab(Clone)")
        {
            Destroy(obj.gameObject);
            FUI.HP--;
        }
        if (obj.transform.name == "FoodPrefab" || obj.transform.name == "FoodPrefab(Clone)")
        {
            Destroy(obj.gameObject);
            FUI.FoodCount++;
            Instantiate(EnemyPrefab);
        }
    }


    public void Fire()
    {
        iTween.ColorTo(GameObject.Find("Ring"), iTween.Hash("r", 1, "g", 0, "b", 0, "a", 1, "time", 0.25));
        iTween.ColorTo(GameObject.Find("Ring"), iTween.Hash("r", 1, "g", 1, "b", 1, "a", 1, "time", 0.25, "delay", 0.25));

        foreach (GameObject e in GameObject.FindGameObjectsWithTag("Enemy"))
        {
            float dis = Vector3.Distance(this.transform.position, e.transform.position);
            if (dis < 50 + FUI.FoodCount * 10)
                Destroy(e.gameObject);
        }

    }
}
