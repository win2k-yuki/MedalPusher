using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {
    public GameObject coin;
    float moveSpeed = 8.0f;

    Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(x, 0, 0);
        rb.velocity = direction * moveSpeed;
        if (Input.GetKeyDown("space"))
        {
            Instantiate(coin, this.transform.position, this.transform.rotation);
        }
	}
}
