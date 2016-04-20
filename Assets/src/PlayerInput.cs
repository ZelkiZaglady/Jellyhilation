using UnityEngine;
using System.Collections;

//Klasa odpowiedzialna za pobieranie i przetwarzanie informacji z wejścia, dotyczacych postaci gracza

[RequireComponent (typeof (PlayerController))] //wymaga komponentu PlayerController w obiekcie
public class PlayerInput : MonoBehaviour {

    public float moveSpeed = 5f;
    Vector3 moveInput;
    Vector3 moveVelocity;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
	}
}
