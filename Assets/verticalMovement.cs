using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verticalMovement : MonoBehaviour
{
    private Vector3 dir = Vector3.up;
    public float speed = 6f;
    private float max;
    private float min;

    public int maxHeight = 4;

    void Start()
    {

        min = (-20 * Controller.sectionCount) + GetComponent<Renderer>().bounds.size.y / 2;
        max = (-20 * Controller.sectionCount) + GetComponent<Renderer>().bounds.size.y / 2 + maxHeight;
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
