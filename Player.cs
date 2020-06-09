using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
	[SerializeField]
	public Interact foco;
	public Vector2 direcao;
    public float speed;
    public Animator anim;
	private bool atk;
	public GameObject MagiaDown;
	public GameObject MagiaUp;
	public GameObject MagiaLeft;
	public GameObject MagiaRigth;

	private WaitForSeconds tempo = new WaitForSeconds(1.5f);
	public GameObject obj;
	public Transform firepoint;
	private float bulletforce = 5f;
	public float vel = 5;
	private Rigidbody2D rb;
	public bool cima;
	public bool baixo;
	public bool esquerda;
	public bool rgt;
    void Start()
    {
        direcao = Vector2.zero;
        speed = 5;
    }
	IEnumerator Tiro(){
		atk = true;
		obj = Instantiate (MagiaDown, new Vector3(transform.position.x,transform.position.y,transform.position.z), transform.rotation);
		obj.GetComponent<MoveSkillPlayer> ();
		//obj.GetComponent<Rigidbody2D>().velocity = new Vector3(transform.forward * (Vertical * vel)); ;
		print ("Tiro");
		yield return tempo;
		atk = false;


	}
    // Update is called once per frame
    void Update()
    {
        if(direcao.x != 0 || direcao.y != 0){
            animations(direcao);
        }
		else{
            anim.SetLayerWeight(1,0);
        }
		if (baixo) {
			if(Input.GetKeyUp(KeyCode.Space)){
				obj = Instantiate (MagiaDown, transform.position, Quaternion.identity);
				rb = obj.GetComponent<Rigidbody2D>();
				rb.velocity = -transform.forward * vel;

			}
		}
		if (cima) {
			if(Input.GetKeyUp(KeyCode.Space)){
				obj = Instantiate (MagiaUp, transform.position, Quaternion.identity);
				rb = obj.GetComponent<Rigidbody2D>();
				rb.velocity = -transform.forward * vel;

			}
		}
		if (esquerda) {
			if(Input.GetKeyUp(KeyCode.Space)){
				obj = Instantiate (MagiaLeft, transform.position, Quaternion.identity);
				rb = obj.GetComponent<Rigidbody2D>();
				rb.velocity = -transform.forward * vel;

			}
		}
		if (rgt) {
			if(Input.GetKeyUp(KeyCode.Space)){
				obj = Instantiate (MagiaRigth, transform.position, Quaternion.identity);
				rb = obj.GetComponent<Rigidbody2D>();
				rb.velocity = -transform.forward * vel;

			}
		}
		if(Input.GetKeyDown(KeyCode.J)){
			print("Apertou");
			if(foco != null)
			{
				foco.OnFocus();
			}
		}

        inputplayer();
        
        transform.Translate(direcao * speed * Time.deltaTime);
        
    }
    void inputplayer()
    {
		
		direcao = Vector2.zero;   
        if(Input.GetKey(KeyCode.UpArrow)){
            direcao += Vector2.up;
			cima = true ;
			esquerda = false;
			baixo = false;
			rgt = false;

        }
        if(Input.GetKey(KeyCode.DownArrow)){
            direcao += Vector2.down;
			baixo = true;
			esquerda = false;
			cima = false;
			rgt = false;

        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            direcao += Vector2.left;
			esquerda = true;
			baixo = false;
			cima = false;
			rgt = false;

        }
        if(Input.GetKey(KeyCode.RightArrow)){
            direcao += Vector2.right;
			rgt = true;
			esquerda = false;
			baixo = false;
			cima = false;


        }
	

			//if (direcao == Vector2.down) {
				
			//}
    }
    void animations(Vector2 dir){
        anim.SetLayerWeight(1,1);
        anim.SetFloat("x", dir.x); 
        anim.SetFloat("y", dir.y);
    }
	public void OnTriggerEnter2D(Collider2D other) {
		if(other.CompareTag("Item"))
		{
			foco = other.GetComponent<Interact>();
		}
	}
	private void OnTriggerExit2D(Collider2D other) {
		foco = null;
	}
}
