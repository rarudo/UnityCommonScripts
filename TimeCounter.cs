using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimeCounter : SingletonMonoBehaviour<TimeCounter>
{
	[SerializeField] private int _countFrom;
	private int _count;
	
	//カウント終了時に呼ばれるイベント
	public UnityEvent OnTimerEnded = new UnityEvent();

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
			if (_count < 0)
				break;
			_count--;
			yield return new WaitForSecondsRealtime(1);
		}
		OnTimerEnded.Invoke();
	}

	public int GetCount()
	{
		return _count;
	}
	
}
