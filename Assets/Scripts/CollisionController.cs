using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public GameObject obstaclesController;
    public GameObject characterMovementController;
    public GameObject Balls;
    // Método llamado cuando este objeto colisiona con otro objeto
    private void OnCollisionEnter(Collision collision)
    {
        // Verificar si el objeto con el que colisionamos tiene la etiqueta "ObjetoB"
        if (collision.gameObject.CompareTag("Balls"))
        {
            obstaclesController.SetActive(true);
            characterMovementController.SetActive(false);
            
        }
    }
}
