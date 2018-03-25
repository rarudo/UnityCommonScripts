using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkindMeshRendererGetter : MonoBehaviour {
	List<SkinnedMeshRenderer> _skinnedMeshRenderers = new List<SkinnedMeshRenderer>();

	// Use this for initialization
	private void Awake()
	{
		var smr = GetComponentInChildren<SkinnedMeshRenderer>(true);
		_skinnedMeshRenderers.Add(smr);
	}

	public SkinnedMeshRenderer[] GetSkinnedMeshRendrer()
	{
		return _skinnedMeshRenderers.ToArray();
	}

	// Update is called once per frame
	void Update () {
		
	}
}
