using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMove : MonoBehaviour
{
    public Transform target;
    public float speed = 2.5f;
    private int lives = 0;
    static public int bulletDamage = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.position - transform.position;
        direction.Normalize();
        transform.position += direction * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "bullet")
        {
            Destroy(collision.gameObject);
            lives -= bulletDamage;

            if (lives <= 0)
            {
                BulletMove.score++;
                BulletMove.totalScore++;
                GameObject.Find("ScoreText").GetComponent<Text>().text = "Score: " + BulletMove.score;
                transform.position = new Vector3(Random.Range(35, 75), Random.Range(-14, 15), 0);
                lives = BulletMove.totalScore / 20;
            }
        }
    }
}