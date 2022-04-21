using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingObstacle : MonoBehaviour
{
    private Vector3 dir = Vector3.right;
    public float speed = 2f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);

        if(transform.position.x >= 2.5)
        {
            dir = Vector3.left;
        } else if(transform.position.x <= -2.5)
        {
            dir = Vector3.right;
        }
    }
}
