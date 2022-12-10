using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamera : MonoBehaviour
{
    public GameObject follow;
    public float xOffset,yOffset,zOffset;

    // Update is called once per frame
    void Update()
    {
        transform.position = follow.transform.position + new Vector3(xOffset, yOffset, zOffset);
        transform.LookAt(follow.transform.position);
    }
}
