using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllMaterialChanger : MonoBehaviour
{
	[SerializeField]private Material _material;

	// Use this for initialization
	void Start () {
		var smr = GetComponentsInChildren<Renderer>(true);
		foreach (var renderer in smr)
		{
			int count = renderer.materials.Length;
            Material[] materials = renderer.materials;
			for (int i = 0; i < count; i++)
			{
				materials[i] = _material;
			}
			renderer.materials = materials;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
