using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public ParticleSystem deathParticles;

    Rigidbody m_Rigidbody;
    public float acceleration = 10f;
    public float steering = 20f;
    public float rampReduction = 0.7f;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        m_Rigidbody.AddForce(0, 0, acceleration, ForceMode.Impulse);
        m_Rigidbody.AddForce(steering * Input.GetAxis("Horizontal"), 0, 0, ForceMode.Impulse);
    }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other);

        Instantiate(deathParticles, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Ramp")
        {
            m_Rigidbody.velocity = new Vector3(m_Rigidbody.velocity.x, m_Rigidbody.velocity.y, m_Rigidbody.velocity.z * rampReduction);
        }
            //m_Rigidbody.AddForce(0, 0, -rampReduction, ForceMode.Impulse);
            //m_Rigidbody.velocity.z *= rampReduction;
            //Debug.Log(m_Rigidbody.velocity.z);
    }
}
