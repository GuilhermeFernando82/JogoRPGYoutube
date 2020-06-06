using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRigth : MonoBehaviour {

	// Use this for initialization
	[SerializeField]
	private Rigidbody2D bala;
	private Vector2 dir;
	private Transform alvo;
	public float vel;
	public GameObject play;
	// Use this for initialization
	void Start () {
		bala = GetComponent<Rigidbody2D>();
		//alvo = GameObject.FindWithTag("Player").GetComponent<Transform>();
		vel = -4;

	}

	// Update is called once per frame
	void FixedUpdate () {
		//transform.position += Vector3.up * 0.3f;

		transform.position += Vector3.right * 0.3f;
		//bala.velocity = dir.normalized * vel;
	}
	private void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Inimigo")){
			Destroy (gameObject);

		}	
	}
}
