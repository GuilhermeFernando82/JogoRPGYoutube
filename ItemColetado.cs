using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class ItemColetado : Interact {
	public Itens item;
	public CircleCollider2D col;
	public bool  foipego;

	// Use this for initialization
	
	void Start () {
		col.GetComponent<CircleCollider2D>();
		col.radius = raio;
		col.isTrigger = true;
		gameObject.tag = "Item";
	}
	public override void interactM()
	{
		Coleta();
		print("Voce esta quase");
		base.interactM();
		
		
	}
	public void OnTriggerStay2D(Collider2D other) {
		if(other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E)){
			Debug.Log("Pegando "+ item.name);
			foipego = InventoryControll.instance.AdicionaItem(item);
			if(foipego){
				Destroy(gameObject);
			}
		}
	}
	public void Coleta()
	{
		Debug.Log("Pegando "+ item.name);
		foipego = InventoryControll.instance.AdicionaItem(item);
		if(foipego){
			Destroy(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
