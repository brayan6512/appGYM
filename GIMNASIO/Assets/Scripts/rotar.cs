using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectHorizontal : MonoBehaviour
{
    public float rotationSpeed = 5.0f; // Velocidad de rotación
    private bool isRotating = false; // Indica si se está realizando la rotación

    private Vector3 lastMousePosition; // Última posición del mouse

    void Start()
    {
        // Guarda la posición inicial del mouse
        lastMousePosition = Input.mousePosition;
    }

    void Update()
    {
        // Verifica si se hizo clic
        if (Input.GetMouseButtonDown(0))
        {
            // Inicia la rotación
            isRotating = true;
            // Guarda la posición actual del mouse
            lastMousePosition = Input.mousePosition;
        }

        // Verifica si se soltó el clic
        if (Input.GetMouseButtonUp(0))
        {
            // Detiene la rotación
            isRotating = false;
        }

        // Si se está rotando
        if (isRotating)
        {
            // Calcula la diferencia entre la posición actual del mouse y la última posición
            float deltaX = Input.mousePosition.x - lastMousePosition.x;

            // Aplica la rotación basada en la diferencia de posición del mouse
            float rotationY = deltaX * rotationSpeed * Time.deltaTime;

            transform.Rotate(Vector3.up, rotationY, Space.World); // Rotación horizontal (eje Y)

            // Actualiza la última posición del mouse
            lastMousePosition = Input.mousePosition;
        }
    }
}
