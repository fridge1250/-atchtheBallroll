using System.Collections.Generic;
using UnityEngine;

public class PoolBalroll : MonoBehaviour
{
    /*
    [SerializeField] GameObject objectPrefab;
    [SerializeField] private int poolSize = 10;
    [SerializeField] private List<Vector3> spawnPoints;
    [SerializeField] private List<GameObject> objectPool = new List<GameObject>();
    void Start()
    {            
        objectPool = new List<GameObject>();

        // Предварительно создаем объекты и добавляем их в пул
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(objectPrefab, Vector3.zero, Quaternion.identity);
            obj.SetActive(false);
            objectPool.Add(obj);
        }
    } 
    void Update()
    {
        // Определяем условия спавна объектов
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnObject();
        }
    }

    void SpawnObject()
    {
        // Выбираем случайную точку спавна из списка
        int randomIndex = Random.Range(0, spawnPoints.Count);
        Vector3 spawnPosition = spawnPoints[randomIndex];

        // Ищем неактивный объект из пула объектов
        GameObject objToSpawn = objectPool.Find(obj => !obj.activeSelf);

        if (objToSpawn != null)
        {
            // Перемещаем объект на точку спавна и активируем его
            objToSpawn.transform.position = spawnPosition;
            objToSpawn.SetActive(true);
        }
    } 
    */
}
