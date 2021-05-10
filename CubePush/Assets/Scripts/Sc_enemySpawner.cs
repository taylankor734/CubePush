using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_enemySpawner : MonoBehaviour
{
    public GameObject redman;

    public float spawntime;
    public float spawn1time;
    public float spawn2time;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", Random.Range(1f, 3f), 1f);
        InvokeRepeating("spawn1", Random.Range(1f, 3f), 1f);
        InvokeRepeating("spawn2", Random.Range(1f, 3f), 1f);
    }
    public void Update()
    {
        if (!GameObject.Find("Box"))
        {
            CancelInvoke("spawn");
        }
        if (!GameObject.Find("Box1"))
        {
            CancelInvoke("spawn1");
        }
        if (!GameObject.Find("Box2"))
        {
            CancelInvoke("spawn2");
        }
    }
    public void spawn()
    {
        Vector3 pos1 = new Vector3(Random.Range(-4.9f, -3.1f), transform.position.y, transform.position.z);
        Instantiate(redman, pos1, Quaternion.identity);
    }
    public void spawn1()
    {
        Vector3 pos2 = new Vector3(Random.Range(-0.9f, 0.9f), transform.position.y, transform.position.z);
        Instantiate(redman, pos2, Quaternion.identity);
    }
    public void spawn2()
    {
        Vector3 pos3 = new Vector3(Random.Range(3.1f, 4.9f), transform.position.y, transform.position.z);
        Instantiate(redman, pos3, Quaternion.identity);
    }
}
