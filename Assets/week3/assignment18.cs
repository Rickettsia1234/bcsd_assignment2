using System;
using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public class FileStreamExercise : MonoBehaviour
{
    private void Start()
    {
        int writeData = 35;

        Stream writeStream = new FileStream("filestream.dat", FileMode.Create);
        byte[] writeBytes = BitConverter.GetBytes(writeData);
        writeStream.Write(writeBytes, 0, writeBytes.Length);
        writeStream.Close();

        byte[] readBytes = new byte[sizeof(int)];
        Stream readStream = new FileStream("filestream.dat", FileMode.Open);
        readStream.Read(readBytes, 0, readBytes.Length);
        int readData = BitConverter.ToInt32(readBytes, 0);
        readStream.Close();

        Debug.Log(readData);
    }
}

public class BinaryFileStreamExercise : MonoBehaviour
{
    private void Start()
    {
        Stream writeStream = new FileStream("binaryfilestream.dat", FileMode.Create);
        BinaryWriter writer = new BinaryWriter(writeStream);

        writer.Write(35);
        writer.Write(12.34f);
        writer.Write("여러분 안녕하세요 고박사입니다");
        writer.Close();

        Stream readStream = new FileStream("binaryfilestream.dat", FileMode.Open);
        BinaryReader reader = new BinaryReader(readStream);

        Debug.Log(readStream.Length);
        Debug.Log(reader.ReadInt32());
        Debug.Log(reader.ReadSingle());
        Debug.Log(reader.ReadString());
        reader.Close();
    }
}

public class TextFileStreamExercise : MonoBehaviour
{
    private void Start()
    {
        Stream writeStream = new FileStream("textfilestream.dat", FileMode.Create);
        StreamWriter writer = new StreamWriter(writeStream);

        writer.Write(36);
        writer.WriteLine(12.34f);
        writer.WriteLine("여러분 안녕하세요 고박사입니다");
        writer.Close();

        Stream readStream = new FileStream("textfilestream.dat", FileMode.Open);
        StreamReader reader = new StreamReader(readStream);

        while (!reader.EndOfStream)
        {
            Debug.Log(reader.ReadLine());
        }

        reader.Close();
    }
}

[Serializable]
public class Player
{
    public string name;
    public int age;

    [NonSerialized]
    public string address;

    public Player(string name, int age, string address)
    {
        this.name = name;
        this.age = age;
        this.address = address;
    }

    public void PrintData()
    {
        Debug.Log($"Name : {name}, Age : {age}, Address : {address}");
    }
}

public class BinaryFormatterExercise : MonoBehaviour
{
    private void Start()
    {
        Stream writeStream = new FileStream("binaryformatter.dat", FileMode.Create);
        BinaryFormatter formatter = new BinaryFormatter();

        Player writePlayer = new Player("고박사", 35, "고박사의 유니티 노트");
        formatter.Serialize(writeStream, writePlayer);
        writeStream.Close();

        Stream readStream = new FileStream("binaryformatter.dat", FileMode.Open);
        Player readPlayer = (Player)formatter.Deserialize(readStream);
        readStream.Close();

        readPlayer.PrintData();
    }
}