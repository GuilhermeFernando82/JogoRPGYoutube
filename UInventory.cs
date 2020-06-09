using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UInventory : MonoBehaviour {
	//public InventoryControll inv;
	public float DefalTimeScale = 1;
	// Use this for initialization
	public Transform bag;
	public GameObject InvUI;
	public GameObject Inv;
	public Slot[] slots;
	void Start () {
		InventoryControll.instance.itemAlteradoE += UIMetodo;
		slots = bag.GetComponentsInChildren<Slot>();
		Inv.gameObject.SetActive(false);
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
	}
}
