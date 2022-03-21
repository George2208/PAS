using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveObjects : MonoBehaviour
{ 
    void OnCollisionExit(Collision col)
    {
        Debug.Log("No longer in contact with " + col.transform.name);
    }
}
