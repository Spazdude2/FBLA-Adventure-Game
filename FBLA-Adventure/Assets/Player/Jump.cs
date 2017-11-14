using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour 
{
    public float verticalVelocity;

	public float JumpPower = 10;
    public float Gravity = -14;

	CharacterController Player;

	// Use this for initialization
	void Start () 
	{
		Player = this.GetComponent<CharacterController> ();

	}

	// Update is called once per frame
	void Update ()
	{
		if (Player.isGrounded) 
		{
            verticalVelocity = Gravity * Time.deltaTime;
            if (Input.GetButtonDown ("Jump")) 
			{
                verticalVelocity = JumpPower;
			}
		}

        else
        {
            verticalVelocity -= -Gravity * Time.deltaTime;
        }

        Vector3 jump = new Vector3(0, verticalVelocity, 0);
        Player.Move(jump * Time.deltaTime);
	}

}