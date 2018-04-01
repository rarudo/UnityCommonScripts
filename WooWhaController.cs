using System.Collections;
using System.Collections.Generic;
using TouchScript.Gestures;
using UnityEngine;

[RequireComponent(typeof(TapGesture))]
public class WooWhaController :MonoBehaviour, ITouchable{

    //この距離以内だったらタップして反応する
    [SerializeField]
    private float _touchableLengh;

    private GameObject _hideObject;

    // Use this for initialization
    void Start () {
        GetComponent<TapGesture>().Tapped += tappedHandle;
    }

    private void OnDestroy()
    {
        GetComponent<TapGesture>().Tapped -= tappedHandle;
    }

    /// <summary>
    /// 隠れてる対象のオブジェクトをセットする
    /// </summary>
    public void SetHideObject(GameObject obj)
    {
        _hideObject = obj;
    }

    public GameObject GetHidObject()
    {
        if (_hideObject == null)
        {
            Debug.LogError("オブジェクトがセットされてないよ！！");
        }

        return _hideObject;
    }

    void tappedHandle(object sender, System.EventArgs e)
    {
        if (IsTouchableRange())
        {
            Touch();
        }
        else
        {
            print("遠いからタップ判定無し");
        }
    }
	
    // Update is called once per frame
    void Update () {
		
    }

    public bool IsTouchableRange()
    {
        if (Vector3.Distance(Camera.main.transform.position, transform.position) < _touchableLengh)
            return true;
        return false;
    }

    public void Touch()
    {
        print("見つかっちゃったby"+transform.name);
        Destroy(gameObject);
    }
}
