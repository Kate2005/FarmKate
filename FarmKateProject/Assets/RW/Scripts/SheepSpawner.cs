using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepSpawner : MonoBehaviour
{
    [SerializeField] private GameObject sheepPrefab;//������ ����
    [SerializeField] private Vector3 spawnPosition;//������� ������
    [SerializeField] private Vector2 xSpawnBounds;//�������(��������� ����� � ���� ���������)

    [SerializeField] private int sheepCount;
    [SerializeField] private float spawnRate;//������� ��������� ����� ������
    [SerializeField] private float waveRate;//������� ����� �������
    [SerializeField] private int sheepCountWaveIncrease;
    private void Start()
    {
        StartCoroutine(Spawn());
    }

    

    private IEnumerator Spawn()
    {
        while(true)
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
        float xRandomPosition = Random.Range(xSpawnBounds.x, xSpawnBounds.y);//����� ��������� ������� �� �
        Vector3 randomSpawnPosition = new Vector3(xRandomPosition, spawnPosition.y, spawnPosition.z);//������������ ����� �������
        Instantiate(sheepPrefab, randomSpawnPosition, sheepPrefab.transform.rotation);
        //new Vector3(Random.Range(xSpawnBounds.x, xSpawnBounds.y), spawnPosition.y, spawnPosition.z)


    }
    
}