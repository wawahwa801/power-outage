using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shake : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Camera;
    public Transform start;
    public float move = 0f;
    public float shakeAmount = 0.7f;
    public float decreaseFactor = 1f;
    private bool times = true;
 
    void Update()
    {
        if (move > 0)
        {
            Camera.transform.localPosition = Random.insideUnitSphere * shakeAmount;
            move -= Time.deltaTime * decreaseFactor;
            if (move <= 0)
            {
                Camera.position = start.position;
            }

        }
        else
        {
            move = 0f;
        }
        if (Camera.position == start.position && times == true)
        {
            move = 1f;
            times = false;
        }
    }
}
