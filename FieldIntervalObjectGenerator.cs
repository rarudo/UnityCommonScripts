using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldIntervalObjectGenerator : MonoBehaviour
{
	[SerializeField] private GameObject _obj;
	[SerializeField] private Vector3 _posStart;
	[SerializeField] private Vector3 _posEnd;
	[SerializeField] private int _amount;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		for (int i = 0; i < _amount; i++)
		{
            float x = Random.Range(_posStart.x, _posEnd.x);
            float y = Random.Range(_posStart.y, _posEnd.y);
            float z = Random.Range(_posStart.z, _posEnd.z);
			GameObject obj = Instantiate(_obj, new Vector3(x, y, z), new Quaternion());
			obj.SetActive(true);
		}
		
	}
}
