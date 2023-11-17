using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    static public int score = 0;
    static public int totalScore = 0;
    public float speed = 100.0f;

    private GameObject[] compareObjects;
    private float minDistance = Mathf.Infinity;
    private GameObject closestObject = null;

    // Start is called before the first frame update
    void Start()
    {
        compareObjects = GameObject.FindGameObjectsWithTag("EnemyTarget");
    }

    // Update is called once per frame
    void Update()
    {
        minDistance = Mathf.Infinity;
        closestObject = null;

        foreach (GameObject compareObject in compareObjects)
        {
            float distance = Vector3.Distance(transform.position, compareObject.transform.position);

            if (distance < minDistance)
            {
                minDistance = distance;
                closestObject = compareObject;
            }
        }

        Vector3 direction = closestObject.transform.position - transform.position;
        direction.Normalize();
        transform.position += direction * speed * Time.deltaTime;
    }
}
