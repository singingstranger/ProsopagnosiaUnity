using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BnWButtons : MonoBehaviour
{
    public Button restart;


    //body subset
    [SerializeField]
    Sprite[] bodtextures;
    
    SpriteRenderer bodrenderer;
    public Button bgbutton;


    public Button bbod1;
    public Button bbod2;
    public Button bbod3;
    public Button bbod4;

    //hair subset
    [SerializeField]
    Sprite[] hairtextures;

    SpriteRenderer hairrenderer;
    public Button hairbutton;

    public Button bhair0;
    public Button bhair1;
    public Button bhair2;
    public Button bhair3;
    public Button bhair4;
    public Button bhair5;
    public Button bhair6;
    

    //eyes subset
    [SerializeField]
    Sprite[] eyetextures;

    SpriteRenderer eyerenderer;
    SpriteRenderer eyerenderer2;
    public Button eyebutton;

    public Button beyes0;
    public Button beyes1;
    public Button beyes2;
    public Button beyes3;

    //glasses subset
    [SerializeField]
    Sprite[] glassestextures;

    SpriteRenderer glassesrenderer;
    public Button glassesbutton;

    public Button bglasses0;
    public Button bglasses1;
    public Button bglasses2;

    //lips subset
    [SerializeField]
    Sprite[] lipstextures;

    SpriteRenderer lipsrenderer;
    public Button lipsbutton;

    public Button blips0;
    public Button blips1;
    public Button blips2;
    public Button blips3;

    //nose subset
    [SerializeField]
    Sprite[] nosetextures;

    SpriteRenderer noserenderer;
    public Button nosebutton;

    public Button bnose0;
    public Button bnose1;
    public Button bnose2;

    //bangs subset
    [SerializeField]
    Sprite[] bangstextures;

    SpriteRenderer bangsrenderer;
    SpriteRenderer bangsrenderer2;
    public Button bangsbutton;

    public Button bbangs0;
    public Button bbangs1;
    public Button bbangs2;



    public GameObject buttonmenu1; //Hair foldout menu
    public GameObject buttonmenu2; //body foldout menu
    public GameObject buttonmenu3; //eyes foldout menu
    public GameObject buttonmenu4; //glasses foldout menu
    public GameObject buttonmenu5; //lips foldout menu
    public GameObject buttonmenu6; //nose foldout menu
    public GameObject buttonmenu7; //bangs foldout menu


   

    // Start is called before the first frame update
    void Start()
    {
        //bgbutton = GameObject.Find("Button Base").GetComponent<Button>();
        restart.onClick.AddListener(Restart);
//call all the renderers so you can change the textures/sprites later
        bodrenderer = GameObject.Find("body").GetComponent<SpriteRenderer>();
        hairrenderer = GameObject.Find("hair").GetComponent<SpriteRenderer>();
        eyerenderer = GameObject.Find("eyes").GetComponent<SpriteRenderer>();
        eyerenderer2 = GameObject.Find("hair").GetComponent<SpriteRenderer>();
        glassesrenderer = GameObject.Find("glasses").GetComponent<SpriteRenderer>();
        lipsrenderer = GameObject.Find("lips").GetComponent<SpriteRenderer>();
        noserenderer = GameObject.Find("nose").GetComponent<SpriteRenderer>();
        bangsrenderer = GameObject.Find("bangs").GetComponent<SpriteRenderer>();
        bangsrenderer2 = GameObject.Find("glasses").GetComponent<SpriteRenderer>();
        

//Disable the folded out menus at game start
        buttonmenu1.SetActive(false);
        buttonmenu2.SetActive(false);
        buttonmenu3.SetActive(false);
        buttonmenu4.SetActive(false);
        buttonmenu5.SetActive(false);
        buttonmenu6.SetActive(false);
        buttonmenu7.SetActive(false);


//Added listeners to open up the folded menus
        //hairbutton.onClick.AddListener(Hair);
        bgbutton.onClick.AddListener(Body);
        eyebutton.onClick.AddListener(Eyes);
        //glassesbutton.onClick.AddListener(Glasses);
        lipsbutton.onClick.AddListener(Lips);
        nosebutton.onClick.AddListener(Nose);
        bangsbutton.onClick.AddListener(Bangs);



//if you click on one of the sub-functions, you get lead to a void that leads to the main change void for the body part
        
    //Body
        bbod1.onClick.AddListener(ButtonBod1);
        bbod2.onClick.AddListener(ButtonBod2);
        bbod3.onClick.AddListener(ButtonBod3);
        bbod4.onClick.AddListener(ButtonBod4);
   /* //HAIR
        bhair0.onClick.AddListener(ButtonHair0);
        bhair1.onClick.AddListener(ButtonHair1);
        bhair2.onClick.AddListener(ButtonHair2);
        bhair3.onClick.AddListener(ButtonHair3);
        bhair4.onClick.AddListener(ButtonHair4);
        bhair5.onClick.AddListener(ButtonHair5);
        bhair6.onClick.AddListener(ButtonHair6);*/
    //EYES
        beyes0.onClick.AddListener(ButtonEyes0);
        beyes1.onClick.AddListener(ButtonEyes1);
        beyes2.onClick.AddListener(ButtonEyes2);
        beyes3.onClick.AddListener(ButtonEyes3);
    /*//GLASSES
        bglasses0.onClick.AddListener(ButtonGlasses0);
        bglasses1.onClick.AddListener(ButtonGlasses1);
        bglasses2.onClick.AddListener(ButtonGlasses2);*/
    //LIPS
        blips0.onClick.AddListener(ButtonLips0);
        blips1.onClick.AddListener(ButtonLips1);
        blips2.onClick.AddListener(ButtonLips2);
        blips3.onClick.AddListener(ButtonLips3);
    //NOSE
        bnose0.onClick.AddListener(ButtonNose0);
        bnose1.onClick.AddListener(ButtonNose1);
        bnose2.onClick.AddListener(ButtonNose2);
    //BANGS
        bbangs0.onClick.AddListener(ButtonBangs0);
        bbangs1.onClick.AddListener(ButtonBangs1);
        bbangs2.onClick.AddListener(ButtonBangs2);
        
    }


//RESTART GAME
    void Restart(){
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name); 
    }


