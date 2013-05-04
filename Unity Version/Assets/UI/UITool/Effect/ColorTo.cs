using UnityEngine;
using System.Collections;

public class ColorTo : MonoBehaviour
{
    public iTweenEffectStruct.EffectStruct _effectStruct;

    //位置與大小
    //public Rect rect;
    //持續時間
    public float time;
    //是否循環
    public iTweenEffectStruct.loopType looptype;
    //顏色變化
    public Color color;
    //延遲時間
    public float delay;

    //是否暫停
    public bool isStop;

    public bool isRecover;
    // Use this for initialization
    void Start()
    {
        _effectStruct.time = this.time;
        _effectStruct.color = this.color;
        _effectStruct.delay = this.delay;
        _effectStruct.looptype = this.looptype;
        this.SendMessage("ColorTo", _effectStruct, SendMessageOptions.DontRequireReceiver);


        StartCoroutine(Recover(2.0f));
    }



    // Update is called once per frame
    void Update()
    {       
        if (isStop)
        {
            this.SendMessage("StopColorTo", SendMessageOptions.DontRequireReceiver);
            Destroy(this);
        }
    }

    IEnumerator Recover(float delay)
    {
        yield return new WaitForSeconds(delay);
        if(isRecover)
        this.SendMessage("StopColorTo", _effectStruct, SendMessageOptions.DontRequireReceiver);
        Destroy(this);
    }

    
}