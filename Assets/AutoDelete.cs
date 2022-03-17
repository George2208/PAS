using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDelete : MonoBehaviour
{
    public int destroyDistance = 40;
    private GameObject player;
    void Start()
    {
        player = GameObject.Find("Player");
    }
    void Update()
    {
        if(player.transform.position.z - transform.position.z > destroyDistance) {
            Destroy(gameObject);
            Debug.Log("delete");
        }
    }
}
