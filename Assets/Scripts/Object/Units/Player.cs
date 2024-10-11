using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : ControllableObject, IDamagable
{
    protected Rigidbody PlayerRigidbody => playerRigidbody ??= gameObject.GetComponent<Rigidbody>();
    
    private Rigidbody playerRigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    protected override void ProcessMove(Vector3 deltaDirection)
    {
        PlayerRigidbody.velocity = deltaDirection;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Game over");

        if (other.CompareTag("Obstacle"))
            OnDead();
    }

    public void OnDamaged() => throw new NotImplementedException();

    public void OnDead()
    {
        GameDirector.Current.GameOver();
    }
}
