using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIManager : MonoBehaviour
{
    [SerializeField] TMP_Text[] inputText = new TMP_Text[3];
    
    public void SetAnimalsName()
    {
        for (int i = 0; i < inputText.Length; i++)
        {
            DataManager.Instance.animalsNames[i] = inputText[i].text;
        }
    }
    
    public void LoadMainScene()
    {
        SceneManager.LoadScene(1);
    }
}
