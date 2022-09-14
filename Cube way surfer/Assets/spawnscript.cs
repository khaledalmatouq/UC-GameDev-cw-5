using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnscript : MonoBehaviour
{

    public GameObject enemy;
    public float delay;

    public Transform leftSpawn;
    public Transform rightSpawn;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0f, delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        int randomPos = Random.Range(1, 4);
        if(randomPos == 1)
        {
            Instantiate(enemy, leftSpawn);

        }

        else if(randomPos == 2)
        {
            Instantiate(enemy, transform);
        }

        else Instantiate(enemy, rightSpawn);
    }
}
