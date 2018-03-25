using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forwarder : MonoBehaviour
{
	[SerializeField] private Vector3 _direction;
	[SerializeField] private float _speed = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position += _direction * _speed;
	}
}
