using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else{
            spawnPipe();
            timer = 0;
        }
    }
    void spawnPipe()
{
    float lowestPoint = transform.position.y - heightOffset;
    float highestPoint = transform.position.y + heightOffset;
    Instantiate(pipe, new UnityEngine.Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
}

}
