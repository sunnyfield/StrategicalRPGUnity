using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl
{
    public static PlayerControl instance = null;

    private InteractiveObject objectToControl;
    private Rigidbody body;
    private Transform transF;
    public Transform camera;
    private Vector3 input = Vector3.zero;

    private bool inputCheck = false;

    private PlayerControl()
    { }

    public static PlayerControl getInstance(InteractiveObject _objectToControl)
    {
        if (instance == null)
            instance = new PlayerControl();
        instance.objectToControl = _objectToControl;
        instance.body = _objectToControl.rigidbody;
        instance.transF = _objectToControl.transform;
        return instance;
    }

    /*public void MoveInput()
    {
        input.x = Input.GetAxis("Horizontal");
        input.z = Input.GetAxis("Vertical");
        

        //move input
        if (input.magnitude != 0 && objectToControl.isGrounded)
        {
            inputCheck = true;
            objectToControl.moveVector = objectToControl.sidemoveSpeed * input.x * transF.right +
                objectToControl.moveSpeed * input.z * transF.forward;
            
        }
        else if(input.magnitude == 0)
        {
            inputCheck = false;
            objectToControl.moveVector.x = 0f;
            objectToControl.moveVector.z = 0f;
            body.velocity = new Vector3(0f, body.velocity.y, 0f);
        }

        //jump
        if (Input.GetButtonDown("Jump") && objectToControl.isGrounded)
            body.AddForce(Vector3.up * objectToControl.jumpForce, ForceMode.VelocityChange);
    }

    public void Move()
    {
        if (inputCheck)
            body.velocity = new Vector3(objectToControl.moveVector.x, body.velocity.y, objectToControl.moveVector.z);

        body.MoveRotation(Quaternion.Euler(0f, camera.eulerAngles.y, 0f));
    }*/

    public void AbilityInput()
    {
        if (Input.GetButtonDown("Fire1"))
        {

        }
    }



    public void SetUnitToControl(InteractiveObject _objectToControl)
    {
        instance.objectToControl = _objectToControl;
    }
}
