using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasGemScript : MonoBehaviour
{
    public Transform topLeft, topRight, bottomLeft, bottomRight; //reference to all positions of the canvas
    public Transform gemBottomPosition; //a reference to the first gems bottom position to create the gem shards at
    private Vector3 posTL, posTR, posBL, posBR; // 
    private GameObject gem1, gem2, gem3, gem4; //the temp spheres to move to positions
    public GameObject gem;
    public float speed;
    public float timeTaken = 6f;
    public float timeMoved = 0f;


    
    public Transform posStart;






    // Start is called before the first frame update
    void Start()
    {
        posBL = bottomLeft.position;
        posBR = bottomRight.position;
        posTL = topLeft.position;
        posTR = topRight.position;

        CanvasGem();
      

    }

    private void CanvasGem()
    {

        gem1 = Instantiate(gem, gemBottomPosition.position, Quaternion.identity);
        gem2 = Instantiate(gem, gemBottomPosition.position, Quaternion.identity);
        gem3 = Instantiate(gem, gemBottomPosition.position, Quaternion.identity);
        gem4 = Instantiate(gem, gemBottomPosition.position, Quaternion.identity);

        



    }

    private void GemMovment()
    {
        if (timeMoved < 6f)
        {
            timeMoved += Time.deltaTime;
            timeMoved = Mathf.Min(timeMoved, timeTaken);
            gem1.transform.position = Vector3.MoveTowards(transform.position, posTL, timeMoved / timeTaken);
        }
        if (timeMoved < 100f)
        {
            timeMoved += Time.deltaTime;
            timeMoved = Mathf.Min(timeMoved, timeTaken);
            gem2.transform.position = Vector3.MoveTowards(transform.position, posTR, timeMoved / timeTaken);
        }
        if (timeMoved < 3f)
        {
            timeMoved += Time.deltaTime;
            timeMoved = Mathf.Min(timeMoved, timeTaken);
            gem3.transform.position = Vector3.MoveTowards(transform.position, posBL, timeMoved / timeTaken);
        }
        if (timeMoved < 3f)
        {
            timeMoved += Time.deltaTime;
            timeMoved = Mathf.Min(timeMoved, timeTaken);
            gem4.transform.position = Vector3.MoveTowards(transform.position, posBR, timeMoved / timeTaken);
        }
    }




    // Update is called once per frame
    void Update()
    {
        GemMovment();
    }
}
