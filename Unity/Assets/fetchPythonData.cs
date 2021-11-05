using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System.IO;
using UnityEngine.UI;
//using IronPython.Hosting;
//using Microsoft.Scripting.Hosting;

//by Zack Mader


public class fetchPythonData : MonoBehaviour
{

    public Text myText;
    // Start is called before the first frame update
    void Start()
    {
        //run_cmd();
        myText = GetComponent<Text>();
        myText.text ="No data yet.";
    }

    // Update is called once per frame
    void Update()
    {
        run_cmd();
        //ScriptEngine engine = Python.CreateEngine();
        //engine.ExecuteFile(@"fetchInt.py");
    }

    void run_cmd()
    {
        ProcessStartInfo start = new ProcessStartInfo();
        //used complete file path for testing but works with shortened path
        //start.FileName = "C:/Users/mader22/My project/Assets/fetchInt.exe";
        start.FileName = "Assets/fetchInt.exe"; //independent of complete file path
        //start.Arguments = Null;
        start.UseShellExecute = false;
        start.RedirectStandardOutput = true;
        using(Process process = Process.Start(start))
        {
            using(StreamReader reader = process.StandardOutput)
            {
                string result = reader.ReadToEnd();
                //Console.Write(result);
                myText.text = result;
                UnityEngine.Debug.Log(result);
            }
        }
    }
}