// HERE AREA FOR WHICH MENU IS SHOWING AND WHICH HIDDEN
    void Hair(){
        //Debug.Log ("ya clicked hair");
        //buttonmenu1 = GameObject.Find("hairops");
        buttonmenu1.SetActive(true);
        buttonmenu2.SetActive(false);
        buttonmenu3.SetActive(false);
        buttonmenu4.SetActive(false);
        buttonmenu5.SetActive(false);
        buttonmenu6.SetActive(false);
        buttonmenu7.SetActive(false);
    }
    void Body(){
        buttonmenu1.SetActive(false);
        buttonmenu2.SetActive(true);
        buttonmenu3.SetActive(false);
        buttonmenu4.SetActive(false);
        buttonmenu5.SetActive(false);
        buttonmenu6.SetActive(false);
        buttonmenu7.SetActive(false);
        //Debug.Log ("ya clicked bod");
    }
    void Eyes(){
        Debug.Log("lick eye");
        buttonmenu1.SetActive(false);
        buttonmenu2.SetActive(false);
        buttonmenu3.SetActive(true);
        buttonmenu4.SetActive(false);
        buttonmenu5.SetActive(false);
        buttonmenu6.SetActive(false);
        buttonmenu7.SetActive(false);
        //Debug.Log ("ya clicked eyes");
    }
    void Glasses(){
        buttonmenu1.SetActive(false);
        buttonmenu2.SetActive(false);
        buttonmenu3.SetActive(false);
        buttonmenu4.SetActive(true);
        buttonmenu5.SetActive(false);
        buttonmenu6.SetActive(false);
        buttonmenu7.SetActive(false);
    }
    void Lips(){
        buttonmenu1.SetActive(false);
        buttonmenu2.SetActive(false);
        buttonmenu3.SetActive(false);
        buttonmenu4.SetActive(false);
        buttonmenu5.SetActive(true);
        buttonmenu6.SetActive(false);
        buttonmenu7.SetActive(false);
    }
    void Nose(){
        buttonmenu1.SetActive(false);
        buttonmenu2.SetActive(false);
        buttonmenu3.SetActive(false);
        buttonmenu4.SetActive(false);
        buttonmenu5.SetActive(false);
        buttonmenu6.SetActive(true);
        buttonmenu7.SetActive(false);
    }
    void Bangs(){
        buttonmenu1.SetActive(false);
        buttonmenu2.SetActive(false);
        buttonmenu3.SetActive(false);
        buttonmenu4.SetActive(false);
        buttonmenu5.SetActive(false);
        buttonmenu6.SetActive(false);
        buttonmenu7.SetActive(true);
    }



