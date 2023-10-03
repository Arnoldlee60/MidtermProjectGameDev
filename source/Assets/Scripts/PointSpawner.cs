using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSpawner : MonoBehaviour
{
    public GameObject pointPrefab;
    public float respawnTime = 1.0f;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(pointWave());
    }

    private void spawnEnemy(){
        GameObject a = Instantiate(pointPrefab) as GameObject; 
        a.transform.position = new Vector2(Random.Range(minX, maxX), maxY);
    }

    // Update is called once per frame
    IEnumerator pointWave(){
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}
