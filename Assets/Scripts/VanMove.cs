using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanMove : MonoBehaviour
{
    public GameObject vanImage; // a reference to the icon itself
    [SerializeField]
    public Transform vanEnd;
    [SerializeField]
    public Transform vanCarridge;
    [SerializeField]
    public Transform parentObject;
    [SerializeField]
    public Transform vanStartPos;

    public float Speed = 1f;
    public AudioSource audioSource;
    public float t = 1f;
    [SerializeField]
    public Vector3 vanBeginPos;
    [SerializeField]
    public Vector3 vanEndPos;
    public bool helpWanted = false;

    //below for audio related
    public int numberofrepeats = 5;
    public AudioClip mayorDew;
    public float initialDelay = 2;



    // Start is called before the first frame update
    void Start()
    {
  
       

    }

    // Update is called once per frame
    void Update()
    {

        if (helpWanted == true)
        {
            VanMovement();
        }



    }
    public void StateChange()
    {
        helpWanted = true;
        vanCarridge.transform.position = vanStartPos.transform.position;
    }
    public void VanMovement()
    {
        
        vanBeginPos = vanCarridge.transform.position;
        vanEndPos = vanEnd.transform.position;

        

        vanCarridge.transform.position = Vector3.MoveTowards(vanBeginPos, Vector3.Lerp(vanBeginPos, vanEndPos, 10000),Speed *Time.deltaTime);
        


        

    }
    public void DewStart()
    {
        StartCoroutine(DeweyAudio(5));
    }

    IEnumerator DeweyAudio(int times)
    {
        
        for (int i=0; i<times; i++)
        {
            audioSource.PlayOneShot(mayorDew);
            yield return new WaitForSeconds(mayorDew.length);
        }
        helpWanted = false;
        



    }



}
