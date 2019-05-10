using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ObjectType { Orc, Elf } // for dictionary

public class TypeOfObject : InteractiveObject
{
    public static List<TypeOfObject> types = new List<TypeOfObject>();
    public static List<InteractiveObject> objects = new List<InteractiveObject>();
    public static int idIterator = 0;

    public GameObject prefab = null;
    public string tag = "";

    public float moveSpeed = 0f;
    public float rotateSpeed = 0f;
    public float sidemoveSpeed = 0f;
    public float jumpForce = 0f;
    public float groundCheckRadius = 0f;

    public TypeOfObject()
    {
        types.Add(this);
    }

    public InteractiveObject Create()
    {
        InteractiveObject obj = new InteractiveObject { health = this.health, mana = this.mana };

        objects.Add(obj);
        obj.id = idIterator++;

        return obj;
    }

    public InteractiveObject Create(Vector3 position)
    {
        GameObject newObject;
        InteractiveObject obj = new InteractiveObject { health = this.health, mana = this.mana };
        newObject = Instancer.Spawn(prefab);
        obj.transform = newObject.transform;
        obj.rigidbody = newObject.GetComponent<Rigidbody>();
        obj.transform.position = position;
        obj.targetPosition = position;
        obj.targetPosition = new Vector3(0f, 0f, 100f);
        obj.type = this;

        objects.Add(obj);
        obj.id = idIterator++;

        return obj;
    }

    public void Initialize()
    {
        foreach (var unityObject in GameObject.FindGameObjectsWithTag(tag))
        {
            var tr = unityObject.transform;
            var rb = unityObject.GetComponent<Rigidbody>();
            var unit = this.Create();
            unit.transform = tr;
            unit.rigidbody = rb;
            unit.targetPosition = tr.position;
            unit.targetPosition = new Vector3(0f, 0f, 100f);
            unit.type = this;
        }
    }
}
