using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject myPrefab;
    void Start()
    {
        Instantiate(myPrefab, new Vector3(0, 0.5f, 10), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
