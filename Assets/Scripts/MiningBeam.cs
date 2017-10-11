using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiningBeam : MonoBehaviour {

    public float mineRange;

    private float oreQuantity = 0f;
    private GameObject toMine;
    private Rigidbody toMineRB;

    // Update is called once per frame
    void FixedUpdate () {
        RaycastHit hit;
        Ray miningRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0)) {
            if (Physics.Raycast(miningRay, out hit, mineRange)) {
                toMine = hit.transform.gameObject;
                toMineRB = GetComponent<Rigidbody>();
                oreQuantity += toMineRB.mass;
                GameObject.Destroy(toMine);
                Debug.Log(oreQuantity);
            }
        }
	}
}
