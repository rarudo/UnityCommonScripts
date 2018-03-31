using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
	[SerializeField] private int _countFrom;
	private int _count;

	// Use this for initialization
	void Start ()
	{
		_count = _countFrom;
		StartCoroutine(LoopPerSecond());
	}

	IEnumerator LoopPerSecond()
	{
		while (true)
		{
			_count--;
			yield return new WaitForSecondsRealtime(1);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
