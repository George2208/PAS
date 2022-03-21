using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject[] myPrefabs;
    public Vector3 position;
    public static int sectionCount = 0;
    void Start()
    {
        Instantiate(myPrefabs[0], position, Quaternion.identity);
    }
    void Update()
    {
        // Debug.Log(transform.position.z);
        // Debug.Log(position.z);
        if(transform.position.z >= position.z) {
            Debug.Log("spawn");
            position.z += 110;
            position.y -= 20;
            Instantiate(myPrefabs[Random.Range(0, myPrefabs.Length)], position, Quaternion.identity);
            sectionCount++;
        }  
    }
}
