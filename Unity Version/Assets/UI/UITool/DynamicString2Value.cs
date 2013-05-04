using UnityEngine;
using System.Collections;

public class DynamicString2Value : MonoBehaviour {

    //視窗大小
    private Vector2 _ScreenSize = new Vector2(Screen.width, Screen.height);

    //介面皮膚
    public GUISkin guiSkin;

    //位置與大小
    public Rect rect;

    //文字
    public string Text = "Type Text here";

    //文字大小 - 依據1280為基準
    public int FontSize = 10;

    //文字顏色
    public Color TextColor = Color.white;

    //介面深度 - 正值越前面
    public int depth;

    /// <summary>
    /// 文字形式
    /// </summary>
    public enum TextTyoe { INT, FLOAT, STRING };
    public TextTyoe textType = TextTyoe.INT;

    //用字串當作金鑰來取得資料
    public string Key;

    //備份資訊
    private Rect _rect_backup;
    private Color _TextColor_backup;
    private int _fontSize_backup;


	// Use this for initialization
	void Start () {
        if (!guiSkin) Debug.LogWarning(this.name + "-guiSkin" + "-Unset");
        if (FontSize == 0) Debug.LogWarning(this.name + "-FontSize" + "-Unset");

        //Backup
        _rect_backup = rect;
        _TextColor_backup = TextColor;
        _fontSize_backup = FontSize;
	}
	
	// Update is called once per frame
	void Update () {
     
	}

    void OnGUI()
    {
        if (guiSkin)
            GUI.skin = this.guiSkin;

        Rect _rect = new Rect(rect.x * _ScreenSize.x
                        , rect.y * _ScreenSize.y
                        , rect.width * _ScreenSize.x
                        , rect.height * _ScreenSize.y);

        GUI.skin.label.fontSize = (int)((_ScreenSize.x / 1280) * FontSize);
        GUI.skin.label.normal.textColor = TextColor;
        GUI.depth = depth;


        switch (textType)
        {
            case TextTyoe.INT:
                Text = PlayerPrefs.GetInt(Key).ToString();
                break;
            case TextTyoe.FLOAT:
                Text = PlayerPrefs.GetFloat(Key).ToString();
                break;
            case TextTyoe.STRING:
                Text = PlayerPrefs.GetString(Key).ToString();
                break;

        }
        

        GUI.Label(_rect, Text);

    }




    void Init()
    {

    }


    //特效系統

    /// <summary>
    /// 製造Rect動畫效果 (Create)
    /// Name - RectTo
    /// </summary>
    /// <param name="effect">特效結構</param>
    void RectTo(iTweenEffectStruct.EffectStruct effect)
    {

        iTween.ValueTo(gameObject, iTween.Hash(
            "from", rect,
            "to", effect.rect,
            "delay", effect.delay,
            "time", effect.time,
            "easetype", effect.easeType.ToString(),
            "onupdate", "updateRect",
             "loopType", effect.looptype.ToString(),
             "name", "RectTo"));
    }

    /// <summary>
    /// 製造Color動畫效果 (Create)
    /// Name - RectTo
    /// </summary>
    /// <param name="effect">特效結構</param>
    void ColorTo(iTweenEffectStruct.EffectStruct effect)
    {
        iTween.ValueTo(gameObject, iTween.Hash(
           "from", TextColor,
           "to", effect.color,
           "delay", effect.delay,
           "time", effect.time,
           "easetype", effect.easeType.ToString(),
           "onupdate", "updateColor",
           "loopType", effect.looptype.ToString(),
           "name", "ColorTo"));

    }

    /// <summary>
    /// 製造FontSize動畫效果 (Create)
    /// Name - RectTo
    /// </summary>
    /// <param name="effect">特效結構</param>
    void FontSizeTo(iTweenEffectStruct.EffectStruct effect)
    {
        iTween.ValueTo(gameObject, iTween.Hash(
           "from", FontSize,
           "to", effect.fontsize,
           "delay", effect.delay,
           "time", effect.time,
           "easetype", effect.easeType.ToString(),
           "onupdate", "updateFontSize",
           "loopType", effect.looptype.ToString(),
           "name", "FontSizeTo"));

    }


    void StopRectTo()
    {
        rect = _rect_backup;
        iTween.StopByName(this.gameObject, "RectTo");
    }
    void StopColorTo()
    {
        TextColor = _TextColor_backup;
        iTween.StopByName(this.gameObject, "ColorTo");
    }

    void StopFontSizeTo()
    {
        FontSize = _fontSize_backup;
        iTween.StopByName(this.gameObject, "FontSizeTo");
    }



    // Update callback for iTween
    void updateRect(Rect input)
    {
        rect = input;
    }
    void updateColor(Color input)
    {
        TextColor = input;
    }
    void updateFontSize(int input)
    {
        FontSize = input;
    }
}
