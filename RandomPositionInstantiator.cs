using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPositionInstantiator : MonoBehaviour {


	public void InstantiateObj(GameObject prefab, Vector3 posStart, Vector3 posEnd)
	{
        float x = Random.Range(posStart.x, posEnd.x);
        float y = Random.Range(posStart.y, posEnd.y);
        float z = Random.Range(posStart.z, posEnd.z);
        GameObject obj = Instantiate(prefab, new Vector3(x, y, z), new Quaternion());
        obj.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
