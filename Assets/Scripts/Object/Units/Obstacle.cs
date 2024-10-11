using System;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void Update()
    {
        if (gameObject.transform.position.y <= -10)
            Destroy(gameObject);
    }
}