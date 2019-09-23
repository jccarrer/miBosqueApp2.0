using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantsController : MonoBehaviour {

    [SerializeField]
    private GameObject[] fruits;
    private BoxCollider2D col;
    float x1, x2;

    void Awake()
    {
        col = GetComponent<BoxCollider2D>();
        x1 = transform.position.x - col.bounds.size.x / 2f;
        x2 = transform.position.x + col.bounds.size.x / 2f;
    }

    // Use this for initialization
    void Start()
    {
        StartCoroutine(SpawnPlants(1f));
    }

    IEnumerator SpawnPlants(float time)
    {
        yield return new WaitForSecondsRealtime(time);


        Vector3 temp = transform.position;
        temp.x = Random.Range(x1, x2);
        Instantiate(fruits[Random.Range(0, fruits.Length)], temp, Quaternion.identity);
        StartCoroutine(SpawnPlants(Random.Range(1f, 2f)));

    }

}

