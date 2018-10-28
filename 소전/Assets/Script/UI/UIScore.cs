using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIScore : MonoBehaviour {

    public Text scoreText;

	public void UpdateScore(int _score)
    {
        scoreText.text = _score.ToString();
    }

}
