using UnityEngine;
using System.Collections;

public class SystemVaribles : MonoBehaviour {

    public bool isAlready  = false;
    public static SystemVaribles script;
    //�����j�p
    public Vector2 _ScreenSize = new Vector2(Screen.width, Screen.height);
    //�������
    public float screenRatio = 2;
    //����������
    public GameObject AttackRing;
    //�ĤHPrefab
    public GameObject EnemyPrefab;
    //�S��Prefab
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
