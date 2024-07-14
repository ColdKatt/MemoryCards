using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField] private TMP_Text _wordText;
    [SerializeField] private TMP_Text _wordTranslatetext;

    private CardLocation _location;

    private WordData data;

    private void Awake()
    {
        _location = new InitializeLocation(gameObject);
        Debug.Log(_location);
        _location = _location.Next();
        Debug.Log(_location);
        _location = _location.Next();
        Debug.Log(_location);
        _location = _location.Next();
        Debug.Log(_location);
    }

    private void OnEnable()
    {
        data = WordManager.GetRandom();
        _wordText.text = data.Word;
        _wordTranslatetext.text = data.Translate;
    }


    private void Rotate()
    {
        // Rotating by 180 degrees
    }
}
