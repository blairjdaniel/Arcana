using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BU_BE_RandomizeLibrary : MonoBehaviour
{
    // [SerializeField]
    // private GameObject library, library1, library2, library3, library4, library5, library6, library7, library8, library9, library10, library11, library12, library13, library14, library15, library16, library17, library18, library19, library20, library21, library22, library23, library24, library25, library26, library27, library28, library29, library30, library31, library32, library33, library34, library35, library36, library37, library38, library39, library40, library41, library42, library43, library44, library45, library46, library47, library48, library49, library50, library51, library52, library53, library54, library55, library56, library57, library58, library59, library60, library61, library62, library63, library64, library65, library66, library67, library68, library69, library70, library71, library72, library73, library74, library75, library76, library77, library78;

    [SerializeField]
    private List<GameObject> randomCards = new List<GameObject>();

    [SerializeField]
    private GameObject randomCard;

    [SerializeField]
    private float scaleX, scaleY, scaleZ;

    private int index;
    [SerializeField]
    private Button button;
    [SerializeField]
    private Button buttonShuffle;

    [SerializeField]
    private GameObject canvas;
    [SerializeField]
    Transform spawnPoint;

    [SerializeField]
    private Vector3 spawnPosition;
    [SerializeField]
    private Quaternion spawnRotation;







    private GameObject STC, STC1, STC2, STC3, STC4, STC5, STC6, STC7, STC8, STC9, STC10, STC11, STC12, STC13, STC14, STC15, STC16, STC17, STC18, STC19, STC20, STC21, STC22, STC23, STC24, STC25, STC26, STC27, STC28, STC29, STC30, STC31, STC32, STC33, STC34, STC35, STC36, STC37, STC38, STC39, STC40, STC41, STC42, STC43, STC44, STC45, STC46, STC47, STC48, STC49, STC50, STC51, STC52, STC53, STC54, STC55, STC56, STC57, STC58, STC59, STC60, STC61, STC62, STC63, STC64, STC65, STC66, STC67, STC68, STC69, STC70, STC71, STC72, STC73, STC74, STC75, STC76, STC77, STC78;


    public void Start()
    {
        //Button btn = button.GetComponent<Button>();
        buttonShuffle.gameObject.SetActive(false);
        // btn.onClick.AddListener(TaskOnClick);

    }


    // Start is called before the first frame update
    public void selectCard()
    {

        StartCoroutine("TaskOnClick");

    }

    IEnumerator TaskOnClick()
    {
        canvas.SetActive(false);

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot0());


        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot1(MyToolBox.Slot1());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot2(MyToolBox.Slot2());


        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot3(MyToolBox.Slot3());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot4(MyToolBox.Slot4());


        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot5(MyToolBox.Slot5());


        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot6(MyToolBox.Slot6());


        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot7(MyToolBox.Slot7());


        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot8(MyToolBox.Slot8());


        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot9(MyToolBox.Slot9());



        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot10(MyToolBox.Slot10());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot11());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot12());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot13());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot14());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot15());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot16());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot17());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot18());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot10(MyToolBox.Slot19());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot20());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot21());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot22());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot23());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot24());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot25());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot26());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot27());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot10(MyToolBox.Slot28());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot29());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot30());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot31());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot32());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot33());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot34());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot35());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot36());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot37());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot38());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot10(MyToolBox.Slot39());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot40());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot41());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot42());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot43());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot44());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot45());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot46());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot47());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot10(MyToolBox.Slot48());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot49());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot50());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot51());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot52());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot53());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot54());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot55());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot10(MyToolBox.Slot56());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot57());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot58());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot59());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot60());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot61());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot62());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot63());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot64());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot10(MyToolBox.Slot65());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot66());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot67());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot68());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot69());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot70());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot71());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot72());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot73());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot10(MyToolBox.Slot74());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot75());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot76());

        index = Random.Range(0, randomCards.Count);
        randomCard = randomCards[index];
        randomCards.Remove(randomCard);
        spawnSpot(MyToolBox.Slot77());

       










        yield return null;
    }

    public void spawnSpot(Vector3 spawnPos)
    {

        STC = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC.transform.localPosition = startPosition;
        STC.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);
        //  TurnObjectTowards();


    }

    public void spawnSpot1(Vector3 spawnPos)
    {

        STC1 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC1.transform.localPosition = startPosition;
        STC1.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);
        // TurnObjectTowards();
    }

    public void spawnSpot2(Vector3 spawnPos)
    {

        STC2 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC2.transform.localPosition = startPosition;
        STC2.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);
        //TurnObjectTowards();


    }
    public void spawnSpot3(Vector3 spawnPos)
    {

        STC3 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC3.transform.localPosition = startPosition;
        STC3.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);
        // TurnObjectTowards();



    }
    public void spawnSpot4(Vector3 spawnPos)
    {

        STC4 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC4.transform.localPosition = startPosition;
        STC4.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);
        //TurnObjectTowards();



    }
    public void spawnSpot5(Vector3 spawnPos)
    {

        STC5 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC5.transform.localPosition = startPosition;
        STC5.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);
        // TurnObjectTowards();



    }
    public void spawnSpot6(Vector3 spawnPos)
    {

        STC6 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC6.transform.localPosition = startPosition;
        STC6.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);
        // TurnObjectTowards();




    }
    public void spawnSpot7(Vector3 spawnPos)
    {

        STC7 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC7.transform.localPosition = startPosition;
        STC7.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);
        // TurnObjectTowards();



    }
    public void spawnSpot8(Vector3 spawnPos)
    {

        STC8 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC8.transform.localPosition = startPosition;
        STC8.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);
        // TurnObjectTowards();



    }
    public void spawnSpot9(Vector3 spawnPos)
    {

        STC9 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC9.transform.localPosition = startPosition;
        STC9.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);
        // TurnObjectTowards();


    }
    public void spawnSpot10(Vector3 spawnPos)
    {

        STC10 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC10.transform.localPosition = startPosition;
        STC10.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);
        // TurnObjectTowards();


    }

    public void spawnSpot11(Vector3 spawnPos)
    {

        STC11 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC11.transform.localPosition = startPosition;
        STC11.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);



    }
    public void spawnSpot12(Vector3 spawnPos)
    {

        STC12 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC12.transform.localPosition = startPosition;
        STC12.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot13(Vector3 spawnPos)
    {

        STC13 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC13.transform.localPosition = startPosition;
        STC13.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot14(Vector3 spawnPos)
    {

        STC14 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC14.transform.localPosition = startPosition;
        STC14.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot15(Vector3 spawnPos)
    {

        STC15 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC15.transform.localPosition = startPosition;
        STC15.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot16(Vector3 spawnPos)
    {

        STC16 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC16.transform.localPosition = startPosition;
        STC16.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot17(Vector3 spawnPos)
    {

        STC17 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC17.transform.localPosition = startPosition;
        STC17.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot18(Vector3 spawnPos)
    {

        STC18 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC18.transform.localPosition = startPosition;
        STC18.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot19(Vector3 spawnPos)
    {

        STC19 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC19.transform.localPosition = startPosition;
        STC19.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot20(Vector3 spawnPos)
    {

        STC20 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC20.transform.localPosition = startPosition;
        STC20.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot21(Vector3 spawnPos)
    {

        STC21 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC21.transform.localPosition = startPosition;
        STC21.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot22(Vector3 spawnPos)
    {

        STC22 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC22.transform.localPosition = startPosition;
        STC22.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot23(Vector3 spawnPos)
    {

        STC23 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC23.transform.localPosition = startPosition;
        STC23.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot24(Vector3 spawnPos)
    {

        STC24 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC24.transform.localPosition = startPosition;
        STC24.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot25(Vector3 spawnPos)
    {

        STC25 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC25.transform.localPosition = startPosition;
        STC25.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot26(Vector3 spawnPos)
    {

        STC26 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC26.transform.localPosition = startPosition;
        STC26.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot27(Vector3 spawnPos)
    {

        STC27 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC27.transform.localPosition = startPosition;
        STC27.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot28(Vector3 spawnPos)
    {

        STC28 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC28.transform.localPosition = startPosition;
        STC28.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot29(Vector3 spawnPos)
    {

        STC29 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC29.transform.localPosition = startPosition;
        STC29.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot30(Vector3 spawnPos)
    {

        STC30 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC30.transform.localPosition = startPosition;
        STC30.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot31(Vector3 spawnPos)
    {

        STC31 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC31.transform.localPosition = startPosition;
        STC31.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot32(Vector3 spawnPos)
    {

        STC32 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC32.transform.localPosition = startPosition;
        STC32.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot33(Vector3 spawnPos)
    {

        STC33 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC33.transform.localPosition = startPosition;
        STC33.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot34(Vector3 spawnPos)
    {

        STC34 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC34.transform.localPosition = startPosition;
        STC34.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot35(Vector3 spawnPos)
    {

        STC35 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC35.transform.localPosition = startPosition;
        STC35.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot36(Vector3 spawnPos)
    {

        STC36 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC36.transform.localPosition = startPosition;
        STC36.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot37(Vector3 spawnPos)
    {

        STC37 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC37.transform.localPosition = startPosition;
        STC37.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot38(Vector3 spawnPos)
    {

        STC38 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC38.transform.localPosition = startPosition;
        STC38.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot39(Vector3 spawnPos)
    {

        STC39 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC39.transform.localPosition = startPosition;
        STC39.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot40(Vector3 spawnPos)
    {

        STC40 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC40.transform.localPosition = startPosition;
        STC40.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot41(Vector3 spawnPos)
    {

        STC41 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC41.transform.localPosition = startPosition;
        STC41.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot42(Vector3 spawnPos)
    {

        STC42 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC42.transform.localPosition = startPosition;
        STC2.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot43(Vector3 spawnPos)
    {

        STC43 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC43.transform.localPosition = startPosition;
        STC43.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot44(Vector3 spawnPos)
    {

        STC44 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC44.transform.localPosition = startPosition;
        STC44.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot45(Vector3 spawnPos)
    {

        STC45 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC45.transform.localPosition = startPosition;
        STC45.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot46(Vector3 spawnPos)
    {

        STC46 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC46.transform.localPosition = startPosition;
        STC46.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot47(Vector3 spawnPos)
    {

        STC47 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC47.transform.localPosition = startPosition;
        STC47.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot48(Vector3 spawnPos)
    {

        STC48 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC48.transform.localPosition = startPosition;
        STC48.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot49(Vector3 spawnPos)
    {

        STC49 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC49.transform.localPosition = startPosition;
        STC49.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot50(Vector3 spawnPos)
    {

        STC50 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC50.transform.localPosition = startPosition;
        STC50.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot51(Vector3 spawnPos)
    {

        STC51 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC51.transform.localPosition = startPosition;
        STC51.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot52(Vector3 spawnPos)
    {

        STC52 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC52.transform.localPosition = startPosition;
        STC52.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot53(Vector3 spawnPos)
    {

        STC53 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC53.transform.localPosition = startPosition;
        STC53.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot54(Vector3 spawnPos)
    {

        STC54 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC54.transform.localPosition = startPosition;
        STC54.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot55(Vector3 spawnPos)
    {

        STC55 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC55.transform.localPosition = startPosition;
        STC55.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot56(Vector3 spawnPos)
    {

        STC56 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC56.transform.localPosition = startPosition;
        STC56.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot57(Vector3 spawnPos)
    {

        STC57 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC57.transform.localPosition = startPosition;
        STC57.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot58(Vector3 spawnPos)
    {

        STC58 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC58.transform.localPosition = startPosition;
        STC58.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot59(Vector3 spawnPos)
    {

        STC59 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC59.transform.localPosition = startPosition;
        STC59.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot60(Vector3 spawnPos)
    {

        STC60 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC60.transform.localPosition = startPosition;
        STC60.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot61(Vector3 spawnPos)
    {

        STC61 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC61.transform.localPosition = startPosition;
        STC61.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot62(Vector3 spawnPos)
    {

        STC62 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC62.transform.localPosition = startPosition;
        STC62.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot63(Vector3 spawnPos)
    {

        STC63 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC63.transform.localPosition = startPosition;
        STC63.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot64(Vector3 spawnPos)
    {

        STC64 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC64.transform.localPosition = startPosition;
        STC64.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot65(Vector3 spawnPos)
    {

        STC65 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC65.transform.localPosition = startPosition;
        STC65.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot66(Vector3 spawnPos)
    {

        STC66 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC66.transform.localPosition = startPosition;
        STC66.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot67(Vector3 spawnPos)
    {

        STC67 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC67.transform.localPosition = startPosition;
        STC67.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot68(Vector3 spawnPos)
    {

        STC68 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC68.transform.localPosition = startPosition;
        STC68.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot69(Vector3 spawnPos)
    {

        STC69 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC69.transform.localPosition = startPosition;
        STC69.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot70(Vector3 spawnPos)
    {

        STC70 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC70.transform.localPosition = startPosition;
        STC70.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot71(Vector3 spawnPos)
    {

        STC71 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC72.transform.localPosition = startPosition;
        STC72.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot72(Vector3 spawnPos)
    {

        STC72 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC72.transform.localPosition = startPosition;
        STC72.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot73(Vector3 spawnPos)
    {

        STC73 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC73.transform.localPosition = startPosition;
        STC73.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot74(Vector3 spawnPos)
    {

        STC74 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC74.transform.localPosition = startPosition;
        STC74.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot75(Vector3 spawnPos)
    {

        STC75 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC75.transform.localPosition = startPosition;
        STC75.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot76(Vector3 spawnPos)
    {

        STC76 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC76.transform.localPosition = startPosition;
        STC76.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot77(Vector3 spawnPos)
    {

        STC77 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC77.transform.localPosition = startPosition;
        STC77.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
    public void spawnSpot78(Vector3 spawnPos)
    {

        STC78 = Instantiate(randomCard, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        STC78.transform.localPosition = startPosition;
        STC78.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }


}

