using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    enum SpawnerType { Straight, Spin }

    [Header("Bullet Attributes")]
    public float bulletLife = 1f;
    public float speed = 1.5f; // velocidad

    public List<GameObject> bulletPrefabs = new List<GameObject>(); // Lista de prefabs de balas

    [Header("Spawner Attributes")]
    [SerializeField] private SpawnerType spawnerType;
    [SerializeField] private float firingRate = 1f; // cada cuanto tiempo spawnean las balas


    public float tiempoParaActualizar = 1.0f; // El tiempo en segundos entre actualizaciones
    private float contadorDeSegundos = 0.0f;


    private float timer = 0f;
    private int currentPrefabIndex = 0; // Índice actual en la lista de prefabs




    // Update is called once per frame
    void Update()
    {
        // Aumentar el contador de segundos
        contadorDeSegundos += Time.deltaTime;

        // Comprobar si ha pasado el tiempo deseado
        if (contadorDeSegundos >= tiempoParaActualizar)
        {
            Fire();

            // Reiniciar el contador de segundos
            contadorDeSegundos = 0.0f;
        }
            if (spawnerType == SpawnerType.Spin) transform.eulerAngles = new Vector3(0f, 0f, transform.eulerAngles.z + 1f);

        //if (timer >= firingRate)
        //{
        //    Fire();
        //    timer = 0;
        //}
    }

    public void Fire()
    {
        // Verifica que haya al menos un prefab de bala en la lista
        if (bulletPrefabs.Count > 0)
        {
            // Selecciona el prefab de bala actual y lo instancia
            GameObject currentBulletPrefab = bulletPrefabs[currentPrefabIndex];
            GameObject spawnedBullet = Instantiate(currentBulletPrefab, transform.position, Quaternion.identity);
            spawnedBullet.GetComponent<Bullet>().speed = speed;
            spawnedBullet.GetComponent<Bullet>().bulletLife = bulletLife;
            spawnedBullet.transform.rotation = transform.rotation;

            // Avanza al siguiente prefab de bala en la lista 
            currentPrefabIndex = (currentPrefabIndex + 1) % bulletPrefabs.Count;
        }
    }
}



