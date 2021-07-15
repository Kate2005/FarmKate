using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigSheepSpawner : MonoBehaviour
{
    [Header("BigSheep")]
    [SerializeField] private GameObject sheepPrefab;//префаб овцы
    [SerializeField] private Vector3 spawnPosition;//позиция спауна
    [SerializeField] private Vector3 xSpawnBounds;//границы(рандомная точка в этом диапазоне)

    [SerializeField] private int sheepCount;
    [SerializeField] private float spawnRate;//частота появления между овцами
    [SerializeField] private float waveRate;//частота между волнами
    [SerializeField] private int sheepCountWaveIncrease;

    private void Start()
    {
        StartCoroutine(Spawn());
    }



    private IEnumerator Spawn()
    {
        while (true)
        {
            for (int i = 0; i < sheepCount; i++)
            {
                CreateSheep();//Spawn
                yield return new WaitForSeconds(spawnRate);
            }
            sheepCount *= sheepCountWaveIncrease;
            yield return new WaitForSeconds(waveRate);
        }
    }
    private void CreateSheep()
    {
        //22 - -22, 0, 55;
        float xRandom= Random.Range(0, 3);//найти рандомную позицию по х
        float xRandomPosition = 0;
        if (xRandom == 0)
        {
            xRandomPosition = xSpawnBounds.x;
        }
        else if(xRandom == 1)
        {
            xRandomPosition = xSpawnBounds.y;
        }
        else if (xRandom == 2)
        {
            xRandomPosition = xSpawnBounds.z;
        }


        Vector3 randomSpawnPosition = new Vector3(xRandomPosition, spawnPosition.y, spawnPosition.z);//сформировать новую позицию
        Instantiate(sheepPrefab, randomSpawnPosition, sheepPrefab.transform.rotation);
        //new Vector3(Random.Range(xSpawnBounds.x, xSpawnBounds.y), spawnPosition.y, spawnPosition.z)


    }
}
