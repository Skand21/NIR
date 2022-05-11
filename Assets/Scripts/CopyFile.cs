using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CopyFile : MonoBehaviour
{

    public static string FullName { get; private set; }
    public static string NewFileLocation { get; private set; }

    private static void SetNewFileLocation()
    {

        try
        {
            if (Application.dataPath != null)
            {
                NewFileLocation = Application.dataPath + @"/ImagesToEmprove";
            }
            else
            {
                throw new Exception("Application.dataPath is null");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Œ¯Ë·Í‡: {e.Message}");
        }
    }

    public static void CopyOneFile()
    {
        SetNewFileLocation();
        try
        {
            File.Copy(FullName, NewFileLocation + @"/1.jpg", true);
            Debug.Log("SucÒess");
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }
    }

    public static void SetLocationFile(string location)
    {
        if (location != null)
        {
            FullName = location;
            CopyOneFile();
            return;
        }
        else
        {
            return;
        }
    }
}
