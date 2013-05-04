using UnityEngine;
using System.Collections;

public class iTweenEffectStruct : MonoBehaviour
{

    public enum EaseType
    {
        easeInQuad,
        easeOutQuad,
        easeInOutQuad,
        easeInCubic,
        easeOutCubic,
        easeInOutCubic,
        easeInQuart,
        easeOutQuart,
        easeInOutQuart,
        easeInQuint,
        easeOutQuint,
        easeInOutQuint,
        easeInSine,
        easeOutSine,
        easeInOutSine,
        easeInExpo,
        easeOutExpo,
        easeInOutExpo,
        easeInCirc,
        easeOutCirc,
        easeInOutCirc,
        linear,
        spring,
        /* GFX47 MOD START */
        //bounce,
        easeInBounce,
        easeOutBounce,
        easeInOutBounce,
        /* GFX47 MOD END */
        easeInBack,
        easeOutBack,
        easeInOutBack,
        /* GFX47 MOD START */
        //elastic,
        easeInElastic,
        easeOutElastic,
        easeInOutElastic,
        /* GFX47 MOD END */
        punch
    }

    public enum loopType { none, pingPong, loop }
    public struct EffectStruct
    {

        //位置與大小
        public Rect rect;
        //持續時間
        public float time;
        //是否循環
        public loopType looptype;
        //顏色變化
        public Color color;
        //延遲時間
        public float delay;
        //字型大小
        public float fontsize;

        public EaseType easeType;
    }


    //位置與大小
    public Rect rect;
    //持續時間
    public float time;
    //是否循環
    public loopType looptype;
    //顏色變化
    public Color color;
    //延遲時間
    public float delay;

    public float fontsize;

    public EaseType easeType;

    public bool addColorTo;
    public bool addRectTo; 

	// Use this for initialization
	void Start () {
	   
        
	}
	
	// Update is called once per frame
	void Update () {
        if (addColorTo)
        {
            AddComponentColorTo();
            addColorTo = false;
        }
        if (addRectTo)
        {
            AddComponentRectTo();
            addRectTo = false;
        }
        
    }

    public void AddComponentColorTo()
    {
        ColorTo colorto = this.gameObject.AddComponent<ColorTo>();
        colorto.time = this.time;
        colorto.delay = this.delay;
        colorto.color = this.color;
        colorto.looptype = this.looptype;
    }
    public void AddComponentColorTo(EffectStruct effect)
    {
        ColorTo colorto = this.gameObject.AddComponent<ColorTo>();
        colorto.time = this.time;
        colorto.color = this.color;
        colorto.looptype = this.looptype;
    }
    void AddComponentRectTo()
    {
        RectTo rectto = this.gameObject.AddComponent<RectTo>();
        rectto.time = this.time;
        rectto.rect = this.rect;
        rectto.looptype = this.looptype;
    }

    public void AddComponentFontSizeTo()
    {
    }
    void DeleteComponentColorTo()
    {

    }
    void DeleteComponentRectTo()
    {

    }
    
}
