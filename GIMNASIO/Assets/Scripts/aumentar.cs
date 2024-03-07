using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinchZoom : MonoBehaviour
{
    public float zoomSpeed = 0.5f; // Velocidad de zoom
    public float minDistance = 46.0f; // Distancia mínima a la cámara
    public float maxDistance = 146.0f; // Distancia máxima a la cámara

    void Update()
    {
        // Si hay dos toques en la pantalla (pinch)
        if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            // Encuentra la magnitud de los vectores de desplazamiento entre los toques
            float prevTouchDeltaMag = (touchZero.position - touchOne.position - (touchZero.deltaPosition - touchOne.deltaPosition)).magnitude;
            float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

            // Encuentra la diferencia entre ellas
            float deltaMagnitudeDiff = touchDeltaMag - prevTouchDeltaMag;

            // Ajusta la posición en Z del objeto basado en su escala actual
            float newDistance = Mathf.Clamp(transform.position.z - deltaMagnitudeDiff * zoomSpeed, minDistance, maxDistance);
            transform.position = new Vector3(transform.position.x, transform.position.y, newDistance);
        }
    }
}
