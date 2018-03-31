using UnityEngine;

namespace CommonScripts.Inspectors
{
	[RequireComponent(typeof(RandomPositionInstantiator))]
	public class RandomPositionInstantiatorGUI : MonoBehaviour {
		[SerializeField] private GameObject _obj;
		[SerializeField] private Vector3 _posStart;
		[SerializeField] private Vector3 _posEnd;
		// Use this for initialization
		void Start()
		{
			RandomPositionInstantiator.InstantiateObj(_obj,_posStart,_posEnd);
		}

	
		// Update is called once per frame
		void Update () {
		
		}
	}
}
