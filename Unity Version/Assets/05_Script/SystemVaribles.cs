using UnityEngine;
using System.Collections;

public class SystemVaribles : MonoBehaviour {

    public bool isAlready  = false;
    public static SystemVaribles script;
    //視窗大小
    public Vector2 _ScreenSize = new Vector2(Screen.width, Screen.height);
    //視窗比例
    public float screenRatio = 2;
    //攻擊環物件
    public GameObject AttackRing;
    //敵人Prefab
    public GameObject EnemyPrefab;
    //特效Prefab
    public GameObject AttackRingEffect;

	// Use this for initialization
	void Start () {
        script = this;
        screenRatio = Screen.width / (float)Screen.height;

        isAlready = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
