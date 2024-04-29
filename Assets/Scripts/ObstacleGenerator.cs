using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float creationTime, creationRange;
    public int maxObstacles = 9;
    private int obstaclesGenerated = 0;

    void Start()
    {

        InvokeRepeating("RandomGenerator", 0.0f, creationTime);
    }

    void Update()
    {}

    public void RandomGenerator()
    {
        if (obstaclesGenerated >= maxObstacles)
        {
            // Si se alcanza el número máximo de obstáculos, detener la generación
            CancelInvoke("RandomGenerator");
            return;            
        }
        // Generar posiciones aleatorias dentro de los límites del área
        float posXgeneration = Random.Range(-11, -9);
        float posZgeneration = Random.Range(-35, -45);

        // Calcular la posición aleatoria dentro del área
        Vector3 ranPosition = new Vector3(posXgeneration, 0.93f, posZgeneration);

        // Crear el obstáculo en la posición aleatoria
        GameObject newObstacle = Instantiate(obstaclePrefab, ranPosition, Quaternion.identity);

        // Girar el obstáculo 90 grados en el eje Y
        newObstacle.transform.Rotate(0, 90, 0);

        // Cuenta el numero de obstaculos generados
        obstaclesGenerated++;
    }
}