//BODY
    void ButtonBod1(){
        ButtonBod(0);
    }
    void ButtonBod2(){
        ButtonBod(1);
    }
    void ButtonBod3(){
        ButtonBod(2);
    }
    void ButtonBod4(){
        ButtonBod(3);
    }



//HAIR
    void ButtonHair0(){
        ButtonHair(0);   
    }
    void ButtonHair1(){
        ButtonHair(1);   
    }
    void ButtonHair2(){
        ButtonHair(2);   
    }
    void ButtonHair3(){
        ButtonHair(3);   
    }
    void ButtonHair4(){
        ButtonHair(4);   
    }
    void ButtonHair5(){
        ButtonHair(5);   
    }
    void ButtonHair6(){
        ButtonHair(6);   
    }


// EYES
    void ButtonEyes0(){
        ButtonEyes(0);
    }
    void ButtonEyes1(){
        ButtonEyes(1);
    }
    void ButtonEyes2(){
        ButtonEyes(2);
    }
    void ButtonEyes3(){
        ButtonEyes(3);
    }

//GLASSES
    void ButtonGlasses0(){
        ButtonGlasses(0);
    }
    void ButtonGlasses1(){
        ButtonGlasses(1);
    }
    void ButtonGlasses2(){
        ButtonGlasses(2);
    }

//LIPS
    void ButtonLips0(){
        ButtonLips(0);
    }
    void ButtonLips1(){
        ButtonLips(1);
    }
    void ButtonLips2(){
        ButtonLips(2);
    }
    void ButtonLips3(){
        ButtonLips(3);
    }

//NOSE
    void ButtonNose0(){
        ButtonNose(0);
    }
    void ButtonNose1(){
        ButtonNose(1);
    }
    void ButtonNose2(){
        ButtonNose(2);
    }
//BANGS
    void ButtonBangs0(){
        ButtonBangs(0);
    }
    void ButtonBangs1(){
        ButtonBangs(1);
    }
    void ButtonBangs2(){
        ButtonBangs(2);
    }


//CHANGERS 
//here the actual changing of the main sprite happens
    void ButtonBod(int ind){
        bodrenderer.sprite = bodtextures[ind];
    }
    void ButtonHair(int ind){
       // hairrenderer.sprite = hairtextures[ind];
    }
    void ButtonEyes(int ind){
        eyerenderer.sprite = eyetextures[ind];
        eyerenderer2.sprite = eyetextures[ind];
    }
    void ButtonGlasses(int ind){
       // glassesrenderer.sprite = glassestextures[ind];
    }
    void ButtonLips(int ind){
        lipsrenderer.sprite = lipstextures[ind];
    }
    void ButtonNose(int ind){
        noserenderer.sprite = nosetextures[ind];
    }
    void ButtonBangs(int ind){
        bangsrenderer.sprite = bangstextures[ind];
        bangsrenderer2.sprite = bangstextures[ind];
        bangsrenderer.flipX = true;
    }
}
