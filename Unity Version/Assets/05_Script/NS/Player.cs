using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    private bool isInit = false;

    public float speed;
    //力量向量
    private Vector3 _force;
    private GameObject _enemyPrefab;
    private GameObject _AttackRing;
    int emenycount;

    void Init()
    {
        isInit = true;
        _enemyPrefab = SystemVaribles.script.EnemyPrefab;
        _AttackRing = SystemVaribles.script.AttackRing;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if(!isInit)    Init();

        // Limit the Y of the player , in order to dont let player over the wall
        if (this.transform.position.y >= 10)
            this.transform.position = new Vector3(this.transform.position.x, 10, this.transform.position.z);


        if (FUI.Volume > 0.30)
        {
            iTween.ColorTo(_AttackRing, iTween.Hash("r", 1, "g", 0, "b", 0, "a", 1, "time", 0.25));
            iTween.ColorTo(_AttackRing, iTween.Hash("r", 1, "g", 1, "b", 1, "a", 1, "time", 0.25, "delay", 0.25));
            foreach (GameObject e in GameObject.FindGameObjectsWithTag("Enemy"))
            {
                float dis = Vector3.Distance(this.transform.position, e.transform.position);
                if (dis < 40 + FUI.FoodCount * 10)
                {
                    Destroy(e.gameObject);
                    FUI.HitEnemyCount++;
                    scorecount();
                }

            }
            

        }
    }

    void FixedUpdate()
    {
        ///////////////////////////////////
        //Input From WindowsKeyboard

        if (Input.GetKey(KeyCode.RightArrow)) _force.x = speed;
        else if (Input.GetKey(KeyCode.UpArrow)) _force.z = speed;
        else if (Input.GetKey(KeyCode.LeftArrow)) _force.x = -speed;
        else if (Input.GetKey(KeyCode.DownArrow)) _force.z = -speed;
        else
        {
            _force.x = 0;
            _force.z = 0;
        }

        this.rigidbody.AddForceAtPosition(
            _force,
            new Vector3(this.transform.position.x, this.transform.position.y + 10F, this.transform.position.z),
            ForceMode.Force
            );

        ///////////////////////////////////////////
        //Input From Platform Device
        if (Input.acceleration.x > 0.2F) _force.x = speed + (Input.acceleration.x - 0.3F);
        else if (Input.acceleration.y > 0.05F) _force.z = speed + (Input.acceleration.y + 0.1F);
        else if (Input.acceleration.x < -0.2F) _force.x = -speed - (Input.acceleration.x + 0.3F);
        else if (Input.acceleration.y < -0.3F) _force.z = -speed - (Input.acceleration.y - 0.5F);
        else
        {
            _force.x = 0;
            _force.z = 0;
        }

        this.rigidbody.AddForceAtPosition(_force,
            new Vector3(this.transform.position.x, this.transform.position.y + 10F, this.transform.position.z)
                , ForceMode.Force);

        ////////////////////////////////////////

    }


    void OnTriggerEnter(Collider obj)
    {
        if (obj.transform.name == "EnemyPrefab" || obj.transform.name == "EnemyPrefab(Clone)")
        {
            iTween.ColorFrom(GameObject.Find("Barbar01"), iTween.Hash("r", 1, "g", 0, "b", 0, "a", 1, "time", 0.25));
            Destroy(obj.gameObject);
            FUI.HP--;

        }
        if (obj.transform.name == "FoodPrefab" || obj.transform.name == "FoodPrefab(Clone)")
        {
            Destroy(obj.gameObject);
            FUI.FoodCount++;
            Instantiate(_enemyPrefab);
        }
    }


    public void Fire()
    {
        iTween.ColorTo(_AttackRing, iTween.Hash("r", 1, "g", 0, "b", 0, "a", 1, "time", 0.25));
        iTween.ColorTo(_AttackRing, iTween.Hash("r", 1, "g", 1, "b", 1, "a", 1, "time", 0.25, "delay", 0.25));

        foreach (GameObject e in GameObject.FindGameObjectsWithTag("Enemy"))
        {
            float dis = Vector3.Distance(this.transform.position, e.transform.position);
            if (dis < 40 + FUI.FoodCount * 10)
            {
                Destroy(e.gameObject);
                FUI.HitEnemyCount++;
                scorecount();
            }

        }
    }


    //分數計算
    public void scorecount()
    {
        FUI.Score = FUI.HitEnemyCount * FUI.FoodCount + FUI.Score;
        FUI.HitEnemyCount = 0;
        FUI.FoodCount = 0;
    }

}
