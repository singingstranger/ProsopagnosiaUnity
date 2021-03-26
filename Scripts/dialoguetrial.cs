using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* Online resources I used:
 * https://forum.unity.com/threads/initialize-serializefield-audioclip-array-items-in-c-code-with-project-url.681469/
 * https://answers.unity.com/questions/347657/play-audioclip-once-and-switching-clips.html
 * https://gamedevbeginner.com/how-to-play-audio-in-unity-with-examples/#:~:text=Just%20create%20an%20On%20Click,Easy!*/

public class dialoguetrial : MonoBehaviour
{
    public Button b1;
    public Button b2;
    public Button b3;

    public GameObject dialogueObject;
    public Text dialogue;

    bool talking;
    bool listening;
    bool smiling;

    public AudioSource audioSource;
    public AudioClip[] audioClipArray;



    // Start is called before the first frame update
    void Start()
    {
        b1.onClick.AddListener(Neutral);
        b3.onClick.AddListener(Smile);
        b2.onClick.AddListener(Talk);
        audioSource.Stop();
        //PublicText();
        CloseText();
    }

    void Neutral()
    {
        listening = true;
        talking = false;
        smiling = false;
        dialogueObject.SetActive(false);
        audioSource.Stop();
        //CloseText();
    }

    void Smile()
    {
        listening = false;
        talking = false;
        smiling = true;
        dialogueObject.SetActive(true);
        audioSource.Stop();
        PublicText();
    }

    void Talk()
    {
        listening = false;
        talking = true;
        smiling = false;
        dialogueObject.SetActive(true);
        audioSource.Stop();
        PublicText();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Y))
        {
            Neutral();
        }
        if (Input.GetKey(KeyCode.X))
        {
            Talk();
        }
        if (Input.GetKey(KeyCode.C))
        {
            Smile();
        }
    }

    void CloseText()
    {
        dialogueObject.SetActive(false);
    }

    void PublicText()
    {
        Debug.Log("called");
        if (smiling == true)
        {
            dialogue.text = "I'm testing out sounding really happy, because sometimes I might smile.";
            audioSource.clip = audioClipArray[0];
            audioSource.Play();
    }
        else if (talking == true)
        {
            dialogue.text = "I am testing out speaking in a normal tone of voice.";
            audioSource.clip = audioClipArray[1];
            audioSource.Play();
        }
    }
}
//return audioClipArray[Random.Range(0, audioClipArray.Length)];