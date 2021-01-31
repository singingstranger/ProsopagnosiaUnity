using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class dragndrop : MonoBehaviour
{
    string thing = "hello";
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


    // Start is called before the first frame update
    void Start()
    {
        
    }



//UPDATE! KEEP SIMPLE AND SHORT
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2) && gameObject.name==thing){
            Debug.Log("it's working");
        }
        if (Input.GetKeyDown(KeyCode.R)){ //Add a visual click option on screen
            LRotation();
        }
        if (Input.GetKeyDown(KeyCode.T)){ ////Add a visual click option on screen
            RRotation();
        }
        if (Input.GetKeyDown(KeyCode.Y)){ //Add a visual click option on screen
            Grow();
        }
        if (Input.GetKeyDown(KeyCode.X)){ //Add a visual click option on screen
            Shrink();
        }
        if (Input.GetMouseButtonDown(0)) //Enhance with selected object being visible somehow
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            // Casts the ray and get the first game object hit
            Physics.Raycast(ray, out hit);
            Debug.Log("This hit at " + hit.point + " on Object" + hit.transform.name );
            if (hit.transform.name == gameObject.name ){
                Selection();
                
            }
            else {
                Deselection();
               
            }
        }
    }



//DEFORM PARTS
    void Grow (){ //expand selected object
        if (hair==true && this.gameObject.name=="hair"){
            Debug.Log("Plus " + gameObject.name);
            this.gameObject.transform.localScale += new Vector3(growthstandard, growthstandard, growthstandard);
            //Debug.Log(activeobject + " is active");
        }
        else if (eyes==true && this.gameObject.name=="eyes"){
            Debug.Log("Plus " + gameObject.name);
            this.gameObject.transform.localScale += new Vector3(growthstandard, growthstandard, growthstandard);
            //Debug.Log(activeobject + " is active");
        }
        else if (glasses==true && this.gameObject.name=="glasses"){
            Debug.Log("Plus " + gameObject.name);
            this.gameObject.transform.localScale += new Vector3(growthstandard, growthstandard, growthstandard);
            //Debug.Log(activeobject + " is active");
        }
        else if (mouth==true && this.gameObject.name=="mouth"){
            Debug.Log("Plus " + gameObject.name);
            this.gameObject.transform.localScale += new Vector3(growthstandard, growthstandard, growthstandard);
            //Debug.Log(activeobject + " is active");
        }
        else if (nose==true && this.gameObject.name=="nose"){
            Debug.Log("Plus " + gameObject.name);
            this.gameObject.transform.localScale += new Vector3(growthstandard, growthstandard, growthstandard);
            //Debug.Log(activeobject + " is active");
        }
    }

    void Shrink(){ //shrink selected object
        if (hair==true && this.gameObject.name=="hair"){
            Debug.Log("Minus " + gameObject.name);
            this.gameObject.transform.localScale -= new Vector3(growthstandard, growthstandard, growthstandard);
        }
        else if (eyes==true && this.gameObject.name=="eyes"){
            Debug.Log("Minus " + gameObject.name);
            this.gameObject.transform.localScale -= new Vector3(growthstandard, growthstandard, growthstandard);;
        }
        else if (glasses==true && this.gameObject.name=="glasses"){
            Debug.Log("Minus " + gameObject.name);
            this.gameObject.transform.localScale -= new Vector3(growthstandard, growthstandard, growthstandard);;
        }
        else if (mouth==true && this.gameObject.name=="mouth"){
            Debug.Log("Minus " + gameObject.name);
            this.gameObject.transform.localScale -= new Vector3(growthstandard, growthstandard, growthstandard);;
        }
        else if (nose==true && this.gameObject.name=="nose"){
            Debug.Log("Minus " + gameObject.name);
            this.gameObject.transform.localScale -= new Vector3(growthstandard, growthstandard, growthstandard);;
        }
    }

    void LRotation(){ //Rotate to the left
        if (hair==true && this.gameObject.name=="hair"){
            Debug.Log("LeftRot " + gameObject.name);
            this.gameObject.transform.Rotate(0.0f, 0.0f, rotationstandard, Space.Self);   
        }
        else if (eyes==true && this.gameObject.name=="eyes"){
            Debug.Log("LeftRot " + gameObject.name);
            this.gameObject.transform.Rotate(0.0f, 0.0f, rotationstandard, Space.Self);
        }
        else if (glasses==true && this.gameObject.name=="glasses"){
            Debug.Log("LeftRot " + gameObject.name);
            this.gameObject.transform.Rotate(0.0f, 0.0f, rotationstandard, Space.Self);
        }
        else if (mouth==true && this.gameObject.name=="mouth"){
            Debug.Log("LeftRot " + gameObject.name);
            this.gameObject.transform.Rotate(0.0f, 0.0f, rotationstandard, Space.Self);
        }
        else if (nose==true && this.gameObject.name=="nose"){
            Debug.Log("LeftRot " + gameObject.name);
            this.gameObject.transform.Rotate(0.0f, 0.0f, rotationstandard, Space.Self);
        }
    }
    void RRotation(){ //Rotate to the right
        if (hair==true && this.gameObject.name=="hair"){
            Debug.Log("LeftRot " + gameObject.name);
            this.gameObject.transform.Rotate(0.0f, 0.0f, -rotationstandard, Space.Self);   
        }
        else if (eyes==true && this.gameObject.name=="eyes"){
            Debug.Log("LeftRot " + gameObject.name);
            this.gameObject.transform.Rotate(0.0f, 0.0f, -rotationstandard, Space.Self);
        }
        else if (glasses==true && this.gameObject.name=="glasses"){
            Debug.Log("LeftRot " + gameObject.name);
            this.gameObject.transform.Rotate(0.0f, 0.0f, -rotationstandard, Space.Self);
        }
        else if (mouth==true && this.gameObject.name=="mouth"){
            Debug.Log("LeftRot " + gameObject.name);
            this.gameObject.transform.Rotate(0.0f, 0.0f, -rotationstandard, Space.Self);
        }
        else if (nose==true && this.gameObject.name=="nose"){
            Debug.Log("LeftRot " + gameObject.name);
            this.gameObject.transform.Rotate(0.0f, 0.0f, -rotationstandard, Space.Self);
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
            //activeobject=2;
        }
        else if (gameObject.name == "glasses"){ //glasses = 3
            Debug.Log( gameObject.name + "is active");
            glasses = true;
        }
        else if (gameObject.name == "mouth"){ //mouth= 4
            Debug.Log( gameObject.name + "is active");
            mouth = true;
        }
        else if (gameObject.name == "nose"){ //nose= 5
            Debug.Log( gameObject.name + "is active");
            nose = true;
        }
    }

    void Deselection(){ //turn off selection when changing
        if (gameObject.name == "hair"){
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
        }
    }
    



//THIS ACTUALLY MAKES CLICK n DRAG
    void OnMouseDown()
        {
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }
        
    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
    
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition; 
    }
}
    /*void OnMouseDown(){
        // this object was clicked - do something
        //Destroy (this.gameObject);
        Debug.Log("licked");
        this.gameObject.transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);

    }  */


