using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AddTorquer: MonoBehaviour
{
	private Rigidbody _rigidbody;
	[SerializeField]private Vector3 _torque;

	// Use this for initialization
	void Start ()
	{
		_rigidbody = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
		_rigidbody.AddTorque(_torque);
		
	}
}
