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
	public float atk;
	public GameObject caixa;

	// Use this for initialization
	public static Itens instance;

	void Start () {
		
	}
	public virtual void usar(){
				if(this.name == "Potion")
				{
					Sangue.instance.VidaDoPersonagem = 100;
					InventoryControll.instance.RemoveItemPerma (this);
				}else{
					
				}
				if(this.name == "Sword" && Player.instance.SwordOfIce == false){
					Player.instance.SwordOfFire = true;
					atk = 15;
					Sangue.instance.Atk.text = atk.ToString();
					InventoryControll.instance.AdicionaItemP(this);
					InventoryControll.instance.RemoveItemPerma (this);
					
				}else if(Player.instance.SwordOfIce == true && this.name != "Potion"){
						UInventory.instance.caixa.gameObject.SetActive(true);
						UInventory.instance.message.text = "Desequipe a arma principal para equipar outra";
				}
				if(this.name == "SwordOfIce" && Player.instance.SwordOfFire == false){
					Player.instance.SwordOfIce = true;
					atk = 10;
					Sangue.instance.Atk.text = atk.ToString();
					InventoryControll.instance.AdicionaItemP(this);
					InventoryControll.instance.RemoveItemPerma (this);
				}else if(Player.instance.SwordOfFire == true && this.name != "Potion"){
						UInventory.instance.caixa.gameObject.SetActive(true);
						UInventory.instance.message.text = "Desequipe a arma principal para equipar outra";
				}
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
