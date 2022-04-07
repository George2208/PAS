using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    private Vector3 offset;
    private GameObject player;
    void Start()
    {
        player = GameObject.Find("Player");
        offset = transform.position - player.transform.position;
    }
    void LateUpdate()
    {
        if(player != null)
        {
            transform.position = player.transform.position + offset;
        }
    }
}