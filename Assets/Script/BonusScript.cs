using UnityEngine;
using System.Collections;

public class BonusScript : MonoBehaviour {
    //X軸をずらす +5から-5
	// Use this for initialization
    bool PlusEnable = true;
    bool MinusEnable = false;
    Vector3 initPosition;
    Vector3 newPosition;
    float fixedPosition = 0f;
	void Start () {
        initPosition = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (PlusEnable == true)
        {
            fixedPosition += 0.05f;
            if (fixedPosition >= 5)
            {
                PlusEnable = false;
                MinusEnable = true;
            }
        }
        if (MinusEnable == true)
        {
            fixedPosition -= 0.05f;
            if (fixedPosition <= -5)
            {
                PlusEnable = true;
                MinusEnable = false;
            }
        }
        newPosition = new Vector3 (initPosition.x + fixedPosition,
                                   initPosition.y,
                                   initPosition.z);
        this.GetComponent<Rigidbody>().MovePosition(newPosition);
	}
}
