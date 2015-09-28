using UnityEngine;
using System.Collections;

public class PusherScript : MonoBehaviour {
    //Z軸プラス方向でプッシャーを引っ込める
	// Use this for initialization
    Vector3 initPosition;
    Vector3 newPosition;
	void Start () {
        initPosition = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        newPosition = new Vector3(initPosition.x,
                                   initPosition.y,
                                   initPosition.z + Mathf.Sin(Time.time)*2);
        this.GetComponent<Rigidbody>().MovePosition(newPosition);
	}
}
