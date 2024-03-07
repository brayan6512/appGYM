using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectHorizontal : MonoBehaviour
{
    public float rotationSpeed = 5.0f; // Velocidad de rotaci�n
    private bool isRotating = false; // Indica si se est� realizando la rotaci�n

    private Vector3 lastMousePosition; // �ltima posici�n del mouse

    void Start()
    {
        // Guarda la posici�n inicial del mouse
        lastMousePosition = Input.mousePosition;
    }

    void Update()
    {
        // Verifica si se hizo clic
        if (Input.GetMouseButtonDown(0))
        {
            // Inicia la rotaci�n
            isRotating = true;
            // Guarda la posici�n actual del mouse
            lastMousePosition = Input.mousePosition;
        }

        // Verifica si se solt� el clic
        if (Input.GetMouseButtonUp(0))
        {
            // Detiene la rotaci�n
            isRotating = false;
        }

        // Si se est� rotando
        if (isRotating)
        {
            // Calcula la diferencia entre la posici�n actual del mouse y la �ltima posici�n
            float deltaX = Input.mousePosition.x - lastMousePosition.x;

            // Aplica la rotaci�n basada en la diferencia de posici�n del mouse
            float rotationY = deltaX * rotationSpeed * Time.deltaTime;

            transform.Rotate(Vector3.up, rotationY, Space.World); // Rotaci�n horizontal (eje Y)

            // Actualiza la �ltima posici�n del mouse
            lastMousePosition = Input.mousePosition;
        }
    }
}
