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

    public bool isPlay = false;

    public TMP_Text Goldtext;
    public GameObject OptionUI;
    public GameObject OptionBG;

    public List<GameObject> T = new List<GameObject>();

    public List<GameObject> Tower = new List<GameObject>();

    public List<GameObject> Option = new List<GameObject>();

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
        MaxGold = 500;
        PlayerPrefs.SetInt("Goldtext", MaxGold);
        Goldtext.text = MaxGold.ToString();
        isPlay = true;
    }

    public void Pause()
    {
        Time.timeScale = 0;
        isPlay = false;
    }

    public void OptionButton()
    {
        Time.timeScale = 0;
        isPlay = false;
        OptionUI.SetActive(true);
        OptionBG.SetActive(true);
        for(int i = 0;i < 84; i++)
        {
            T[i].GetComponent<Image>().raycastTarget = false;
        }
        for (int i = 0; i < 4; i++)
        {
            Tower[i].GetComponent<Image>().raycastTarget = false;
        }
        for (int i = 0; i < 3; i++)
        {
            Option[i].GetComponent<Image>().raycastTarget = false;
        }

    }

    public void ContinueButton()
    {
        Time.timeScale = 1;
        isPlay = true;
        OptionUI.SetActive(false);
        OptionBG.SetActive(false);
        for (int i = 0; i < 84; i++)
        {
            T[i].GetComponent<Image>().raycastTarget = true;
        }
        for (int z = 0; z < 4; z++)
        {
            Tower[z].GetComponent<Image>().raycastTarget = true;
        }
        for (int i = 0; i < 3; i++)
        {
            Option[i].GetComponent<Image>().raycastTarget = true;
        }
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MoveGold(int Gold)
    {
        MaxGold += Gold;
        Goldtext.text = MaxGold.ToString();
    }
}
