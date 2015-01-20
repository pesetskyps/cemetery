using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject enemy;
    public GameObject player;
    public float spawnOffset = 3;
    public float SpawnDelay = 5;

    int currentEnemyCount;
    int currentWaveNumber = 1;
    Vector3 randomSpawnPoint
    {
        get
        {
            int randindex = Random.Range(0, transform.childCount - 1);
            var position =  Random.insideUnitSphere * spawnOffset + transform.GetChild(randindex).position;
            position.y = 1;
            return position;
        }
    }


	void Start () {
        currentEnemyCount = currentWaveNumber * 5;
        Spawn();
	}

    void Update()
    {
        CheckIfReadySpawn();
    }

    private void CheckIfReadySpawn()
    {
        if (currentEnemyCount <= 0)
        {
            currentWaveNumber++;
            currentEnemyCount = currentWaveNumber * 5;
            Invoke("Spawn", SpawnDelay);
        }
    }

    void EnemyHasDied()
    {
        Debug.Log("died");
        currentEnemyCount--;
    }

    private void Spawn()
    {
        for (int i = 0; i < currentEnemyCount; i++)
        {
            var enemyGameobject = (GameObject)Instantiate(enemy, randomSpawnPoint, Quaternion.identity);

            var hitDamage = enemyGameobject.GetComponent<HitDamage>();
            hitDamage.hasDied = EnemyHasDied;
            SetAITarget(enemyGameobject);
        }
    }

    private void SetAITarget(GameObject enemyGameobject)
    {
        var ai = enemyGameobject.GetComponent<AIFollow>();
        ai.target = player.transform;
    }
	

}
