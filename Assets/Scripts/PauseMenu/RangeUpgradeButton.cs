using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class RangeUpgradeButton : MonoBehaviour {

    GameObject player;
    MiningBeam miningBeam;
    InventoryController playerInventory;
    Button rangeUpgrade;

    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        rangeUpgrade = gameObject.GetComponent<Button>();
    }

    public void UpgradeRange()
    {
        miningBeam = player.GetComponent<MiningBeam>();
        playerInventory = player.GetComponent<InventoryController>();

        if (playerInventory.oreQuantity >= 1)
        {
            miningBeam.mineRange += 1;
            playerInventory.oreQuantity -= 1;
        }
    }
}
