using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideButton : MonoBehaviour
{
    public Text txt;
    public Button starter;
    public Button closer;
    public GameObject button1;
    public GameObject button2;
    public GameObject menu;
    public GameObject help;
    public GameObject memory;
    // Start is called before the first frame update
    void Start()
    {
        starter.onClick.AddListener(GoneButton);
        closer.onClick.AddListener(Gotomenu);
    }
    void GoneButton(){
        button1.SetActive(false);
        button2.SetActive(false);
        Draw.mode=1;
    }
    void Gotomenu(){
        button2.SetActive(false);
        memory.SetActive(false);
        Draw.mode=0;
        help.SetActive(false);
        menu.SetActive(true);
    }
    public void ShowButton(){
        memory.SetActive(true);
        button1.SetActive(false);
        button2.SetActive(true);
    }
}
