using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindWaldoMenu : MonoBehaviour
{
    public Button option;
    public Button closer;
    public Button play;
    public GameObject menu;
    public GameObject help;
    public GameObject optionbutton;
    public GameObject closerobject;
    // Start is called before the first frame update
    void Start()
    {
        option.onClick.AddListener(Optionmenu);
        closer.onClick.AddListener(Closehelper);
        play.onClick.AddListener(Startgame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Openmenu(){
        menu.SetActive(true);
    }
    void Optionmenu(){
        option.enabled = false;
        //menu.SetActive(false);
        closer.enabled = true;
        help.SetActive(true);
        closerobject.SetActive(true);
        optionbutton.SetActive(false);

        //Draw.mode=2;
    }
    void Closehelper(){
        closerobject.SetActive(false);
        option.enabled = true;
        closer.enabled = false;
        optionbutton.SetActive(true);
        Openmenu();
    }
    void Startgame(){
        closerobject.SetActive(true);
        Debug.Log("start");
        menu.SetActive(false);
        help.SetActive(false);
        closer.enabled = true;
        //Draw.mode=0;
    }

}

