using System.Text;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using SFB;
using System.Windows.Forms;
using System.IO;

public class OpenFile : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private RawImage _output;
    [SerializeField] private string[] paths;

    public void OnPointerDown(PointerEventData eventData) { }

    public void OnClick()
    {
        paths = StandaloneFileBrowser.OpenFilePanel("Open File", "", "jpg", false);
        if (paths.Length > 0)
        {
            StartCoroutine(OutputRoutine(new System.Uri(paths[0]).AbsoluteUri));
        }
    }

    public IEnumerator OutputRoutine(string url)
    {
        var loader = new WWW(url);
        yield return loader;
        _output.texture = loader.texture;
    }

    public void SetNewLocationFile()
    {
        CopyFile.SetLocationFile(paths[0]);
        Clipboard.SetText(paths[0]);
        Debug.Log(paths[0]);
    }
}