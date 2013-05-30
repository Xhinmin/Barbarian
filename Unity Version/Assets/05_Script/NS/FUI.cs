using UnityEngine;
using System.Collections;

public class FUI : MonoBehaviour {

    public static int HP = 3;
    public static int FoodCount;
	public static int enemydie;
	public static int score;
	public static int highestscore;
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
            //«ö¶s¶}±Ò ®É¶¡ŒÈ°±
            Time.timeScale = 0;
            RestartButton.SetActive(true);
			
        }
        Ring.transform.localScale = new Vector3(5 + FoodCount * 2 , 1, 5 + FoodCount * 2);
		
		score = enemydie*FoodCount+score;
		
		
	}

    void OnGUI()
    {
        GUI.color = Color.black;
        GUI.skin.label.fontSize = 40;

        GUI.Label(new Rect(0, 100, 1000, 200), "生命：" + HP.ToString());
        GUI.Label(new Rect(0, 140, 1000, 200), "範圍：" + FoodCount.ToString());
        GUI.Label(new Rect(0, 180, 1000, 200), "音量：" + (Volume * 100 ).ToString("00.00"));
		
        GUI.skin.label.fontSize = 50;		
		GUI.Label(new Rect(0, 0, 1000, 200), "最高分數：" + highestscore.ToString());
		GUI.Label(new Rect(0, 50, 1000, 200), "分數       ：" + score.ToString());
    }
}
