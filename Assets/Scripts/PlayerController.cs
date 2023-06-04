using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
	[SerializeField] float torqueAmount = 1.0f;

	Rigidbody2D playerRb2D;

    void Start()
    {
        playerRb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
			playerRb2D.AddTorque(torqueAmount);
		else if (Input.GetKey(KeyCode.RightArrow))
			playerRb2D.AddTorque(-torqueAmount);
    }
}
