using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainrotScritp : MonoBehaviour
{
    public GameObject Gatto;
    private TextScript gatto;
    public GameObject Clown;
    private TextScript clown;
    public GameObject clownMusic;
    public GameObject If_you;
    private TextScript ifYou;
    public GameObject ClownText;
    private TextScript clownText;
    public GameObject If_I_Want;
    private TextScript ifIWant;
    public GameObject Now_if;
    private TextScript nowIf;
    public GameObject Button;
    private TextScript button;
    // Start is called before the first frame update
    void Start()
    {
        clown = Clown.GetComponent<TextScript>();
        gatto = Gatto.GetComponent<TextScript>();
        ifYou = If_you.GetComponent<TextScript>();
        clownText = ClownText.GetComponent<TextScript>();
        ifIWant = If_I_Want.GetComponent<TextScript>();
        nowIf = Now_if.GetComponent<TextScript>();
        button = Button.GetComponent<TextScript>();

        Invoke(nameof(primo), 1);
    }

    void FadeIn(TextScript text){
        text.fadeIn = true;
    }
    void FadeOut(TextScript text){
        text.fadeOut = true;
    }

    private void primo(){
        FadeIn(gatto);
        Invoke(nameof(secondo), 2);
    }
    private void secondo(){
        FadeIn(clown);
        clownMusic.SetActive(true);
        Invoke(nameof(terzo), 5);
    }
    private void terzo(){
        FadeOut(clown);
        FadeOut(gatto);
        Invoke(nameof(quarto), 3);
    }
    private void quarto(){
        FadeIn(ifYou);
        Invoke(nameof(quinto), 3);
    }
    private void quinto(){
        FadeIn(clownText);
        Invoke(nameof(sesto), 3);
    }
    private void sesto(){
        FadeIn(ifIWant);
        Invoke(nameof(settimo), 6);
    }
    private void settimo(){
        FadeOut(ifYou);
        FadeOut(clownText);
        FadeOut(ifIWant);
        Invoke(nameof(ottavo), 3);
    }
    private void ottavo(){
        FadeIn(nowIf);
        Button.SetActive(true);
        FadeIn(button);
    }
}
