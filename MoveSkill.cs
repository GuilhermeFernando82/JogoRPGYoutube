using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSkill : MonoBehaviour {
	[SerializeField]
	private Rigidbody2D bala;
	private Vector2 dir;
	private Transform alvo;
	private float vel;
	// Use this for initialization
	void Start () {
		bala = GetComponent<Rigidbody2D>();
		alvo = GameObject.FindWithTag("Player").GetComponent<Transform>();
		vel = 4;
		dir = alvo.position - transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		bala.velocity = dir.normalized * vel;
	}
	private void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			Destroy (gameObject);
			
		}	
	}
		

}
