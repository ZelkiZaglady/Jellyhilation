using UnityEngine;
using System.Collections;

//Kontroluje zachowanie sie objektu gracze na scenie

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour {

    Rigidbody playerRigidbody;
    Vector3 moveVelocity;
    public float moveSpeed = 5f;
    

	// Use this for initialization
	void Start ()
    {
        playerRigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Move(Vector3 _moveVelocity)
    {
        moveVelocity = _moveVelocity * moveSpeed;
    }
}
