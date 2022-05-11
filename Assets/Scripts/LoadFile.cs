using UnityEngine;
using System.IO;
using System.Collections;
using UnityEngine.UI;

public class LoadFile : MonoBehaviour
{
    [SerializeField] private RawImage _output;
    static string nameFile;
    static string path1;
    static string path2;

    private void Start()
    {
        nameFile = "image";
        path1 = @"C:\Users\art12\Desktop\Download\" + nameFile + ".jpg";
        path2 = @"C:\Users\art12\Desktop\My projects\AIUpscallerNIR\Assets\Emprove\" + nameFile + ".jpg";
    }
    public void MoveFile()
    {
        if (File.Exists(path2))
        {
            File.Delete(path2);
        }

        File.Copy(path1, path2);

        StartCoroutine(OutputRoutines(new System.Uri(path1).AbsoluteUri));
    }

    public IEnumerator OutputRoutines(string url)
    {
        var loader = new WWW(url);
        yield return loader;
        _output.texture = loader.texture;
    }

    public void OpenURL()
    {
        Application.OpenURL("https://colab.research.google.com/drive/1iYdsPDkkDPGK3aUlN73_WUuzPbSbT0XI#scrollTo=981c854c&line=1&uniqifier=1");
    }
    public void DeliteFile()
    {
        File.Delete(path1);
    }
}