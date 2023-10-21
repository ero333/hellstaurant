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

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        // Dibuja un rectángulo en el límite horizontal (Hrange)
        Gizmos.DrawWireCube(new Vector3(transform.position.x, (Hrange.x + Hrange.y) / 2, transform.position.z), new Vector3(Hrange.y - Hrange.x, 0, 0));

        Gizmos.color = Color.blue;
        // Dibuja un rectángulo en el límite vertical (Vrange)
        Gizmos.DrawWireCube(new Vector3((Vrange.x + Vrange.y) / 2, transform.position.y, transform.position.z), new Vector3(0, Vrange.y - Vrange.x, 0));
    }
}
