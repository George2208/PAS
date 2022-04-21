using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verticalMovement : MonoBehaviour
{
    private Vector3 dir = Vector3.up;
    public float speed = 6f;
    private float max;
    private float min;

    public Transform path;

    public float minHeight;
    public float maxHeight;

    void Start()
    {
        minHeight = path.position.y + 0.5f;
        maxHeight = path.position.y + 5;
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
