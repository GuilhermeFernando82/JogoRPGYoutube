using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class Itens : ScriptableObject {
	public string nameItem;
	public Sprite ImgItem;
	public bool IsStack;
	protected int amount = 1;
	public bool canTakeItem;
	public bool teste;
	public int id;
	
	// Use this for initialization
	void Start () {
		
	}
	public virtual void usar(){
		Sangue.instance.VidaDoPersonagem = 100;
		InventoryControll.instance.RemoveItemPerma (this);
	}
	public void RemoveI(){
		InventoryControll.instance.RemoveItem (this);
	}
	/*public void AddItem(int amountToAdd = 1){
		amount += amountToAdd;
	}*/
	
	// Update is called once per frame
	/*void Update () {
		if (Input.GetKeyDown(KeyCode.Alpha1) && canTakeItem){
			teste = true;
			print ("Entrou");
			InventoryControll.instance.AddIten(this);

		}
	}*/
	/*public int GetAmount(){

		return amount;
	}*/
	public void OnTriggerStay2D(Collider2D other){
		if (other.gameObject.CompareTag ("Player")) {
			canTakeItem = true;
		}
	}
	public void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.CompareTag ("Player")) {
			canTakeItem = false;
		}
	}
}
