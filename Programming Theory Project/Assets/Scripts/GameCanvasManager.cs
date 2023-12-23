using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameCanvasManager : MonoBehaviour
{
    public TextMeshProUGUI playerName;
    // Start is called before the first frame update
    void Start()
    {
        if(GameManager.Instance != null)
        {
            playerName.text = GameManager.Instance.playerName;
        }
    }
}
