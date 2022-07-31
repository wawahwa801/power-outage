using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flash : MonoBehaviour
{
    Text lbl;
    public float flashInTime = 0.5f;
    public float flashDuringTime = 1f;
    public float flashOutTime = 0.5f;
    public float timeChecker = 0;
    private Color color; 
    // Start is called before the first frame update
    void Start()
    {
        lbl = GetComponent<Text>();
        color = lbl.color;
    }

    // Update is called once per frame
    void Update()
    {
        timeChecker += Time.deltaTime;
        if(timeChecker < flashInTime)
        {
            lbl.color = new Color(color.r, color.g, color.b, timeChecker / flashInTime);
        }
        else if (timeChecker < flashInTime + flashDuringTime)
        {
            lbl.color = new Color(color.r, color.g, color.b, 1);
        }
        else if (timeChecker < flashInTime + flashDuringTime + flashOutTime)
        {
            lbl.color = new Color(color.r, color.g, color.b, 1 - (timeChecker - (flashInTime + flashDuringTime)) / flashOutTime);
        }
        else
        {
            timeChecker = 0;
        }
    }
}
