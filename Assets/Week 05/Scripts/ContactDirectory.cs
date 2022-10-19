using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NathanHoward
{
    public class ContactDirectory : MonoBehaviour
    {
        [SerializeField] private List<Contact> contacts = new List<Contact>();

        private void Start()
        {
        for (int i = 0; i < contacts.Count; i++)
            {
                contacts[i].Initialise();
            }
        }
    }
}
