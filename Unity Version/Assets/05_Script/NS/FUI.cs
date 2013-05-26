using UnityEngine;
using System.Collections;

public class FUI : MonoBehaviour {

    public static int HP = 10;
    public static int FoodCount;
    public static float Volume;
    public GameObject RestartButton;
    public GameObject Ring;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (HP == 0)
        {
            //按鈕開啟 時間暫停
            Time.timeScale = 0;
            RestartButton.SetActive(true);
        }
        Ring.transform.localScale = new Vector3(5 + FoodCount * 2 , 1, 5 + FoodCount * 2);
	}

    void OnGUI()
    {
        GUI.color = Color.black;
        GUI.skin.label.fontSize = 20;

        GUI.Label(new Rect(0, 0, 500, 50), "剩餘次數：" + HP.ToString());
        GUI.Label(new Rect(0, 20, 500, 50), "範圍增幅：" + FoodCount.ToString());
        GUI.Label(new Rect(0, 40, 500, 50), "音量測量：" + (Volume * 100 ).ToString("00.00"));
    }
}
