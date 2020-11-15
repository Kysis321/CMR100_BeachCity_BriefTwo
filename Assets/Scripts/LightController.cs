using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{

    //lighting
    public Light gemLight;
    public float brightstart = 0.1f;
    //intensity variable
    public bool ChangeIntensity = false;
    public float internsitySpeed = 1.0f;
    public float maxIntensify = 10.0f;
    float startTime;

    // Start is called before the first frame update
    void Start()
    {
        gemLight = GetComponent<Light>();
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (ChangeIntensity)
        {
            gemLight.intensity = Mathf.PingPong(Time.time * internsitySpeed, maxIntensify);
        }

    }
}
