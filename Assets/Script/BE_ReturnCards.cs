using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BE_ReturnCards : MonoBehaviour
{
    [SerializeField]
    private Button buttonShuffle;

    private void Start()
    {
        buttonShuffle.gameObject.SetActive(false);
        Button btn = buttonShuffle.GetComponent<Button>();
    }

    public void TaskOnClick()
    {




        buttonShuffle.gameObject.SetActive(false);
    }

}
