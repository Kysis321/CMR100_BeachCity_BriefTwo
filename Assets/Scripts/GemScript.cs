using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemScript : MonoBehaviour
{
    public GameObject gemObject; // a reference to the gem itself
    public ParticleSystem ps;
    public float xAngle, yAngle, zAngle; // input for the amount of degrees to use per axis
    private Vector3 posB;
    private Vector3 posA;
    private Vector3 nextPos;
    public float Speed;
    public float ySpeed;

    [SerializeField]
    private Transform gemTransform;
    [SerializeField]
    private Transform gemTop;
    [SerializeField]
    private Transform gemBot;
    [SerializeField]
    private Transform gemSpin;

  






    // Start is called before the first frame update
    void Start()
    {
        posA = gemBot.position;
        posB = gemTop.position;
        nextPos = posB;
    }

    // Update is called once per frame
    void Update() 
    {
        GemMovement();
        
        

    }

    public void GemMovement()
    {
        gemTransform.position = Vector3.MoveTowards(gemTransform.position, nextPos, Speed * Time.deltaTime);
        if (Vector3.Distance(gemTransform.position, nextPos) <= 0.1)
        {
            ChangePos();
        }
    }
    private void ChangePos()
    {
        nextPos = nextPos != posA ? posA : posB;
    }





}
