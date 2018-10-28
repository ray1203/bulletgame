using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITimer : MonoBehaviour {
    public Text timerText;
    public void UpdateTime(int _time)
    {
        timerText.text = _time.ToString();
    }

}
