using UnityEngine;
using System.Collections;

/// <summary>
/// ���� - ��ܤ�r
/// 13/03/20 Updated.
/// </summary>
public class Label : MonoBehaviour {

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

    //�ƥ���T
    private Rect _rect_backup;
    private Color _TextColor_backup;

	// Use this for initialization
    void Start () {
        if (!guiSkin)       Debug.LogWarning(this.name + "-guiSkin" + "-Unset");
        if (FontSize == 0)  Debug.LogWarning(this.name + "-FontSize" + "-Unset");

        //Backup
        _rect_backup = rect;
        _TextColor_backup = TextColor;
       
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

        GUI.Label(_rect, Text);
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


    // Update callback for iTween
    void updateRect(Rect input)
    {
        rect = input;
    }
    void updateColor(Color input)
    {
        TextColor = input;
    }

}
