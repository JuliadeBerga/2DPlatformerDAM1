using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    PlayerController player;

    public GameObject playerObject;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<PlayerController>();
        playerObject = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        player.Fire();
    }
}
