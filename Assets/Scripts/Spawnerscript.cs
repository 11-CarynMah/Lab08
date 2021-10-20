using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject[] cubeObjects;
    float PositionY;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
       


    }

    void SpawnObjects()
    {
        PositionY = Random.Range(5, -3f);
        int randomIndex = Random.Range(0, cubeObjects.Length);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        Instantiate(cubeObjects[randomIndex], transform.position, transform.rotation);
    }
}
