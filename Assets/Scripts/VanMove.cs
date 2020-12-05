using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanMove : MonoBehaviour
{
    public GameObject vanImage; // a reference to the icon itself
    [SerializeField]
    public Transform vanEnd;
    [SerializeField]
    public Transform vanStart;
    [SerializeField]
    public Transform parentObject;

    private Vector3 posB;
    private Vector3 posA;
    private Vector3 nextPos;
    public float Speed = 4;
    public AudioSource audioSource;
    public float t;
    public GameObject imageVan;



    // Start is called before the first frame update
    void Start()
    {
  
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void VanMovement()
    {
        Vector3 start = vanStart.position;
        Vector3 end = vanEnd.position;
        vanImage.transform.position = Vector3.MoveTowards(start, Vector3.Lerp(start, end, t), Time.deltaTime);
        
        audioSource.Play();
        

    }



}
