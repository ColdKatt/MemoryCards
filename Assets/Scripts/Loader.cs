using System.Collections.Generic;
using System.IO;
using System.Collections;
using UnityEngine;
using SimpleFileBrowser;

public class Loader : MonoBehaviour
{

    public void StartLoad()
    {
        StartCoroutine(Loading());
    }

    public void Load(string path)
    {
        //if (!(path.Length > 0)) return;

        var lines = new List<string>();
        var reader = new StreamReader(path);

        var line = reader.ReadLine();
        while (line != null)
        {
            lines.Add(line);
            line = reader.ReadLine();
        } 

        WordManager.FillWords(lines.ToArray());
    }

    IEnumerator Loading()
    {
        FileBrowser.SetDefaultFilter(".txt");
        yield return FileBrowser.WaitForLoadDialog(FileBrowser.PickMode.Files, false, null, null, "Load", "Load");

        if (FileBrowser.Success)
        {
            Load(FileBrowser.Result?[0]);
        }
    }
}
