using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disable2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public Transform camera;
    public Transform place;
    // Update is called once per frame
    void Update()
    {
        if (camera.position == place.position)
        {
            gameObject.SetActive(false);
        }
    }
}
