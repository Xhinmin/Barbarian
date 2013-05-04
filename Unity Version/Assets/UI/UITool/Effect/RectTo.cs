using UnityEngine;
using System.Collections;

public class RectTo : MonoBehaviour
{
    public iTweenEffectStruct.EffectStruct _effectStruct;

    //位置與大小
    public Rect rect;
    //持續時間
    public float time;
    //是否循環
    public iTweenEffectStruct.loopType looptype;
    //顏色變化
    //public Color color;
    //延遲時間
    public float delay;

    public iTweenEffectStruct.EaseType easeType;
    

    // Use this for initialization
    void Start()
    {
        _effectStruct.time = this.time;
        _effectStruct.rect = this.rect;
        _effectStruct.looptype = this.looptype;
        _effectStruct.delay = this.delay;
        _effectStruct.easeType = this.easeType;

        this.SendMessage("RectTo", _effectStruct, SendMessageOptions.DontRequireReceiver);
        Destroy(this);
    }



    // Update is called once per frame
    void Update()
    {
        
    }


}