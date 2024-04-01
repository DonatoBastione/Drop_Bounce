using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text points;

    // Update is called once per frame
    void Update()
    {
        points.text = Player.score.ToString();
    }
}
