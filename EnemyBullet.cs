using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public GameObject bullet;
    public float interval = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ShootEnemyBullet", interval, interval);
    }

    // Update is called once per frame
    private void ShootEnemyBullet()
    {
            var offset = new Vector3(-1, 0);
            GameObject b = Instantiate(bullet, transform.position + offset, Quaternion.identity);
            Destroy(b, 10);
        
    }
}
