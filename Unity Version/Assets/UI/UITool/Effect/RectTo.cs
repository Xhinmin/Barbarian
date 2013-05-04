using UnityEngine;
using System.Collections;

public class RectTo : MonoBehaviour
{
    public iTweenEffectStruct.EffectStruct _effectStruct;

    //��m�P�j�p
    public Rect rect;
    //����ɶ�
    public float time;
    //�O�_�`��
    public iTweenEffectStruct.loopType looptype;
    //�C���ܤ�
    //public Color color;
    //����ɶ�
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