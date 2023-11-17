using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btnDamage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (BulletMove.score >= 10)
        {
            BulletMove.score -= 10;
            EnemyMove.bulletDamage++;
            GameObject.Find("ScoreText").GetComponent<Text>().text = "Score: " + BulletMove.score;
        }
    } 
}