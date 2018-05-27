using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GetGPS : MonoBehaviour
{

    public string gps_info = "";
    public string gps_info1 = "";

    // Use this for initialization  
    void Start()
    {

    }

    void OnGUI()
    {
        GUI.skin.label.fontSize = 50;
        GUI.Label(new Rect(20, 20, 600, 55), this.gps_info);
        GUI.Label(new Rect(580, 20, 600, 55), this.gps_info1);
        GUI.skin.button.fontSize = 75;
            // 这里需要启动一个协同程序  
            StartCoroutine(StartGPS());
    }

    // Input.location = LocationService  
    // LocationService.lastData = LocationInfo   

    void StopGPS()
    {
        Input.location.Stop();
    }

    IEnumerator StartGPS()
    {
        // Input.location 用于访问设备的位置属性（手持设备）, 静态的LocationService位置  
        // LocationService.isEnabledByUser 用户设置里的定位服务是否启用  
        if (!Input.location.isEnabledByUser)
        {
            this.gps_info = "isEnabledByUser value is:" + Input.location.isEnabledByUser.ToString() + " Please turn on the GPS";
            yield return false;
        }

        // LocationService.Start() 启动位置服务的更新,最后一个位置坐标会被使用  
        Input.location.Start(10.0f, 10.0f);

        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            // 暂停协同程序的执行(1秒)  
            yield return new WaitForSeconds(1);
            maxWait--;
        }

        if (maxWait < 1)
        {
            this.gps_info = "Init GPS service time out";
            yield return false;
        }

        if (Input.location.status == LocationServiceStatus.Failed)
        {
            this.gps_info = "Unable to determine device location";
            yield return false;
        }
        else
        {
            while(true)
            {
                this.gps_info = "纬度:" + Input.location.lastData.latitude;
                this.gps_info1 = "经度:" + Input.location.lastData.longitude;
                yield return new WaitForSeconds(100);
            }

        }
    }
}
