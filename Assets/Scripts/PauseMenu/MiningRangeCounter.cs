using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiningRangeCounter : MonoBehaviour
{
    GameObject player;
    MiningBeam miningBeam;
    Text miningRangeCounter;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        miningRangeCounter = gameObject.GetComponent<Text>();
    }

    void Update()
    {
        miningBeam = player.GetComponent<MiningBeam>();

        miningRangeCounter.text = "Mining Range = " + miningBeam.mineRange;
    }
}
