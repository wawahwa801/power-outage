using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public Transform newSpawn1;
    public Transform newSpawn2;
    public Transform player1;
    public Transform player2;
    public Transform cameraPos;
    public Transform newCamera;
    public Transform spawn;
    public Transform spawn2;
    public GameObject title;
    public GameObject disTitle;
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            player1.position = newSpawn1.position;
            player2.position = newSpawn2.position;
            cameraPos.position = newCamera.position;
            spawn2.position = newSpawn1.position;
            spawn.position = newSpawn2.position;
            title.SetActive(true);
            disTitle.SetActive(false);
        }
    }
}
