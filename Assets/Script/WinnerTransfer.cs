using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WinnerTransfer : MonoBehaviour
{
    // Start is called before the first frame update
    public Text winText;

    private void Start()
    {
        winText.text = StaticWinner.Winner;
    }
}
