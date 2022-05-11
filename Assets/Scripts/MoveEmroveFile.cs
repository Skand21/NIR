using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using SFB;

public class MoveEmroveFile : MonoBehaviour
{
    static string nameFile;
    static string path2;
    static string path1;

    private void Start()
    {
        nameFile = "image";
        path2 = @"C:\Users\art12\Desktop\My projects\AIUpscallerNIR\Assets\Emprove\" + nameFile + ".jpg";
    }

    public void SaveFile()
    {
        var path = StandaloneFileBrowser.SaveFilePanel("Save File", "", "image", ".jpg");
        File.Copy(@"C:\Users\art12\Desktop\My projects\AIUpscallerNIR\Assets\Emprove\image.jpg", path);
    }
}