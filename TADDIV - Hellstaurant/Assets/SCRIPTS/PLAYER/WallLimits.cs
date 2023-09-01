using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallLimits : MonoBehaviour
{
    private Transform theTransform;
    public Vector2 Hrange = Vector2.zero; //limite horizontal
    public Vector2 Vrange = Vector2.zero; //limite vertical

    private void LateUpdate()
    {
        theTransform.position = new Vector3(

            Mathf.Clamp(transform.position.x, Vrange.x, Vrange.y),
            Mathf.Clamp(transform.position.y, Hrange.x, Hrange.y),
            transform.position.z
            );
    }

    void Start()
    {
        theTransform = GetComponent<Transform>();
    }
}
