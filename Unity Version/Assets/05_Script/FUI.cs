using UnityEngine;
using System.Collections;

public class FUI : MonoBehaviour
{

    public static int HP = 3;
    public static int FoodCount;
    public static int HitEnemyCount;
    public static int Score;
    public static int Highscore;
	public static int GuiWardTime;
    public static float Volume;
	public static int GuiScore;
    public GameObject RestartButton;
    public GameObject Ring;
	public GameObject Player;
	
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (HP == 0)
        {
            //TimeScale set to zero
            Time.timeScale = 0;
            //程蔼だ计
            if (FUI.Score >= FUI.Highscore)
            {
                FUI.Highscore = FUI.Score;
            }
            RestartButton.SetActive(true);

        }
        Ring.transform.localScale = new Vector3(5 + FoodCount * 2, 1, 5 + FoodCount * 2);


    }

    void OnGUI()
    {
        GUI.color = Color.black;
        GUI.skin.label.fontSize = 40;

        GUI.Label(new Rect(0, 100, 1000, 200), "ネ㏑" + HP.ToString());
        GUI.Label(new Rect(0, 140, 1000, 200), "絛瞅" + FoodCount.ToString());
        GUI.Label(new Rect(0, 180, 1000, 200), "秖" + (Volume * 100).ToString("00.00"));

        GUI.skin.label.fontSize = 50;
        GUI.Label(new Rect(0, 0, 1000, 200), "程蔼だ计" + Highscore.ToString());
        GUI.Label(new Rect(0, 50, 1000, 200), "だ计       " + Score.ToString());
		
		
		
		
		

		if(GuiScore>=2&&GuiScore<6&&GuiWardTime<200)
		{
			GUI.color = Color.blue;
			GUI.Label(new Rect(450, 120, 1000, 200), "GOOD");
			
			GuiWardTime++;
		}
		
		if(GuiScore>=6&&GuiScore<10&&GuiWardTime<200)
		{
			GUI.color = Color.blue;
			GUI.Label(new Rect(450, 120, 1000, 200), "NICE");
			
			GuiWardTime++;
		}

		
		if(GuiScore>=10&&GuiWardTime<200)
		{
			GUI.color = Color.red;
			GUI.skin.label.fontSize = 80;
			GUI.Label(new Rect(450, 120, 1000, 200), "GOD LIKE");
			
			GuiWardTime++;
		}
		
		
    }
}
