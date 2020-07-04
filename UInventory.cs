using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UInventory : MonoBehaviour {
	//public InventoryControll inv;
	public float DefalTimeScale = 1;
	// Use this for initialization
	public Transform bag;
	public Transform bag2;
	public GameObject InvUI;
	public GameObject Inv;
	public GameObject Inv2;
	public Slot[] slots;
	public Slot[] slots2;
	public GameObject caixa;
	public Text message;
	public static UInventory instance;
	private void Awake(){
		if (instance == null) {
			instance = this;
		}
	}
	public void closebox(){
		caixa.gameObject.SetActive(false);
	}
	void Start () {
		InventoryControll.instance.itemAlteradoE += UIMetodo;
		slots = bag.GetComponentsInChildren<Slot>();
		slots2 = bag2.GetComponentsInChildren<Slot>();
		Inv.gameObject.SetActive(false);
		Inv2.gameObject.SetActive(false);
		caixa.gameObject.SetActive(false);
	}
	void UIMetodo()
	{
		for (int i = 0; i < slots.Length; i++) 
		{
			if (i < InventoryControll.instance.inventoryItens.Count) {
				slots [i].AdicionaItem (InventoryControll.instance.inventoryItens [i]);
			} else {
				slots [i].LimpaSlot ();
			}
		}
		for (int i2 = 0; i2 < slots2.Length; i2++) 
		{
			if (i2 < InventoryControll.instance.inventoryItensP.Count) {
				slots2 [i2].AdicionaItem (InventoryControll.instance.inventoryItensP [i2]);
			} else {
				slots2 [i2].LimpaSlot ();
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.I)){
			Inv.gameObject.SetActive(!Inv.gameObject.activeSelf);
			

		}
		if (Inv.gameObject.activeSelf) {
			Time.timeScale = 1;
		} else {
			Time.timeScale = DefalTimeScale;
		}
		if(Input.GetKeyUp(KeyCode.P)){
			
			Inv2.gameObject.SetActive(!Inv2.gameObject.activeSelf);

		}
		if (Inv.gameObject.activeSelf) {
			Time.timeScale = 1;
		} else {
			Time.timeScale = DefalTimeScale;
		}
	}
	
}
