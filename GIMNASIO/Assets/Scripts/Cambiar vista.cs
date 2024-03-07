using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraOnClick : MonoBehaviour
{
    public Camera newCamera; // Referencia a la nueva cámara que se activará al hacer clic en el modelo

    void OnMouseDown()
    {
        // Desactiva la cámara principal actual
        Camera mainCamera = Camera.main;
        if (mainCamera != null)
        {
            mainCamera.gameObject.SetActive(false);
        }

        // Activa la nueva cámara
        if (newCamera != null)
        {
            newCamera.gameObject.SetActive(true);
        }
    }
}
