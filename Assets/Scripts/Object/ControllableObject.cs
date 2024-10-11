using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ControllableObject : MonoBehaviour
{
    public bool Movable = true;
    
    [SerializeField] 
    private float velocity;

    private Vector3 deltaDirection;

    // Update is called once per frame
    protected virtual void Update()
    {
        if (!Movable)
            return;
        
        // Todo: 컨트롤러 지원
        deltaDirection.x = Input.GetAxisRaw("Horizontal") * velocity;
        deltaDirection.z = Input.GetAxisRaw("Vertical") * velocity;
        
        ProcessMove(deltaDirection);
    }

    protected abstract void ProcessMove(Vector3 deltaDirection);
}
