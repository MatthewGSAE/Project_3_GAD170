using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Applicant : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI onBoardCrewMembersText;
    [SerializeField] private TextMeshProUGUI hobbyText;
    [SerializeField] private TextMeshProUGUI nameText;

    [SerializeField] private CrewMembers acceptedHumanApplicants;

    [SerializeField] private string characterName;
    [SerializeField] private string hobby;
    [SerializeField] private bool isAlien;

    private int applicantsOnboard = 0;

    private string[] humanHobbies = { "Painting landscapes", "Gardening", "Baking cookies", "Running track", "Reading books" };
    private string[] names = { "Bob", "Alice", "Mark", "Jennifer","Jack","Keala","Matthew","jess","sam","chloe"};
    private string[] alienHobbies = { "Accepting of all races", "Respecting other culture", "Being open-minded", "Accepting personal boundaries", "Not mis-gendering anyone" };
    // Start is called before the first frame update
    void Start()
    {
        GenerateNewHuman();
        UpdateText();
    }

    //  acceptedHumanApplicants.crewMembersOnboard.Add(this);
    // applicantsOnboard++;
     //onBoardCrewMembersText.text = "Onboard Crew Members: " + applicantsOnboard;
    public void OnAcceptButtonPress()
    {
        if (isAlien == false)
        {
            applicantsOnboard++;
            onBoardCrewMembersText.text = "Onboard Crew Members: " + applicantsOnboard;
        }

        int rand = Random.Range(0, 2);

        if (rand == 0)
        {
            GenerateNewHuman();
        }

        if (rand == 1)
        {
            GenerateNewAlien();
        }

         UpdateText();
    }

    public void OnDeclineButtonPress()
    {

      

        int rand = Random.Range(0, 2);

        if (rand == 0)
        {
            GenerateNewHuman();
        }

        if (rand == 1)
        {
            GenerateNewAlien();
        }

       UpdateText();
    }

    private void GenerateNewHuman()
    {
        characterName = names[Random.Range(0, names.Length)];
        hobby = humanHobbies[Random.Range(0, humanHobbies.Length)];
        isAlien = false;
        Debug.Log("A New Human Applicant Has Appeared");
    }

    private void GenerateNewAlien()
    {
        characterName = names[Random.Range(0, names.Length)];
        hobby = alienHobbies[Random.Range(0, alienHobbies.Length)];
        isAlien = true;
        Debug.Log("A New Alien Applicant Has Appeared");
    }

    public void CrewMemberList()
    {
     
    }

    private void UpdateText()
    {
        hobbyText.text = "hobby: " + hobby;
        nameText.text = "Applicant: " + characterName;
    }
}
