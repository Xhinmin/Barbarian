using UnityEngine;
using System.Collections;

public class SystemVaribles : MonoBehaviour {

    public static SystemVaribles ST;
    //�����j�p
    public Vector2 _ScreenSize = new Vector2(Screen.width, Screen.height);
    //�������
    public float screenRatio = 2;
	// Use this for initialization
	void Start () {
        ST = this;
        screenRatio = Screen.width / (float)Screen.height;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
