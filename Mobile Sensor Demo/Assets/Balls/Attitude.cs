using System;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.Controls;
 
 
public class Attitude : MonoBehaviour
{
 
    public GameObject button;
    
    [SerializeField] string dataPath;
    
    float timeElapsed;
    private void Start()
    {
        Input.gyro.enabled = true;  
        
        string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
        dataPath = Path.Combine(Application.persistentDataPath, $"sensorData_{timestamp}.csv");
    }
    private void Update()
    {
        if (SystemInfo.supportsGyroscope)
        {
            //Getting the gyro data
            Quaternion gyro = Input.gyro.attitude;
 
            //Adjusting 
            Quaternion adjustedGyro = new Quaternion(gyro.x,-gyro.y,gyro.z, gyro.w);
            Vector3 angels = adjustedGyro.eulerAngles;
            
            //lock the rotation on the y axis (since we are using the phone while its laying down)
            gameObject.transform.rotation = Quaternion.Euler(-angels.x, 0, angels.y);
            
        }
      
    }
 
    public void PrintAttitude()
    {
        if (SystemInfo.supportsGyroscope)
        {
            Quaternion gyro = Input.gyro.attitude;
            button.GetComponentInChildren<TextMeshProUGUI>().text = $"{gyro}";
            
            File.AppendAllText(dataPath, gyro.ToString() + "\n");
            
            //find data path
            Debug.Log(dataPath);
            
            return;
        }
        Debug.Log(dataPath);
        button.GetComponentInChildren<TextMeshProUGUI>().text = "No gyro sensor data";
    }
}