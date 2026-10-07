using System.IO;
using UnityEngine;

public class FileExercise : MonoBehaviour
{
    private void Start()
    {
        FileStream file = File.Create("a.dat");
        file.Close();

        File.Copy("a.dat", "b.dat");
        File.Move("a.dat", "c.dat");

        if (File.Exists("c.dat"))
        {
            Debug.Log(File.GetAttributes("c.dat"));
        }

        File.Delete("c.dat");
        File.Delete("b.dat");
    }
}

public class FileInfoExercise : MonoBehaviour
{
    private void Start()
    {
        FileInfo fileInfo = new FileInfo("d.dat");
        FileStream file = fileInfo.Create();
        file.Close();

        fileInfo.CopyTo("e.dat");
        fileInfo.MoveTo("f.dat");

        if (fileInfo.Exists)
        {
            Debug.Log(fileInfo.Attributes);
        }

        fileInfo.Delete();
    }
}

public class DirectoryExercise : MonoBehaviour
{
    private void Start()
    {
        Directory.CreateDirectory("Exercise");
        Directory.Move("Exercise", "Exercise2");

        if (Directory.Exists("Exercise2"))
        {
            string[] directories = Directory.GetDirectories("Exercise2");
            Debug.Log(directories.Length);

            string[] files = Directory.GetFiles("Exercise2");
            Debug.Log(files.Length);
        }

        Directory.Delete("Exercise2", true);
    }
}

public class DirectoryInfoExercise : MonoBehaviour
{
    private void Start()
    {
        string path = Application.dataPath;
        DirectoryInfo currentDirectory = new DirectoryInfo(path);

        currentDirectory.CreateSubdirectory("TestA");

        Debug.Log(currentDirectory.FullName);
        Debug.Log(currentDirectory.Name);

        if (currentDirectory.Exists)
        {
            Debug.Log(currentDirectory.Attributes);
        }

        foreach (DirectoryInfo directory in currentDirectory.GetDirectories())
        {
            Debug.Log(directory.Name);
        }

        foreach (FileInfo file in currentDirectory.GetFiles())
        {
            Debug.Log(file.Name);
        }
    }
}