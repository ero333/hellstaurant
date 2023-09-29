using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SLIDERSKINS : MonoBehaviour
{
    private Vector3 puntoInicial;
    private bool arrastrando = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // El usuario ha comenzado a arrastrar el mouse
            puntoInicial = Input.mousePosition;
            arrastrando = true;
        }

        if (arrastrando && Input.GetMouseButton(0))
        {
            // El usuario está arrastrando el mouse
            Vector3 desplazamiento = Input.mousePosition - puntoInicial;
            puntoInicial = Input.mousePosition;

            // Aplicar el desplazamiento a la posición de los elementos dentro del contenedor
            foreach (Transform elemento in transform)
            {
                elemento.Translate(Vector3.right * desplazamiento.x * Time.deltaTime);
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            // El usuario ha dejado de arrastrar el mouse
            arrastrando = false;
        }
    }
}
