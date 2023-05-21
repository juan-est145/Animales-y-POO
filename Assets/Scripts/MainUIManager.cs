using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainUIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text[] displayNames = new TMP_Text[3];
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < displayNames.Length; i++)
        {
            displayNames[i].text = DataManager.Instance.animalsNames[i];
        }
    }
}
