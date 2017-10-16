using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OreCounter : MonoBehaviour {
    GameObject player;
    InventoryController playerInventory;
    Text oreCounter;

    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        oreCounter = gameObject.GetComponent<Text>();
    }
	
	void Update () {
        playerInventory = player.GetComponent<InventoryController>();

        oreCounter.text = "Ore Total = " + playerInventory.oreQuantity;
    }
}
