using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject objectPrefab; // Objeto que se instanciará
    public float tiempoEntreInstancias = 2f; // Tiempo entre cada instancia
    public Transform[] puntosDeSpawn; // Array de puntos de spawn donde aparecerán los objetos

    private void Start()
    {
        // Llamar al método SpawnObject repetidamente cada 'tiempoEntreInstancias' segundos
        InvokeRepeating("SpawnObject", 0f, tiempoEntreInstancias);
    }

    void SpawnObject()
    {
        // Elegir un punto de spawn aleatorio del array
        Transform puntoDeSpawn = puntosDeSpawn[Random.Range(0, puntosDeSpawn.Length)];

        // Calcular una posición aleatoria dentro del rango del punto de spawn
        Vector3 posicionAleatoria = puntoDeSpawn.position + new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), 0);

        // Instanciar el objeto en la posición aleatoria
        Instantiate(objectPrefab, posicionAleatoria, Quaternion.identity);
    }
}
