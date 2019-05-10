using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl
{
    public static CameraControl instance = null;
    public Transform camera;

    private Vector3 cameraOffset = new Vector3(2f, 2f, -5f);
    private Vector3 targetPosition;
    private Quaternion targetRotation;
    private Vector3 mouseInput = Vector3.zero;
    private float damping = 10f;

    private Transform player;
    //private Transform cameraLookTarget;

    private CameraControl()
    { }

    public static CameraControl getInstance(InteractiveObject _player)
    {
        if (instance == null)
            instance = new CameraControl();
        instance.player = _player.transform;
        //instance.cameraLookTarget = _player.transform.GetChild(1);
        return instance;
    }

    public void Move()
    {
        mouseInput.y = Input.GetAxisRaw("Mouse X");
        mouseInput.x = -Input.GetAxisRaw("Mouse Y");

        

        camera.position = player.transform.position + Vector3.up * 1.2f + player.transform.forward;

        camera.eulerAngles += new Vector3(-Input.GetAxisRaw("Mouse Y"), Input.GetAxisRaw("Mouse X"), 0f);
    }
}
