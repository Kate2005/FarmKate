using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepSpawner : MonoBehaviour
{
    [SerializeField] private List<Transform> spawnPoints;




   [Header("Sheep")]
    [SerializeField] private GameObject sheepPrefab;//префаб овцы
    [SerializeField] private Vector3 spawnPosition;//позиция спауна
    [SerializeField] private Vector2 xSpawnBounds;//границы(рандомная точка в этом диапазоне)

    [SerializeField] private int sheepCount;
    [SerializeField] private float spawnRate;//частота появления между овцами
    [SerializeField] private float waveRate;//частота между волнами
    [SerializeField] private int sheepCountWaveIncrease;

    [SerializeField] private int waveCount;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while(waveCount > 0)
        {
            for (int i = 0; i < sheepCount; i++)
            {
                CreateSheep();//Spawn
                //CreatSheepInSpawnPoints();
                yield return new WaitForSeconds(spawnRate);
            }
            sheepCount *= sheepCountWaveIncrease;
            yield return new WaitForSeconds(waveRate);
            waveCount--;
        }
    }
    private void CreateSheep()
    {
        //22 - -22, 0, 55;
        float xRandomPosition = Random.Range(xSpawnBounds.x, xSpawnBounds.y);//найти рандомную позицию по х
        Vector3 randomSpawnPosition = new Vector3(xRandomPosition, spawnPosition.y, spawnPosition.z);//сформировать новую позицию
        Instantiate(sheepPrefab, randomSpawnPosition, sheepPrefab.transform.rotation);
        //new Vector3(Random.Range(xSpawnBounds.x, xSpawnBounds.y), spawnPosition.y, spawnPosition.z)
    }
 
    
    public void CreatSheepInSpawnPoints()
    {
        int randomPointIndex = Random.Range(0, spawnPoints.Count);
        Instantiate(sheepPrefab, spawnPoints[randomPointIndex].position, sheepPrefab.transform.rotation);
    }    
}
