using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiningBeam : MonoBehaviour {

    public float mineRange;

    private GameObject toMine;
    private Rigidbody toMineRB;

    private InventoryController playerInventory;

    // Update is called once per frame
    void FixedUpdate () {
        RaycastHit hit;
        Ray miningRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0)) {//if clicking with LMB
            if (Physics.Raycast(miningRay, out hit, mineRange)) {//shoot ray
                toMine = hit.transform.gameObject; //assign collided object
                toMineRB = toMine.GetComponent<Rigidbody>();//get collided objects Rigidbody
                playerInventory = gameObject.GetComponent<InventoryController>();//references the player inventory script
                playerInventory.oreQuantity += toMineRB.mass;//add collided Rigidbodies mass to a counter inside the player inventory
                GameObject.Destroy(toMine);//destroy collided object
            }
        }
	}
}
