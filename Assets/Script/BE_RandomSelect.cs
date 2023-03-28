using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BE_RandomSelect : MonoBehaviour
{

    [SerializeField]
    private GameObject library;
    [SerializeField]
    private GameObject libraryTwo;
    [SerializeField]
    private GameObject libraryThree;



    [SerializeField]
    private GameObject[] randomCard;
    [SerializeField]
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


    private GameObject spawnedTarotCard;
    private GameObject spawnedTarotCardTwo;
    private GameObject spawnedTarotCardThree;


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

    
    

    IEnumerator TaskOnClick() // iterates through tagged "cards" and pulls out three random cards
    {

        canvas.SetActive(false);
        randomCard = GameObject.FindGameObjectsWithTag("card"); // finds all gameobjects tagged "card"
        index = Random.Range(0, randomCard.Length);
        library = randomCard[index];
        spawnSpot(MyToolBox.Slot1()); // adds random card to slot 1
        //library.SetActive(false); // takes card out of deck so it can't be picked twice

        yield return new WaitForSeconds(3.0f);

        randomCard = GameObject.FindGameObjectsWithTag("card");
        index = Random.Range(0, randomCard.Length);
        libraryTwo = randomCard[index];
        spawnSpotTwo(MyToolBox.Slot2());
        //library.SetActive(fale);

        yield return new WaitForSeconds(3.0f);

        randomCard = GameObject.FindGameObjectsWithTag("card");
        index = Random.Range(0, randomCard.Length);
        libraryThree = randomCard[index];
        spawnSpotThree(MyToolBox.Slot3());
        // library.SetActive(false); //

        print(library.name);
        print(libraryTwo.name);
        print(libraryThree.name); // console log

        button.gameObject.SetActive(false); // hides the first select random card button.

        //library.SetActive(true);

        buttonShuffle.gameObject.SetActive(true); // shows second reshuffle button

        yield return null;

    }

    public void spawnSpot(Vector3 spawnPos)
    {

        spawnedTarotCard = Instantiate(library, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        spawnedTarotCard.transform.localPosition = startPosition;
        spawnedTarotCard.transform.localScale = new Vector3(5, 8 , 1);


    }

    public void spawnSpotTwo(Vector3 spawnPos)
    {

        spawnedTarotCardTwo = Instantiate(libraryTwo, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        spawnedTarotCardTwo.transform.localPosition = startPosition;
        spawnedTarotCardTwo.transform.localScale = new Vector3(5, 8, 1);


    }

    public void spawnSpotThree(Vector3 spawnPos)
    {

        spawnedTarotCardThree = Instantiate(libraryThree, spawnPoint.position, spawnRotation, spawnPoint);
        Vector3 startPosition = spawnPos;
        spawnedTarotCardThree.transform.localPosition = startPosition;
        spawnedTarotCardThree.transform.localScale = new Vector3(5, 8, 1);


    }


    public void Shuffle()
    {
       

        Destroy(spawnedTarotCard);
        Destroy(spawnedTarotCardTwo);
        Destroy(spawnedTarotCardThree);

        buttonShuffle.gameObject.SetActive(false);
        button.gameObject.SetActive(true);
        canvas.SetActive(true);

        Debug.Log("Destroy");
    }



    //public void reshuffleDeck(Vector3 shufflePos)









}







