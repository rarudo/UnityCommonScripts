using System.Collections;
using System.Collections.Generic;
using TouchScript.Gestures;
using UnityEngine;

[RequireComponent(typeof(TapGesture))]
public class WooWhaController :MonoBehaviour, ITouchable{

    //この距離以内だったらタップして反応する
    [SerializeField]
    private float _touchableLengh;

    // Use this for initialization
    void Start () {
        GetComponent<TapGesture>().Tapped += tappedHandle;
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
