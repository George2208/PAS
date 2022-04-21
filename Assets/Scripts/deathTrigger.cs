using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathTrigger : MonoBehaviour
{
    public ParticleSystem deathParticles;
    public int fallDistance = -30;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.y < fallDistance  + (-20 * Controller.sectionCount) && player != null)
        {
            Instantiate(deathParticles, transform.position, Quaternion.identity);
            Destroy(gameObject);  
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "Obstacle")
        {
            Instantiate(deathParticles, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}