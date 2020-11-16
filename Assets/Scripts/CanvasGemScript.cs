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
    public float t;
    


    
    public Transform posStart;






    // Start is called before the first frame update
    void Start()
    {
   
        CanvasGem();
      

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        GemMovment();
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
        Vector3 a = gem1.transform.position;
        Vector3 b = topLeft.position;
        gem1.transform.position = Vector3.MoveTowards(a, Vector3.Lerp(a, b, t), Time.deltaTime);

        Vector3 c = gem2.transform.position;
        Vector3 d = topRight.position;
        gem2.transform.position = Vector3.MoveTowards(c, Vector3.Lerp(c, d, t), Time.deltaTime);

        Vector3 e = gem3.transform.position;
        Vector3 f = bottomLeft.position;
        gem3.transform.position = Vector3.MoveTowards(e, Vector3.Lerp(e, f, t), Time.deltaTime);

        Vector3 g = gem4.transform.position;
        Vector3 h = bottomRight.position;
        gem4.transform.position = Vector3.MoveTowards(g, Vector3.Lerp(g, h, t), Time.deltaTime);

        //    if (timeMoved < 6f)
        //    {
        //        timeMoved += Time.deltaTime;
        //        timeMoved = Mathf.Min(timeMoved, timeTaken);
        //        gem1.transform.position = Vector3.MoveTowards(transform.position, posTL, timeMoved / timeTaken);
        //    }
        //    if (timeMoved < 100f)
        //    {
        //        timeMoved += Time.deltaTime;
        //        timeMoved = Mathf.Min(timeMoved, timeTaken);
        //        gem2.transform.position = Vector3.MoveTowards(transform.position, posTR, timeMoved / timeTaken);
        //    }
        //    if (timeMoved < 3f)
        //    {
        //        timeMoved += Time.deltaTime;
        //        timeMoved = Mathf.Min(timeMoved, timeTaken);
        //        gem3.transform.position = Vector3.MoveTowards(transform.position, posBL, timeMoved / timeTaken);
        //    }
        //    if (timeMoved < 3f)
        //    {
        //        timeMoved += Time.deltaTime;
        //        timeMoved = Mathf.Min(timeMoved, timeTaken);
        //        gem4.transform.position = Vector3.MoveTowards(transform.position, posBR, timeMoved / timeTaken);
        //    }
    }



}
