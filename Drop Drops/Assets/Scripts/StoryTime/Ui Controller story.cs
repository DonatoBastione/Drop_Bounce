using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class UiControllerstory : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject I_Want;
    private TextScript iWant;
    public GameObject Everything;
    private TextScript every;
    public GameObject I_Wanted;
    private TextScript iWanted;
    public GameObject Refused;
    private TextScript refused;
    public GameObject They_Said;
    private TextScript theySaid;
    public GameObject Confused;
    private TextScript confused;
    public GameObject But_Maybe;
    private TextScript butMaybe;
    public GameObject I_Had_To;
    private TextScript iHadTo;
    public GameObject So_I;
    private TextScript soI;
    public GameObject Land1;
    private TextScript land1;
    public GameObject It_So;
    private TextScript itso;
    public GameObject Land2;
    private TextScript land2;
    public GameObject They_where;
    private TextScript theyWere;
    public GameObject Land3;
    private TextScript land3;
    public GameObject Big_Text;
    private TextScript bigText;
    public GameObject Continu;
    private TextScript continu;
    public GameObject Button;
    private TextScript button;
    public GameObject Continu2;
    private TextScript continu2;
    public GameObject Button2;
    private TextScript button2;

    
    void Start()
    {
        
        iWant = I_Want.GetComponent<TextScript>();
        every = Everything.GetComponent<TextScript>();
        iWanted = I_Wanted.GetComponent<TextScript>();
        refused = Refused.GetComponent<TextScript>();
        theySaid = They_Said.GetComponent<TextScript>();
        confused = Confused.GetComponent<TextScript>();
        butMaybe = But_Maybe.GetComponent<TextScript>();
        iHadTo = I_Had_To.GetComponent<TextScript>();
        soI = So_I.GetComponent<TextScript>();
        land1 = Land1.GetComponent<TextScript>();
        itso = It_So.GetComponent<TextScript>();
        land2 = Land2.GetComponent<TextScript>();
        theyWere = They_where.GetComponent<TextScript>();
        land3 = Land3.GetComponent<TextScript>();
        bigText = Big_Text.GetComponent<TextScript>();
        continu = Continu.GetComponent<TextScript>();
        button = Button.GetComponent<TextScript>();
        continu2 = Continu2.GetComponent<TextScript>();
        button2 = Button2.GetComponent<TextScript>();

        Invoke(nameof(primo), 1);
        
    }

    
    void FadeIn(TextScript text){
        text.fadeIn = true;
    }
    void FadeOut(TextScript text){
        text.fadeOut = true;
    }
    private void primo(){
        FadeIn(iWant);
        Invoke(nameof(secondo), 3);
    }
    private void secondo(){
        FadeIn(every);
        Invoke(nameof(terzo), 3);
    }
    private void terzo(){
        FadeIn(iWanted);
        Invoke(nameof(quarto), 3);
    }
    private void quarto(){
        FadeOut(iWant);
        FadeOut(every);
        FadeOut(iWanted);
        Invoke(nameof(quinto), 4);
    }
    private void quinto(){
        FadeIn(refused);
        Invoke(nameof(sesto), 3);
    }
    private void sesto(){
        FadeIn(theySaid);
        Invoke(nameof(settimo), 3);
    }
    private void settimo(){
        FadeIn(confused);
        Invoke(nameof(ottavo), 4);
    }
    private void ottavo(){
        FadeOut(refused);
        FadeOut(theySaid);
        FadeOut(confused);
        Invoke(nameof(nono), 4);
    }
    private void nono(){
        FadeIn(butMaybe);
        Invoke(nameof(decimo), 3);
    }
    private void decimo(){
        FadeIn(iHadTo);
        Invoke(nameof(undicesimo), 3);
    }
    private void undicesimo(){
        FadeIn(soI);
        Invoke(nameof(dodicesimo), 4);
    }
    private void dodicesimo(){
        FadeOut(butMaybe);
        FadeOut(iHadTo);
        FadeOut(soI);
        FadeIn(land1);
        Invoke(nameof(tredicesimo), 5);
    }
    private void tredicesimo(){
        FadeIn(itso);
        FadeOut(land1);
        Invoke(nameof(quattordicesimo), 3);
    }
    private void quattordicesimo(){
        FadeIn(land2);
        FadeOut(itso);
        Invoke(nameof(quindicesimo), 5);
    }
    private void quindicesimo(){
        FadeIn(theyWere);
        FadeOut(land2);
        Invoke(nameof(sedicesimo), 3);
    }
    private void sedicesimo(){
        FadeIn(land3);
        FadeOut(theyWere);
        Invoke(nameof(diciassettesimo), 5);
    }
    private void diciassettesimo(){
        FadeIn(bigText);
        FadeOut(land3);
        Invoke(nameof(diciottesimo), 6);
    }
    private void diciottesimo(){
        FadeOut(bigText);
        Invoke(nameof(diciannovesimo), 3);
    }
    private void diciannovesimo(){
        FadeIn(continu);
        Button.SetActive(true);
        FadeIn(button);
        Invoke(nameof(ventesimo), 7);
    }
    private void ventesimo(){
        FadeIn(continu2);
        Button2.SetActive(true);
        FadeIn(button2);
    }

}
