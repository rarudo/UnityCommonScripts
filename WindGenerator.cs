using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class WindGenerator : MonoBehaviour
{
	private Rigidbody _rigidbody;
	[SerializeField]private float _force;

	// Use this for initialization
	void Start ()
	{
		_rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate() {
		if (Random.Range(0, 1f) < 20)
		{
			_rigidbody.AddForce(Random.insideUnitSphere * _force);
		}
		
	}
}
