using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneration : MonoBehaviour

{
    public GameObject enemy;
    public float interval = 1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("EnemyGenerator", interval, interval);
    }
    private void EnemyGenerator()
    {
        var yAxis = Random.Range(-7.0f, 7.0f);

        var offset = new Vector3(-1, yAxis, 0);
        GameObject e = Instantiate(enemy, transform.position + offset, Quaternion.identity);
        Destroy(e, 15);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
