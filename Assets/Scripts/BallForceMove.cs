using UnityEngine;
using System.Collections;

public class BallForceMove : MonoBehaviour
{
    public float targetY=0.54f;

    void Update()
    {
        if (transform.localPosition.y > targetY)
        {
            transform.localPosition = new Vector3(transform.localPosition.x,
                targetY,
                transform.localPosition.z);
        }
    }
}
