using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class featurerandom : MonoBehaviour
{
   /* GameObject face;
    GameObject eyel;
    GameObject eyer;
    GameObject nose;
    GameObject eyebl;
    GameObject eyebr;
    GameObject mouth;*/

    [SerializeField]
    Sprite[] facetextures;
    [SerializeField]
    Sprite[] eyeltextures;
   /* [SerializeField]
    Sprite[] eyertextures;*/
    [SerializeField]
    Sprite[] nosetextures;
    [SerializeField]
    Sprite[] eyebltextures;
    /*[SerializeField]
    Sprite[] eyebrtextures;*/
    [SerializeField]
    Sprite[] mouthtextures;
    [SerializeField]
    Sprite[] skintextures;

    SpriteRenderer facerend;
    SpriteRenderer eyelrend;
    SpriteRenderer eyerrend;
    SpriteRenderer noserend;
    SpriteRenderer eyeblrend;
    SpriteRenderer eyebrrend;
    SpriteRenderer mouthrend;
    SpriteRenderer skinrend;

    int indeyes;
    int indeyebrows;

    int ycopy = 2;
    int xcopy = 1;
    Vector3 locate;
    int copycounter;

    float xf;
    float yf;
    float zf;
    
    public Button randombutton;

    public GameObject rootObj;
    public SpriteRenderer distractionface;
    public GameObject distractiondisc;
    public GameObject facedisc;

    // Start is called before the first frame update
    void Start()
    {
        randombutton = GameObject.Find("Randomizer").GetComponent<Button>();

       /* face = GameObject.Find("face");
        eyel = GameObject.Find("eye l");
        eyer = GameObject.Find("eye r");
        nose = GameObject.Find("nose");
        eyebl = GameObject.Find("eyebrow l");
        eyebr = GameObject.Find("eyebrow r");
        mouth = GameObject.Find("mouth");*/
        
        
        
        //Collect the renders from the scene
        facerend = GameObject.Find("face").GetComponent<SpriteRenderer>();
        eyelrend = GameObject.Find("eye l").GetComponent<SpriteRenderer>();
        eyerrend = GameObject.Find("eye r").GetComponent<SpriteRenderer>();
        noserend = GameObject.Find("nose").GetComponent<SpriteRenderer>();
        eyeblrend = GameObject.Find("eyebrow l").GetComponent<SpriteRenderer>();
        eyebrrend = GameObject.Find("eyebrow r").GetComponent<SpriteRenderer>();
        mouthrend = GameObject.Find("mouth").GetComponent<SpriteRenderer>();
        skinrend = GameObject.Find("skin").GetComponent<SpriteRenderer>();

        int mode = PointCounter.modus;
        if (mode == 0){
            randombutton.onClick.AddListener(Rand);
            Rand();
        }
        if (mode == 1){
            distractionface.enabled = false;
            distractiondisc.SetActive(true);
            facerend.enabled = false;
            facedisc.SetActive(true);
            randombutton.onClick.AddListener(Rand2);
            Rand2();
        }

        
    }
    void Update(){
        if (Input.GetKey(KeyCode.Q)){
            distractionface.enabled = false;
            distractiondisc.SetActive(true);
            facerend.enabled = false;
            facedisc.SetActive(true);
            randombutton.onClick.AddListener(Rand2);
            Rand2();
        }
    }

    void Test(){
        Debug.Log("Change");
        facerend.sprite = facetextures[Random.Range(0,5)];

    }

    void Rand(){
        Debug.Log("Randomise");

//UNDO THIS if you want to have the reload scene counter
        if (copycounter == 1){
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name); 
        }
        //each time you call this function, +1
        if (copycounter % 3 == 0){
            ycopy = 2;
            xcopy += 3;
        }
        else {
            ycopy-=3;
        }
        copycounter += 1; 

        //create random for shrink/growth
        if (xf < 0){
            xf = Random.Range(-0.003f,0.03f);
        }
        else if (xf > 0){
            xf = Random.Range(-0.03f,0.003f);
        }
        else{
            xf = Random.Range(-0.03f,0.03f);
        }

        //create random for rotation
        if (yf < 0f){
            yf = Random.Range(-0.5f,5f);
        }
        else if (xf > 0f){
            yf = Random.Range(-5f,0.5f);
        }
        else{
            yf = Random.Range(-5f,5f);
        }

        zf = Random.Range(-1.0f,1.0f);

        //Randomize the size
        facerend.gameObject.transform.localScale += new Vector3(xf,xf,xf);
        eyelrend.gameObject.transform.localScale -= new Vector3(xf,xf,xf);
        eyerrend.gameObject.transform.localScale -= new Vector3(xf,xf,xf);
        noserend.gameObject.transform.localScale += new Vector3(xf,xf,xf);
        //Randomize the rotation
        eyelrend.gameObject.transform.Rotate(0.0f, 0.0f, yf, Space.Self);
        eyerrend.gameObject.transform.Rotate(0.0f, 0.0f, -yf, Space.Self);
        eyeblrend.gameObject.transform.Rotate (0.0f, 0.0f, -yf, Space.Self);
        eyebrrend.gameObject.transform.Rotate (0.0f, 0.0f, yf, Space.Self);
        
        
        //Randomise the features
        facerend.sprite = facetextures[Random.Range(0,5)];
        eyelrend.sprite = eyeltextures[indeyes];
        eyerrend.sprite = eyeltextures[indeyes];
        eyerrend.flipX = true;
        noserend.sprite = nosetextures[Random.Range(0,5)];
        eyeblrend.sprite = eyebltextures[indeyebrows];
        eyebrrend.sprite = eyebltextures[indeyebrows];
        eyeblrend.flipX = true;
        mouthrend.sprite = mouthtextures[Random.Range(0,5)];
        skinrend.sprite = skintextures[Random.Range(0,5)];

//UNDO THIS MARKING IF YOU WANT TO INSTANTIATE THE COPIES
        /*GameObject duplicate = Instantiate(rootObj);
        duplicate.gameObject.transform.localScale = new Vector3(0.3f,0.3f,0.3f);
        duplicate.gameObject.transform.position = new Vector3(xcopy, ycopy, 0);*/
        //create random int for the eyebrwos and eyes (since they are connected)
        indeyes = Random.Range(0,5);
        indeyebrows = Random.Range(0,5);
    }







    void Rand2(){
        Debug.Log("Randomise");

//UNDO THIS if you want to have the reload scene counter
        if (copycounter == 1){
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name); 
        }
        //each time you call this function, +1
        if (copycounter % 3 == 0){
            ycopy = 2;
            xcopy += 3;
        }
        else {
            ycopy-=3;
        }
        copycounter += 1; 

        //create random for shrink/growth
        if (xf < 0){
            xf = Random.Range(-0.003f,0.03f);
        }
        else if (xf > 0){
            xf = Random.Range(-0.03f,0.003f);
        }
        else{
            xf = Random.Range(-0.03f,0.03f);
        }

        //create random for rotation
        if (yf < 0f){
            yf = Random.Range(-0.5f,5f);
        }
        else if (xf > 0f){
            yf = Random.Range(-5f,0.5f);
        }
        else{
            yf = Random.Range(-5f,5f);
        }

        zf = Random.Range(-1.0f,1.0f);

        //Randomize the size
        //facerend.gameObject.transform.localScale += new Vector3(xf,xf,xf);
        eyelrend.gameObject.transform.localScale -= new Vector3(xf,xf,xf);
        eyerrend.gameObject.transform.localScale -= new Vector3(xf,xf,xf);
        noserend.gameObject.transform.localScale += new Vector3(xf,xf,xf);
        //Randomize the rotation
        eyelrend.gameObject.transform.Rotate(0.0f, 0.0f, yf, Space.Self);
        eyerrend.gameObject.transform.Rotate(0.0f, 0.0f, -yf, Space.Self);
        eyeblrend.gameObject.transform.Rotate (0.0f, 0.0f, -yf, Space.Self);
        eyebrrend.gameObject.transform.Rotate (0.0f, 0.0f, yf, Space.Self);
        
        
        //Randomise the features
        //facerend.sprite = facetextures[Random.Range(0,5)];
        eyelrend.sprite = eyeltextures[indeyes];
        eyerrend.sprite = eyeltextures[indeyes];
        eyerrend.flipX = true;
        noserend.sprite = nosetextures[Random.Range(0,5)];
        eyeblrend.sprite = eyebltextures[indeyebrows];
        eyebrrend.sprite = eyebltextures[indeyebrows];
        eyeblrend.flipX = true;
        mouthrend.sprite = mouthtextures[Random.Range(0,5)];
        skinrend.sprite = skintextures[Random.Range(0,5)];

//UNDO THIS MARKING IF YOU WANT TO INSTANTIATE THE COPIES
        /*GameObject duplicate = Instantiate(rootObj);
        duplicate.gameObject.transform.localScale = new Vector3(0.3f,0.3f,0.3f);
        duplicate.gameObject.transform.position = new Vector3(xcopy, ycopy, 0);*/
        //create random int for the eyebrwos and eyes (since they are connected)
        indeyes = Random.Range(0,5);
        indeyebrows = Random.Range(0,5);
    }
}
