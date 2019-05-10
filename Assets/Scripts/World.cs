using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World
{
    public static World instance = null;
    const string PlayerTag = "Player";
    const string CameraTag = "MainCamera";
    const string BoxTag = "Box";
    const string ElfTag = "Elf";
    const string OrcTag = "Orc";
    public TypeOfObject orc;
    public TypeOfObject elf;
    //PlayerControl playerControl;
    //CameraControl cameraControl;

    private List<InteractiveObject> objects = new List<InteractiveObject>();

    private World()
    { }

    public static World getInstance()
    {
        if (instance == null)
            instance = new World();
        return instance;
    }


    

    public void InitializeUnits()
    {
        foreach (var unityObject in GameObject.FindGameObjectsWithTag(ElfTag))
        {
            var tr = unityObject.transform;
            var rb = unityObject.GetComponent<Rigidbody>();
            var unit = elf.Create();
            unit.transform = tr;
            unit.rigidbody = rb;
            rb.velocity = Vector3.forward * 20f;
        }

        foreach (var unityObject in GameObject.FindGameObjectsWithTag(OrcTag))
        {
            var tr = unityObject.transform;
            var rb = unityObject.GetComponent<Rigidbody>();
            var unit = orc.Create();
            unit.transform = tr;
            unit.rigidbody = rb;
            rb.velocity = Vector3.forward * 20f;
        }
    }

    /*public void InitializePlayer()
    {
        var tr = GameObject.FindGameObjectWithTag(PlayerTag).transform;
        var rb = tr.gameObject.GetComponent<Rigidbody>();
        var eh = tr.gameObject.GetComponent<CollisionEventHandler>();
        var player = instance.Create(ObjectType.Elf);
        player.transform = tr;
        player.rigidbody = rb;
        eh.obj = player;
        eh.groundChecker = tr.GetChild(0);
        //player.eventHandler = eh;
        var playerControl = PlayerControl.getInstance(player);

        var cameraControl = CameraControl.getInstance(player);
        cameraControl.camera = GameObject.FindGameObjectWithTag(CameraTag).transform;
        playerControl.camera = cameraControl.camera;
    }*/
}
