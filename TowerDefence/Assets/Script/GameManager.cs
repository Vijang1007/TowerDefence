using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    private int MaxGold = 0;

    public TMP_Text Goldtext;
    public GameObject OptionUI;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            MaxGold = PlayerPrefs.GetInt("Goldtext");
        }
        else
        {
            Destroy(gameObject);
        }
        
    }
    void Start()
    {
        MaxGold += 500;
        PlayerPrefs.SetInt("Goldtext", MaxGold);
    }

    public void Pause()
    {
       
    }

    public void OptionButton()
    {
        Time.timeScale = 0;

        OptionUI.SetActive(true);
    }

    public void ContinueButton()
    {
        Time.timeScale = 1;

        OptionUI.SetActive(false);
    }

    public void MoveGold(int Gold)
    {
        MaxGold += Gold;
        Goldtext.text = MaxGold.ToString();
    }
}
