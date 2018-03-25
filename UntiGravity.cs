using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class UntiGravity : MonoBehaviour
{
	[SerializeField] private float _untiGravity = 9.8f;
	private Rigidbody _rigidbody;

	// Use this for initialization
	void Start ()
	{
		_rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate() {
		_rigidbody.AddForce(transform.up * _untiGravity);
		
		
	}
}
