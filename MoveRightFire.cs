using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightFire : MonoBehaviour {

	// Use this for initialization
	[SerializeField]
	private Rigidbody2D bala;
	private Vector2 dir;
	private Transform alvo;
	public float vel;
	public GameObject play;
	public float countdown = 0.5f;
	
	// Use this for initialization
	void Start () {
		bala = GetComponent<Rigidbody2D>();
		//alvo = GameObject.FindWithTag("Player").GetComponent<Transform>();
		vel = -4;
	

	}

	// Update is called once per frame
	void FixedUpdate () {
		//transform.position += Vector3.up * 0.3f;
		//transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
		transform.position += Vector3.zero;
		countdown -= Time.deltaTime;
		if(countdown <= 0.0f){
			Destroy (gameObject);
		}
		
		//bala.velocity = dir.normalized * vel;
	}
	private void OnTriggerStay2D(Collider2D col){
		if(col.CompareTag("Player")){
				
			

		}	
	}
}
