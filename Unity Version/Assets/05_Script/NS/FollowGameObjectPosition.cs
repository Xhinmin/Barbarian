using UnityEngine;
using System.Collections;

public class FollowGameObjectPosition : MonoBehaviour
{
    public GameObject gameObject;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = gameObject.transform.position;
    }
}
