using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PointCounter : MonoBehaviour
{
    int points;
    public Text pointtext;
    public Text dialogue;
    public GameObject start;
    bool needtoactive;
    public static int modus = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)){
            Closetext();
        }
        if (needtoactive == true){
            Opentext(points);
            needtoactive = false;
        }
        if (Input.GetKey(KeyCode.Q)){
            modus = 1;   
        }
    }
    public void Point(int add){
        points += add;
        pointtext.text = "Successes: " + points;
        needtoactive = true;
    }
    void Closetext(){
        start.SetActive(false);
    }
    void Opentext(int progress){
        start.SetActive(true);
        if (progress == 1){
            dialogue.text = "Hey, you did it! Good job! You can hit E to try again.";
        }
        else if (progress == 2){
            dialogue.text = "Keep going! You're doing great, learning the face.";
        }
        else if (progress == 3){
            dialogue.text = "You're doing a good job. How about you take it a step further and hit the reset in the top left?";
        }
        else if (progress == 4){
            dialogue.text = "If you use the button, you can learn a new face.";
        }
        else if (progress == 5){
            dialogue.text = "Keep it up! You're doing great. Always use E to load in faces.";
        }
        else if (progress == 6){
            dialogue.text = "Did you know that matching faces from photographs is a diagnostic tool?";
        }
        else if (progress == 7){
            dialogue.text = "I know right? It's kinda wild.";
        }
        else if (progress == 8){
            dialogue.text = "Some people's brains cannot remember faces correctly.";
        }
        else if (10 > progress && progress > 8){
            if (modus == 0){
                dialogue.text = "If you want a bigger challenge, you can hit Q. Q for Quest.";
            }
            if (modus == 1){
                dialogue.text = "You already found the hard mode! Not bad. Keep it up.";
            }
        }
        if (modus ==1){
            if (progress == 10 ){
                dialogue.text = "Even without the face shape, you can recognise that this is a face.";
            }
            else if (progress == 11){
                dialogue.text = "The human brain is pretty cool huh? You just need two dots and a line.";
            }
            else if (progress == 12){
                dialogue.text = "But that would make for a pretty boring game. 'Find the right line'.";
            }
            else if (progress == 13){
                dialogue.text = "This way, there are enough details to throw you off a little sometimes.";
            }
            else if (progress == 14){
                dialogue.text = "Or maybe this is super easy for you? I know I struggle a little.";
            }
            else if (progress == 15){
                dialogue.text = "I look more at how the extra face is a little higher than the rest.";
            }
            else if (progress == 16){
                dialogue.text = "What features do you use to recognise the odd one out? I rely on the eyebrows.";
            }
            else if (progress == 17){
                dialogue.text = "Fun fact: I don't like to look in people's eyes. It makes me uncomfortable.";
            }
            else if (progress == 18){
                dialogue.text = "The way you memorise faces is second nature to you, personally.";
            }
            else if (progress == 19){
                dialogue.text = "Isn't it weird that other people won't play this the same as you?";
            }
            else if (progress == 20){
                dialogue.text = "Once my sister cut her hair and I didn't recognise her when she got home.";
            }
            else if (progress == 21){
                dialogue.text = "Well, to be fair I never recognised her at school either.";
            }
            else if (progress == 22){
                dialogue.text = "It's a bit scary not to know who people are. It's embarrassing.";
            }
            else if (progress == 23){
                dialogue.text = "Did you know that there is an area of your brain just for recalling faces?";
            }
            else if (progress == 24){
                dialogue.text = "Did you know that the brain is designed to recognise a face in abstraction?";
            }
            else if (progress == 25){
                dialogue.text = "If someone cannot recall faces well, they might be face blind.";
            }
            else if (progress == 26){
                dialogue.text = "Face blindness isn't an eye problem though. Th brain just doesn't retain the information";
            }
            else if (progress == 27){
                dialogue.text = "Face blindness is a memory issue where you cannot properly recognise people.";
            }
            else if (progress == 28){
                dialogue.text = "Prosopagnosia: Greek, Prosopon, 'the face', agnosia, 'to not recognise'.";
            }
            else if (progress == 29){
                dialogue.text = "Facial recognition ability is a spectrum. Some people are bad with faces but aren't face blind.";
            }
            else if (progress == 30){
                dialogue.text = "Face blindness can be acquired (e.g. a brain injury) or congenital.";
            }
            else if (progress == 31){
                dialogue.text = "Here I go babbling. I'll shut up now. Enjoy playing!";
            }
            else if (progress == 32){
                dialogue.text = " ";
            }



            else if (progress == 50){
                dialogue.text = "We never talk about how people recognise other people.";
            }
            else if (progress == 51){
                dialogue.text = "Maybe we should.";
            }
        }
    }
}
