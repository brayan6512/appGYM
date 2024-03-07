using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraOnClick : MonoBehaviour
{
    public Camera newCamera; // Referencia a la nueva c�mara que se activar� al hacer clic en el modelo

    void OnMouseDown()
    {
        // Desactiva la c�mara principal actual
        Camera mainCamera = Camera.main;
        if (mainCamera != null)
        {
            mainCamera.gameObject.SetActive(false);
        }

        // Activa la nueva c�mara
        if (newCamera != null)
        {
            newCamera.gameObject.SetActive(true);
        }
    }
}
