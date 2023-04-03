using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    void Update()
    {
        // Destroying the object right away on update would cause errors
        // Instead, Destroy the game object when it reaches a certain height
        Vector3 pos = transform.position;
        if (pos.y > 10) {
            Destroy(gameObject);
        }
    }
}
