using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyfollowplayer : MonoBehaviour
{

    public float movementSpeed = 4;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.LookAt(Player.transform);
        transform.position += transform.forward * movementSpeed * Time.deltaTime;
    }
}
