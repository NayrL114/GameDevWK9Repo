using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {    
    
    public Animator moveAnimator;
    
    private Vector3 movement;
    private float movementSqrMagnitude;

    public AsyncLoader aload;// = gameObject.GetComponent<AsyncLoader>();
	
	void Start()
    {
        //aload = gameObject.GetComponent<AsyncLoader>();
    }
    
    void Update () {
        GetMovementInput();
        CharacterRotation();
        WalkingAnimation();
        aload.pos = transform.position;
        //transform.position = aload.pos;
	}


    void GetMovementInput() {
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");
        movement = Vector3.ClampMagnitude(movement, 1.0f);
        //movement.x = Input.GetAxis("Horizontal") * SpeedManager.SpeedModifier;
        //movement.z = Input.GetAxis("Vertical") * SpeedManager.SpeedModifier;
        //movement = Vector3.ClampMagnitude(movement, SpeedManager.SpeedModifier);
        movementSqrMagnitude = movement.sqrMagnitude;
        //Debug.Log(movementSqrMagnitude);
    }


    void CharacterRotation() {
        if (movement != Vector3.zero) {
            transform.rotation = Quaternion.LookRotation(movement, Vector3.up);
        }
    }


    void WalkingAnimation() {
        moveAnimator.SetFloat("MoveSpeed", movementSqrMagnitude);
        moveAnimator.SetFloat("OtherParam", SpeedManager.SpeedModifier);
    }
}
