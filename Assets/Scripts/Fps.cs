using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Fps : MonoBehaviour
{
    public TextMeshProUGUI fpsTxt;
    private float time;
    public float timeInterval = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= timeInterval)
        {
            int frameRate = Mathf.RoundToInt(1 / Time.deltaTime);
            fpsTxt.text = frameRate.ToString() + " FPS";
            time = -timeInterval;
        }
    }
}
