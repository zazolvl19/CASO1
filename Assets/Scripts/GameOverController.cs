using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverController : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI killsText;

    public void Retry()
    {
        LevelManager.Instance.FirstScene();
    }

    void Start()
    {
        killsText.text = StateManager.Instance.getKills();
    }
}
