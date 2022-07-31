using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flashingText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public Text powerText;

    string flashing = "Power Outage";

    void Update()
    {
        powerText.text = flashing;
    }
}
