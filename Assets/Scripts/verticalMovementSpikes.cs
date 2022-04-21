using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verticalMovementSpikes : MonoBehaviour
{
    private Vector3 dir = Vector3.up;
    public float speed = 6f;
    private float max;
    private float min;

    public Transform path;
    private float minHeight;
    private float maxHeight;


    void Start()
    {
        minHeight = path.position.y - 3;
        maxHeight = path.position.y;
        min = GetComponent<Renderer>().bounds.size.y / 2 + minHeight;
        max = GetComponent<Renderer>().bounds.size.y / 2 + maxHeight;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);

        if(transform.position.y >= max)
        {
            dir = Vector3.down;
        } else if(transform.position.y <= min)
        {
            dir = Vector3.up;
        }
    }
}
