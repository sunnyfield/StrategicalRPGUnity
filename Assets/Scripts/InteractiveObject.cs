using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InteractiveObject
{
    public int id = 0;
    public TypeOfObject type;
    public Transform transform = null;
    public Rigidbody rigidbody = null;
    public Vector3 targetPosition;
    //public CollisionEventHandler eventHandler = null;
    public int health = 0;
    public int mana = 0;
    public int side = 0;

    public bool isGrounded = false;
    public bool isImmortal = false;
    public bool isInvisible = false;
    public bool isStatic = false;
    public bool isTargetable = false;
    public bool isUsable = false;
    public bool isUncontrolledAI = false;
    public bool isBusy = false;  
}
