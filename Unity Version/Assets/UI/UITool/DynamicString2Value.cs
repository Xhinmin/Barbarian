using UnityEngine;
using System.Collections;

public class DynamicString2Value : MonoBehaviour {

    //�����j�p
    private Vector2 _ScreenSize = new Vector2(Screen.width, Screen.height);

    //�����ֽ�
    public GUISkin guiSkin;

    //��m�P�j�p
    public Rect rect;

    //��r
    public string Text = "Type Text here";

    //��r�j�p - �̾�1280�����
    public int FontSize = 10;

    //��r�C��
    public Color TextColor = Color.white;

    //�����`�� - ���ȶV�e��
    public int depth;

    /// <summary>
    /// ��r�Φ�
    /// </summary>
    public enum TextTyoe { INT, FLOAT, STRING };
    public TextTyoe textType = TextTyoe.INT;

    //�Φr���@���_�Ө��o���
    public string Key;

    //�ƥ���T
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


    //�S�Ĩt��

    /// <summary>
    /// �s�yRect�ʵe�ĪG (Create)
    /// Name - RectTo
    /// </summary>
    /// <param name="effect">�S�ĵ��c</param>
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
    /// �s�yColor�ʵe�ĪG (Create)
    /// Name - RectTo
    /// </summary>
    /// <param name="effect">�S�ĵ��c</param>
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
    /// �s�yFontSize�ʵe�ĪG (Create)
    /// Name - RectTo
    /// </summary>
    /// <param name="effect">�S�ĵ��c</param>
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
