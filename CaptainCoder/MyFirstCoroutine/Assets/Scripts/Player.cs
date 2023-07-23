using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	[SerializeField] private Projectile thingToShoot;
	[SerializeField] private float moveSpeed;
	[SerializeField] private float jumpForce;
	private Rigidbody2D _rb;
	private bool _doJump;
	private Vector2 _moveVector;

	public void Awake()
	{
		_rb = this.GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    void Update()
    {
		var moveLeft = IsMoveLeftPressed();
		var moveRight = IsMoveRightPressed();
		_moveVector = Vector2.zero;
		if (moveLeft)
		{
			_moveVector += Vector2.left;
		}
		if (moveRight)
		{ 
			_moveVector += Vector2.right;
		}

		_doJump = _doJump || IsJumpPressed();

	}

	public void FixedUpdate()
	{

		_rb.AddForce(_moveVector * moveSpeed);

		if (_doJump)
		{
			_doJump = false;
			_rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
		}
	}

	private bool IsJumpPressed()
	{
		return Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W);
	}

	private bool IsMoveLeftPressed()
	{
		return Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow);
	}
	private bool IsMoveRightPressed()
	{
		return Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow);
	}
}
