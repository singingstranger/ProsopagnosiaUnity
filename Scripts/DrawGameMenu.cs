using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawGameMenu : MonoBehaviour
{
    public Button option;
    public GameObject instructions;
    public GameObject closer;
    public GameObject menu;
    public GameObject help;
    // Start is called before the first frame update
    void Start()
    {
        option.onClick.AddListener(MenuInteract);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Openmenu(){
        menu.SetActive(true);
    }
    void MenuInteract(){
        if (this.gameObject.name=="Option1"){
            Debug.Log("start");
            menu.SetActive(false);
            instructions.SetActive(true);
            Draw.mode=0;
        }
        if (this.gameObject.name=="Option2"){
            menu.SetActive(false);
            closer.SetActive(true);
            Draw.mode=2;
        }
        if (this.gameObject.name=="Option3"){
            menu.SetActive(false);
            closer.SetActive(true);
            help.SetActive(true);
            Draw.mode=3;
        }
    }
}
