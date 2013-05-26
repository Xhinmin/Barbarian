using UnityEngine;
using System.Collections;

public class AudioInput : MonoBehaviour {

    string device;
    public bool active;
    
    void Start()
    {
        if (device == null) device = Microphone.devices[0];

        audio.clip = Microphone.Start(device, true, 999, 44100);

        while (!(Microphone.GetPosition(device) > 0))

        { } audio.Play();

    }

    void Update()
    {



        if (!active) return;

        float[] data = new float[735];

        audio.GetOutputData(data, 0);

        //take the median of the recorded samples

        ArrayList s = new ArrayList();

        foreach (float f in data)
        {

            s.Add(Mathf.Abs(f));

        }

        s.Sort();

        FUI.Volume = (float)s[735 / 2];








    }

}
