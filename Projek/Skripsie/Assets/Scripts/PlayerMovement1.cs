using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement1 : MonoBehaviour
{
    public float speed;
    private Rigidbody2D MyRigidBody;

    private Vector3 change;

    // public Joystick joystick;
    // Start is called before the first frame update
    void Start()
    {
       MyRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;
        change.x = CrossPlatformInputManager.GetAxisRaw("Horizontal");
        change.y = CrossPlatformInputManager.GetAxisRaw("Vertical");
        
        if(change != Vector3.zero)
        {
            MoveCharacter();
        }
    }
    void MoveCharacter()
    {
        MyRigidBody.MovePosition(
            transform.position + change * speed * Time.deltaTime
            );
    }


}
