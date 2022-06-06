using UnityEngine;

public class SpeedGame : MonoBehaviour
{
    public void speed_x1()
    {
        Time.timeScale = 1;
    }
    
    public void speed_x3()
    {
        Time.timeScale = 3;
    }
    
    public void speed_x5()
    {
        Time.timeScale = 5;
    }
}
