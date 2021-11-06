using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public GameObject bullet;
    public float interval = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ShootPlayerBullet", interval, interval);
    }

    // Update is called once per frame
    private void ShootPlayerBullet()
    {
        if (Input.GetMouseButton(0))
            {
            var offset = new Vector3(2, 0);
            GameObject b = Instantiate(bullet, transform.position + offset, Quaternion.identity);
            Destroy(b, 5);
        }
    }
}
