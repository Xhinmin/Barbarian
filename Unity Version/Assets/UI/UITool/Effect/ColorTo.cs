using UnityEngine;
using System.Collections;

public class ColorTo : MonoBehaviour
{
    public iTweenEffectStruct.EffectStruct _effectStruct;

    //��m�P�j�p
    //public Rect rect;
    //����ɶ�
    public float time;
    //�O�_�`��
    public iTweenEffectStruct.loopType looptype;
    //�C���ܤ�
    public Color color;
    //����ɶ�
    public float delay;

    //�O�_�Ȱ�
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