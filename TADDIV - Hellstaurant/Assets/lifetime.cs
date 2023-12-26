using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifetime : MonoBehaviour
{

    public float Lifetime = 3f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(desactivarCartel());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator desactivarCartel()
    {
        yield return new WaitForSeconds(Lifetime);

        gameObject.SetActive(false);
    }
}
