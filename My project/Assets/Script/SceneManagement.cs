using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class SceneManagement : MonoBehaviour
{

    public InputField nameInputField;
    public InputField emailInputField;
    public InputField phoneInputField;


    private string databasePath = "URI=file:Assets/Database/yourDatabase.db";

    void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void SaveData()
    {
        string name = nameInputField.text;
        string email = emailInputField.text;
        string phone = phoneInputField.text;

        // Create a new Reservation object with the entered data
        LoadData.Reservation newReservation = new LoadData.Reservation
        {
            name = name,
            email = email,
            phone = phone
        };

        LoadData.reservationList.Add(newReservation);

        SceneManager.LoadScene("MainScene");
    }

    public void GoToScene1()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void GoToScene2()
    {
        SceneManager.LoadScene("SceneReservation");
    }
}
