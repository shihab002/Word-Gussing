using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hint : MonoBehaviour
{
    public Text HintShow = null;
    public void ChangeHint(string word)
    {
        HintShow.text = word;
    }
}
