using UnityEngine;
using System.Collections;

/// <summary>
/// 介面 - 顯示圖片
/// 13/03/20 Updated.
/// </summary>
public class Texture_2D : MonoBehaviour {

    //視窗大小
    private Vector2 _ScreenSize = new Vector2(Screen.width, Screen.height);

    //位置與大小
    public Rect rect;

    //圖案
    public Texture Texture2d;

    //圖案角度
    public int angle;

    //圖案顏色
    public Color TextureColor = Color.white;

    //介面深度 - 正值越前面
    public int depth;

    //備份資訊
    private Rect _rect_backup;
    private Color _TextureColor_backup;

	// Use this for initialization
    void Start () {
        if (!Texture2d) Debug.LogWarning(this.name + "-Texture2d" + "-Unset");


        //Backup
        _rect_backup = rect;
        _TextureColor_backup = TextureColor;
        //鎖定寬度自動放大
        //rect.height *= Screen.width / (float)Screen.height;

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {

        Rect _rect = new Rect(rect.x * _ScreenSize.x
                        , rect.y * _ScreenSize.y
                        , rect.width * _ScreenSize.x
                        , rect.height * _ScreenSize.y);

        GUI.color = TextureColor;
        GUI.depth = depth;
        GUIUtility.RotateAroundPivot(angle, new Vector2(_rect.x + _rect.width / 2, _rect.y + _rect.height / 2));
        
        GUI.DrawTexture(_rect, Texture2d);

    }

    void Init()
    {    
        rect = _rect_backup;
        TextureColor = _TextureColor_backup;
    
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
           "from", TextureColor,
           "to", effect.color,
           "delay", effect.delay,
           "time", effect.time,
           "easetype", iTween.EaseType.easeInOutCubic,
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
        TextureColor = _TextureColor_backup;
        iTween.StopByName(this.gameObject,"ColorTo");
    }


    // Update callback for iTween
    void updateRect(Rect input)
    {
        rect = input;
    }
    void updateColor(Color input)
    {
        TextureColor = input;
    }
}
