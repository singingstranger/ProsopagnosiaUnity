using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class dragndrop2 : MonoBehaviour
{
    string thing = "hello"; //the selected item at this time
    bool nose = false;
    bool glasses = false;
    bool eyes = false;
    bool hair = false;
    bool mouth = false;
    //int activeobject = 0;
    GameObject sphere;

    float rotationstandard = 5;
    float growthstandard = 0.05f;
   

    private Vector3 screenPoint;
    private Vector3 offset;

    //COLOR PICKER THINGS
    SpriteRenderer coloringobject;
    GameObject preview;
    public ColorPicker colorPicker;



    // Start is called before the first frame update
    void Start()
    {
        coloringobject = this.gameObject.GetComponent<SpriteRenderer>();
        preview = GameObject.Find("Color preview image");
        
    }

    public void OnColorChanged(Color c)
    {
        coloringobject.color = c;
    }



//UPDATE! KEEP SIMPLE AND SHORT
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //Enhance with selected object being visible somehow
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            // Casts the ray and get the first game object hit
            Physics.Raycast(ray, out hit);
            //Debug.Log("This hit at " + hit.point + " on Object" + hit.transform.name );
            /*if (hit.transform.name == "Color picker"){
                Debug.Log("Color picker");
            }*/
            //if (hit.transform.name != null){}
            
            if (hit.transform.name == gameObject.name ){
                Selection();
                
            }
            else {
                thing = hit.transform.name;
                Deselection();
            }
        }
        if (Input.GetKeyDown(KeyCode.A)||Input.GetKeyDown(KeyCode.LeftArrow)){ //Add a visual click option on screen
            LRotation();
        }
        if (Input.GetKeyDown(KeyCode.D)||Input.GetKeyDown(KeyCode.RightArrow)){ ////Add a visual click option on screen
            RRotation();
        }
        if (Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.UpArrow)){ //Add a visual click option on screen
            Grow();
        }
        if (Input.GetKeyDown(KeyCode.S)||Input.GetKeyDown(KeyCode.DownArrow)){ //Add a visual click option on screen
            Shrink();
        }
        if (Input.GetKeyDown(KeyCode.E)){//Changes color
            ColorChange();
        }
        
    }




//DEFORM PARTS
    void Grow (){ //expand selected object
        if (gameObject.name==thing && gameObject.name!="body"){
            Debug.Log("Plus " + gameObject.name);
            this.gameObject.transform.localScale += new Vector3(growthstandard, growthstandard, growthstandard);
            //Debug.Log(activeobject + " is active");
        }
    }

    void Shrink(){ //shrink selected object
        if (gameObject.name==thing && gameObject.name!="body"){
            Debug.Log("Minus " + gameObject.name);
            this.gameObject.transform.localScale -= new Vector3(growthstandard, growthstandard, growthstandard);
        }
    }

    void LRotation(){ //Rotate to the left
        if (gameObject.name==thing && gameObject.name!="body"){
            Debug.Log("LeftRot " + gameObject.name);
            this.gameObject.transform.Rotate(0.0f, 0.0f, rotationstandard, Space.Self);   
        }
    }
    void RRotation(){ //Rotate to the right
        if (gameObject.name==thing && gameObject.name!="body"){
            Debug.Log("LeftRot " + gameObject.name);
            this.gameObject.transform.Rotate(0.0f, 0.0f, -rotationstandard, Space.Self);   
        }
    }
    void ColorChange(){
        if (gameObject.name==thing ){
            Debug.Log("color change" + gameObject.name);
            /*coloringobject.color = colorPicker.color;
            colorPicker.onColorChanged += OnColorChanged;*/
            this.gameObject.GetComponent<SpriteRenderer>().color = preview.GetComponent<Image>().color;
        }
    }




//SELECT PARTS
    void Selection(){ //change which object is active
        if (gameObject.name == "hair"){ //Hair = 1
            Debug.Log( gameObject.name + "is active");
            hair = true;
            thing = "hair";
            //activeobject=1;
        }
        else if (gameObject.name == "eyes"){ //Eyes = 2
            Debug.Log( gameObject.name + "is active");
            eyes = true;
            thing = "eyes";
            //activeobject=2;
        }
        else if (gameObject.name == "glasses"){ //glasses = 3
            Debug.Log( gameObject.name + "is active");
            glasses = true;
            thing = "glasses";
        }
        else if (gameObject.name == "lips"){ //mouth= 4
            Debug.Log( gameObject.name + "is active");
            mouth = true;
            thing = "lips";
        }
        else if (gameObject.name == "nose"){ //nose= 5
            Debug.Log( gameObject.name + "is active");
            nose = true;
            thing = "nose";
        }
        else if (gameObject.name == "body"){ //body=6
            Debug.Log(gameObject.name + "is active");
            thing = "body";
        }
        else if (gameObject.name == "bangs"){ //bangs=7
            Debug.Log(gameObject.name + "is active");
            thing = "bangs";
        }
    }

    void Deselection(){ //turn off selection when changing
        /*if (gameObject.name == "hair"){
            Debug.Log( gameObject.name + "is inactive");
            hair = false;
        }
        else if (gameObject.name == "eyes"){
            Debug.Log( gameObject.name + "is inactive");
            eyes = false;
        }
        else if (gameObject.name == "glasses"){
            Debug.Log( gameObject.name + "is inactive");
            glasses = false;
        }
        else if (gameObject.name == "mouth"){ //mouth= 4
            Debug.Log( gameObject.name + "is active");
            mouth = false;
        }
        else if (gameObject.name == "nose"){ //nose= 5
            Debug.Log( gameObject.name + "is active");
            nose = false;
        }*/
    }
    



//THIS ACTUALLY MAKES CLICK n DRAG
    void OnMouseDown()
        {
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }
        
    void OnMouseDrag()
    {
        if (gameObject.name!="body"){
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition; 
        }
    }
}
    /*void OnMouseDown(){
        // this object was clicked - do something
        //Destroy (this.gameObject);
        Debug.Log("licked");
        this.gameObject.transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);

    }  */


