using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContentChange : MonoBehaviour
{ 
    public string contentOne; // first text content
    public Sprite contentOneIcon; // first contentIcon
    public string contentTwo; // second text content
    public Sprite contentTwoIcon; // second content icon
    public string contentThree; // second text content
    public Sprite contentThreeIcon; // second content icon

    public Text textComponent; // reference to the textComponent
    public Image imageComponent; // reference to the icon image component

    // Start is called before the first frame update
    void Start()
    {
        ChangeToContentOne();
    }
    
    public void ChangeToContentOne()
    {
        textComponent.text = contentOne; // set our text to our text content
        imageComponent.sprite = contentOneIcon; // set our icon to our content sprite
    }

    public void ChangeToContentTwo()
    {
        textComponent.text = contentTwo; // set our text to our text content
        imageComponent.sprite = contentTwoIcon; // set our icon to our content sprite
    }
    public void ChangeToContentThree()
    {
        textComponent.text = contentThree; // set our text to our text content
        imageComponent.sprite = contentThreeIcon; // set our icon to our content sprite
    }
}
