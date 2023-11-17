using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] int enemyCount;

    GameObject[] enemyMass;

    private float scale;

    // Start is called before the first frame update
    void Start()
    {
        enemyMass = new GameObject[enemyCount];

        for (int i = 0; i < enemyCount; i++)
        {
            enemyMass[i] = Instantiate(enemy, new Vector3(Random.Range(35, 75), Random.Range(-14, 15), 0), Quaternion.identity);
            enemyMass[i].GetComponent<SpriteRenderer>().color = Random.ColorHSV();

            scale = Random.Range(1f, 1.5f);
            enemyMass[i].transform.localScale = new Vector3(scale, scale, scale);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
