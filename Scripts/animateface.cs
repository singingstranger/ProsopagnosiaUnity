using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animateface : MonoBehaviour
{
    //starts by serializing the field of the animation frames
    [SerializeField]
    Texture2D[] mytex;

    //n is the mytex you are currently on
    public int n ;

    //timeloop decides how much time is between one frame and the next
    public float timeloop;

    //the renderer that you care about
    public Renderer facerenderer;

    //what emotion should be had right now?
    public int emote;

    public Button neutral;
    public Button talk;
    public Button smile;

    void Start()
    {
        n = 5;
        neutral.onClick.AddListener(Neutral);
        talk.onClick.AddListener(Talk);
        smile.onClick.AddListener(Smile);
    }

    void Neutral()
    {
        emote = 0;
        n = 0;
        ChangeTex();
    }
    void Talk()
    {
        emote = 1;
    }
    void Smile()
    {
        emote = 2;
    }

    void Update()
    {
        if (emote == 0)// 0 means not talking, just neutral listening
        {
            n = 0;
        }
        else if (emote == 1)//1 means neutral talking
        {
            //not... sure how to fix this.  currently 9 is just how many serialized fields there are in the face animation lol
            if (n > 7)
            {
                n = 0;
            }
            timeloop += Time.deltaTime;
            if (timeloop > 0.15f)
            {
                timeloop = 0;
                n += 1;
                ChangeTex();
            }
        }
        else if (emote == 2)//2 means smile talking
        {
            //not... sure how to fix this.  currently 9 is just how many serialized fields there are in the face animation lol
            if (n < 8)
            {
                n = 9;
            }
            if (n > 15)
            {
                n = 9;
            }
            timeloop += Time.deltaTime;
            if (timeloop > 0.15f)
            {
                timeloop = 0;
                n += 1;
                ChangeTex();
            }
        }
        
    }

    void ChangeTex()
    {
        facerenderer.material.mainTexture = mytex[n];
    }
    /*   //A texture object that will output the animation
              private Texture texture;
     //With this Material object, a reference to the game object Material can be stored
     private Material goMaterial;
     //An integer to advance frames
     private int frameCounter = 0;

     //A string that holds the name of the folder which contains the image sequence
     public string folderName;
     //The name of the image sequence
     public string imageSequenceName;
     //The number of frames the animation has
     public int numberOfFrames;

     //The base name of the files of the sequence
     private string baseName;

     void Awake()
     {
         //Get a reference to the Material of the game object this script is attached to
         this.goMaterial = this.GetComponent<Renderer>().material;
         //With the folder name and the sequence name, get the full path of the images (without the numbers)
         this.baseName = this.folderName + "/" + this.imageSequenceName;
     }

     void Start()
     {
         //set the initial frame as the first texture. Load it from the first image on the folder
         texture = (Texture)Resources.Load(baseName + "00", typeof(Texture));
         Debug.Log("loaded first");
     }

     void Update()
     {
         //Start the 'PlayLoop' method as a coroutine with a 0.04 delay
         StartCoroutine("PlayLoop", 0.04f);
         //Set the material's texture to the current value of the frameCounter variable
         goMaterial.mainTexture = this.texture;
     }

     //The following methods return a IEnumerator so they can be yielded:
     //A method to play the animation in a loop
     IEnumerator PlayLoop(float delay)
     {
         //wait for the time defined at the delay parameter
         yield return new WaitForSeconds(delay);

         //advance one frame
         frameCounter = (++frameCounter) % numberOfFrames;

         //load the current frame
         this.texture = (Texture)Resources.Load(baseName + frameCounter.ToString("D5"), typeof(Texture));

         //Stop this coroutine
         StopCoroutine("PlayLoop");
     }

     //A method to play the animation just once
     IEnumerator Play(float delay)
     {
         //wait for the time defined at the delay parameter
         yield return new WaitForSeconds(delay);

         //if it isn't the last frame
         if (frameCounter < numberOfFrames - 1)
         {
             //Advance one frame
             ++frameCounter;

             //load the current frame
             this.texture = (Texture)Resources.Load(baseName + frameCounter.ToString("D5"), typeof(Texture));
         }

         //Stop this coroutine
         StopCoroutine("Play");
}*/
}
