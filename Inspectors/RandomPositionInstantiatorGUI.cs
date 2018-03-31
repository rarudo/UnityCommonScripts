using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RandomPositionInstantiator))]
public class RandomPositionInstantiatorGUI : MonoBehaviour {
	[SerializeField] private GameObject _obj;
	[SerializeField] private Vector3 _posStart;
	[SerializeField] private Vector3 _posEnd;
	// Use this for initialization
	void Start()
	{
		var rpi = GetComponent<RandomPositionInstantiator>();
		rpi.InstantiateObj(_obj,_posStart,_posEnd);
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
