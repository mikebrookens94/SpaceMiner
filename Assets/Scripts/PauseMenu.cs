using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    bool isPaused = false;

    GameObject player;
    InventoryController playerInventory;
    MiningBeam miningBeam;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerInventory = player.GetComponent<InventoryController>();
        miningBeam = player.GetComponent<MiningBeam>();
    }

    void Update()
    {
        if (Input.GetButtonDown("PauseKey")) {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
        }
        else {
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
        }

    }

    void OnGUI () {
        if (isPaused) {
            GUI.Label(new Rect(25,25,100,30), "Ore = " + playerInventory.oreQuantity);
            GUI.Button(new Rect(25,80,500,30),"Buy Range Upgrade for 1x ore");
            {
                if (playerInventory.oreQuantity >= 1){
                    playerInventory.oreQuantity -= 1;
                    miningBeam.mineRange += 1;
                }
            }
        }
	}
}
