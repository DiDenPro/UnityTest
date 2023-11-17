using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    static public float timeToShoot = 1.5f;
    GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        bullet = GameObject.Find("Bullet");
        StartCoroutine(Shoot());
    }

    IEnumerator Shoot()
    {
        while (true)
        {
            Instantiate(bullet, new Vector3(-26.3f, 0, 0), Quaternion.identity);
            yield return new WaitForSeconds(timeToShoot);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
