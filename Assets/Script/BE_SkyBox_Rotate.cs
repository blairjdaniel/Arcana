using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BE_SkyBox_Rotate : MonoBehaviour
{ 

    [SerializeField]
    private float _minutesInDay;
[SerializeField]
private float _timer;
[SerializeField]
private float _turnSpeed;
[SerializeField]
private float _percentageInDay;

[SerializeField]
private float _speed;

[SerializeField]
private Material Skybox;

[SerializeField]
private float nightValue;
[SerializeField]
private float dayValue;
[SerializeField]
private float TFactor;
[SerializeField]
private float _changeSpeed;





void Start()
{
    _timer = 0.0f; // starts timer at 0.


    TFactor = 0.3f; // starts the tint at 0.4


    

    Skybox = RenderSettings.skybox; // starts skybox to the render settings




}

// Update is called once per frame
void Update()
{
    checkTime();
    
    skyboxTintChange();

    skyRotate(); // skybox rotation method.


        _turnSpeed = 360.0f / (_minutesInDay * 60) * Time.deltaTime; // sets the speed to turn the main canvas
    transform.RotateAround(transform.position, transform.right, _turnSpeed); // rotates the main canvas

    if (isNight())
    {
        lightChange();
    }
    //  Debug.Log(_percentageInDay);
}
bool isNight()
{
    bool night = false;
    if (_percentageInDay > 24.0f)
    {
        return true;
    }

    return night;
}

public void checkTime() // checks the percentage of day to set the timer to 0.
{
    _timer += Time.deltaTime;
    _percentageInDay = _timer / (_minutesInDay * 60.0f);

    if (_timer > (_minutesInDay * 60.0f))
    {
        _timer = 0.0f;
    }
}

void lightChange() // method to change to light intensity of the main direct light
{

    if (GetComponent<Light>().intensity > 0.0f)
    {
        GetComponent<Light>().intensity -= 0.05f;
    }
    else
    {
        if (GetComponent<Light>().intensity < 1.0f)
        {
            GetComponent<Light>().intensity += 0.05f;
        }
    }
}
   

    void skyboxTintChange() // chagnes the tint of the skybox
    {
       
        
        if (_percentageInDay > 0.4f && _percentageInDay < 0.99f && TFactor >= nightValue)
        {
            TFactor -= Time.deltaTime * _changeSpeed;

            {
                Skybox.SetColor("_Tint", new Color(TFactor, TFactor, TFactor, 1));
            }
             
        }
        else if (TFactor <= dayValue)
        {
            TFactor += Time.deltaTime * _changeSpeed;

            Skybox.SetColor("_Tint", new Color(TFactor, TFactor, TFactor, 1));
        }
    }
    public void skyRotate()
    {
        Skybox.SetFloat("_Rotation", Skybox.GetFloat("_Rotation") + Time.deltaTime * _speed);
    }
   
}
    