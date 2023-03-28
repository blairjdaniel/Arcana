using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FE_CardShimmer : MonoBehaviour
{


    private Vector3 originalScale;
    private Vector3 scaleTo;

    private Vector3 originalLocation;
    private Vector3 moveTo;


    private GameObject STC, STC1, STC2;


    [SerializeField]
    private float scaleX, scaleY, scaleZ;

    

   

   
    [SerializeField]
    private Quaternion spawnRotation;

    

    public void startShimmer()
    {
        originalScale = this.transform.localScale;
        scaleTo = originalScale * 1.1f;

        transform.DOScale(scaleTo, 1.0f)
            .SetEase(Ease.InOutSine)
            .SetLoops(-1, LoopType.Yoyo);
    }

   public void TaskOnClick()
    {
        originalLocation = this.transform.localPosition;
        transform.DOMove(MyToolBox.CardSlotOne(), 2.0f);

        //yield return new WaitForSeconds(1.0f);
       // transform.DOFlip();



       // yield return new WaitForSeconds(3.0f);

        //spawnSpot(MyToolBox.CardSlotOne());

       
    }

   /* public void spawnSpot(Vector3 spawnPos)
    {

        STC = Instantiate(randomCard, MyToolBox.CardSlotOne(), spawnRotation); // randomcard has to be the one that is selected
        Vector3 startPosition = spawnPos;
        STC.transform.localPosition = startPosition;
        STC.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);

    }
    public void spawnSpotOne(Vector3 spawnPos)
    {

        STC = Instantiate(randomCard, MyToolBox.CardSlotTwo(), spawnRotation);
        Vector3 startPosition = spawnPos;
        STC.transform.localPosition = startPosition;
        STC.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);

    }

    public void spawnSpotTwo(Vector3 spawnPos)
    {

        STC = Instantiate(randomCard, MyToolBox.CardSlotThree(), spawnRotation);
        Vector3 startPosition = spawnPos;
        STC.transform.localPosition = startPosition;
        STC.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);

    }*/
}