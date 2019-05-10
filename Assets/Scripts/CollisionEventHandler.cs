using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEventHandler : MonoBehaviour
{
    public InteractiveObject obj = null;
    public Transform groundChecker = null;
    public LayerMask Ground;

    private void OnCollisionEnter(Collision collision)
    {
        //obj.isGrounded = Physics.CheckSphere(groundChecker.position, obj.groundCheckRadius, Ground, QueryTriggerInteraction.Ignore);
    }

    private void OnCollisionExit(Collision collision)
    {
        //obj.isGrounded = Physics.CheckSphere(groundChecker.position, obj.groundCheckRadius, Ground, QueryTriggerInteraction.Ignore);
    }
}
