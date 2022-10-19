using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NathanHoward
{
    public enum Person { Undefined, Bob, Steve, Jerry}

    public class Contact : MonoBehaviour
    {
        [SerializeField] private Person chosenPerson = Person.Undefined;
        [SerializeField] private new string name;
        [SerializeField] private string phoneNumber;
        [SerializeField] private string address;
        [SerializeField] private string email;
        [SerializeField] private string preferedName;

        public void Initialise()
        {
            switch (chosenPerson)
            {
                case Person.Undefined:
                    Debug.Log("Set the enum in the inspector.");
                    break;
                case Person.Bob:
                    Setup("Bob", "0400000000", "42 Wallaby Way, Sydney", "Bob@boberiffic.com", "Bob");
                    break;
                case Person.Steve:
                    Setup("Steve", "0411111111", "62 Shellharbour Rd, Oak Flats", "steve@gmail.com", "Steve");
                    break;
                case Person.Jerry:
                    Setup("Jerry", "0222222222", "The Bermuda Triangle", "jezza@missing.com", "Jez");
                    break;
                default:
                    Debug.Log("Invalid choice!");
                    break;
            }

        }

        private void Setup(string newName, 
                           string newPhoneNumber,
                           string newAddress,
                           string newEmail,
                           string newPreferedName)
        {
            name = newName;
            phoneNumber = newPhoneNumber;
            address = newAddress;
            email = newEmail;
            preferedName = newPreferedName;
        }
    }
}
