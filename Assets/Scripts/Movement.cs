using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    Rigidbody m_Rigidbody;
    public float acceleration = 10f;
    public float steering = 20f;
    public float rampReduction = 0.7f;
    public float speedUp = 0.7f;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        m_Rigidbody.AddForce(0, 0, acceleration, ForceMode.Impulse);
        m_Rigidbody.AddForce(steering * Input.GetAxis("Horizontal"), 0, 0, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision c)
    {
        //Debug.Log(c.gameObject.tag);
        if (c.gameObject.tag == "Ramp")
        {
            m_Rigidbody.velocity = new Vector3(m_Rigidbody.velocity.x, m_Rigidbody.velocity.y, m_Rigidbody.velocity.z * rampReduction);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "speedUp")
        {
            m_Rigidbody.velocity = new Vector3(m_Rigidbody.velocity.x, m_Rigidbody.velocity.y, m_Rigidbody.velocity.z * speedUp);
        }
    }
}
