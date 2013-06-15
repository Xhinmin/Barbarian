using UnityEngine;
using System.Collections;

public class FUI : MonoBehaviour
{

    public static int HP = 3;
    public static int FoodCount;
    public static int HitEnemyCount;
    public static int Score;
    public static int Highscore;
    public static float Volume;
    public GameObject RestartButton;
    public GameObject Ring;

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
            //�̰�����
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

        GUI.Label(new Rect(0, 100, 1000, 200), "�ͩR�G" + HP.ToString());
        GUI.Label(new Rect(0, 140, 1000, 200), "�d��G" + FoodCount.ToString());
        GUI.Label(new Rect(0, 180, 1000, 200), "���q�G" + (Volume * 100).ToString("00.00"));

        GUI.skin.label.fontSize = 50;
        GUI.Label(new Rect(0, 0, 1000, 200), "�̰����ơG" + Highscore.ToString());
        GUI.Label(new Rect(0, 50, 1000, 200), "����       �G" + Score.ToString());
    }
}