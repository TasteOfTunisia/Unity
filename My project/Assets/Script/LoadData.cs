using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadData : MonoBehaviour
{
    [System.Serializable]
    public class Reservation
    {
        public string name;
        public string email;
        public string phone;
    }

    public GameObject listItemPrefab;
    public Transform listContainer;


    public static List<Reservation> reservationList = new List<Reservation>();

    void Start()
    {
        foreach (Transform child in listContainer)
        {
            Destroy(child.gameObject);
        }
        
        foreach (var reservation in reservationList)
        {
            CreateListItem(reservation);
        }
    }

    void CreateListItem(Reservation reservation)
    {
        // Instantiate a new listItemPrefab as a child of the listContainer
        GameObject listItem = Instantiate(listItemPrefab, listContainer);

        // Get the Text components from the children of listItem
        Text nameText = listItem.transform.Find("NameText").GetComponent<Text>();
        Text emailText = listItem.transform.Find("EmailText").GetComponent<Text>();

        // Set the text values using reservation data
        nameText.text = "Name: " + reservation.name;
        emailText.text = "Email: " + reservation.email;

        // Adjust the position of the new listItem below the previous one
        float listItemHeight = listItem.GetComponent<RectTransform>().rect.height;
        float offset = 0f; // You can adjust this value to control the spacing between items
        float newYPosition = -listContainer.childCount * (listItemHeight + offset);
        listItem.transform.localPosition = new Vector3(0f, newYPosition, 0f);
    }


    void Update()
    {

    }
}
