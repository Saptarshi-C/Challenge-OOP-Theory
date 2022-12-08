using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InitName : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI nameText;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = "Hello, " + MainManager.Instance.playerName;
    }
}
