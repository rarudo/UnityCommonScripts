using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPositionInstantiator : MonoBehaviour {
	/// <summary>
	/// 空間内にランダムにオブジェクトを置くメソッド
	/// </summary>
	/// <param name="prefab"></param>
	/// <param name="posStart"></param>
	/// <param name="posEnd"></param>
	public static GameObject InstantiateObj(GameObject prefab, Vector3 posStart, Vector3 posEnd)
	{
        float x = Random.Range(posStart.x, posEnd.x);
        float y = Random.Range(posStart.y, posEnd.y);
        float z = Random.Range(posStart.z, posEnd.z);
        GameObject obj = Instantiate(prefab, new Vector3(x, y, z), new Quaternion());
        obj.SetActive(true);
		return obj;
	}

	public static GameObject InstantiateObj(GameObject prefab, GameObject startObj, GameObject endObj)
	{
		var obj = InstantiateObj(prefab, startObj.transform.position, endObj.transform.position);
		return obj;
	}
	
	// Update is called once per frame
	void Update () {
	}
}
