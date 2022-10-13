using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{

    public GameObject playerprefab;

    // Start is called before the first frame update
    void Start()
    {

        PhotonNetwork.Instantiate(playerprefab.name, new Vector2(0,0), Quaternion.identity);

    }
}
