
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public static EnemySpawner Instance;
    [Header("Ayarlar")]
    [SerializeField] float minX = -3.5f;
    [SerializeField] float maxX = 3.5f;
    [SerializeField] float sabitY = 12f;
    [SerializeField] int spawnCount;
    [SerializeField] float spawnTime;
    [SerializeField] public bool bittiMi = false;
    



    [Header("Elements")]
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] Transform[] hedefler;
    private int currentSpawned = 0;

    private void Awake()
    {
        Instance = this;
    }

    public void BaslatFNC()
    {
        StartCoroutine(SpawnEnemyRoutine());
        
    }
    IEnumerator SpawnEnemyRoutine()
    {

        while (currentSpawned<spawnCount)
        {
            SpawnEnemy();
            currentSpawned++;
            yield return new WaitForSeconds(spawnTime);  
        }
        bittiMi = true;
    }

    private void SpawnEnemy()
    {
        float rasgeleX = Random.Range(minX, maxX);
        Vector3 spawnerPos = new Vector3(rasgeleX, sabitY, 0);
        GameObject yeniDusman = Instantiate(enemyPrefab, spawnerPos, Quaternion.identity);

        EnemyPosition enemyScript = yeniDusman.GetComponent<EnemyPosition>();
        if (enemyScript != null)
        {
            enemyScript.HedefleriAyarla(hedefler);
        }
    }
    
}
