using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    public Transform enemy;
    public Transform Player;
    public Transform spawn;
    public Transform spawn2;
    // Update is called once per frame
    void Update()
    {
        transform.position = enemy.position;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            enemy.position = spawn.position;
            Player.position = spawn2.position;
        }
    }
}
