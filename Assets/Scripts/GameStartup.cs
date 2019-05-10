using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartup : MonoBehaviour
{
    PlayerControl playerControl;
    CameraControl cameraControl;
    World world;
    TypeOfObject orc;
    TypeOfObject elf;


    void OnEnable()
    {
        orc = new TypeOfObject
        {
            prefab = Resources.Load<GameObject>("Prefabs/Orc"),
            tag = "Orc",
            health = 8,
            mana = 1,
            moveSpeed = 8f,
            sidemoveSpeed = 6f,
            rotateSpeed = 2f,
            jumpForce = 20f,
            groundCheckRadius = 0.6f
        };

        elf = new TypeOfObject
        {
            prefab = Resources.Load<GameObject>("Prefabs/Elf"),
            tag = "Elf",
            health = 3,
            mana = 8,
            moveSpeed = 8f,
            sidemoveSpeed = 6f,
            rotateSpeed = 2f,
            jumpForce = 10f,
            groundCheckRadius = 0.6f
        };

        foreach (var type in TypeOfObject.types)
        {
            type.Initialize();
        }
    }

    private void Update()
    {

    }

    private void FixedUpdate()
    {
        Move();
    }

    private void LateUpdate()
    {
        
    }

    private void Move()
    {
        Vector3 direction;
        foreach (var obj in TypeOfObject.objects)
        {
            direction = obj.targetPosition - obj.transform.position;
            direction.y = 0f;
            if(direction.magnitude > 0.2f)
                obj.rigidbody.velocity = direction.normalized * obj.type.moveSpeed;
        }
    }
}
