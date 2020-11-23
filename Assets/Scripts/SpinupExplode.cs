using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinupExplode : MonoBehaviour
{

    public GameObject gem;
    public float ySpinSpeed = 2;
    public bool speeding = false;
    private CanvasGemScript cgs;

    // Start is called before the first frame update
    void Start()
    {
        cgs = GetComponent<CanvasGemScript>();
    }

    // Update is called once per frame
    void Update()
    {
        ySpinSpeed = ySpinSpeed + 1F;
        SpeedCheck();

    }
    public void SpeedCheck()
    {
        if (ySpinSpeed < 500)
        {
            speeding = false;
        }
        else
        {
            speeding = true;
            Destroy(gem);
            cgs.enabled = true;
        }
    }
}


