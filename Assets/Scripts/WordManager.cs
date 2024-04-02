using System.Collections.Generic;
using UnityEngine;

public static class WordManager
{
    private static List<WordData> wordsList = new List<WordData>();

    public static WordData GetRandom() => wordsList?[Random.Range(0, wordsList.Count)];

    public static void FillWords(string[] words)
    {
        wordsList = new List<WordData>();

        foreach (var word in words)
        {
            var data = word.Split('|');
            wordsList.Add(new WordData(data[0], data[1]));
        }
    }
}