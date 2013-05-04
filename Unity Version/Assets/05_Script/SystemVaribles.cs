using UnityEngine;
using System.Collections;

public class SystemVaribles : MonoBehaviour {

    public static SystemVaribles ST;
    //視窗大小
    public Vector2 _ScreenSize = new Vector2(Screen.width, Screen.height);
    //視窗比例
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
