using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// RigitBodyに力を加える
/// </summary>
public class AddForcer : MonoBehaviour
{
	[SerializeField] private float _power = 10f;
	private Rigidbody _rigidbody;
	

	// Use this for initialization
	void Start ()
	{
		_rigidbody = gameObject.GetComponent<Rigidbody>();


	}

	private void Update()
	{
		transform.position += transform.forward;
	}
}
