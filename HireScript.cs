using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class HireScript : MonoBehaviour 
{
	public bool isHireMenuActive = false;
	public int ssCounter = 0;
	public int slot = 0;

	public bool isTimerActive = false;
	public float timer = 0.0f;

	TouchManagerScript touchManagerScript;

	public GameObject hireMenu;
	public GameObject knight;
	public GameObject ranger;
	public GameObject caster;
	public GameObject tempObject;
	public GameObject tempPos;

	public GameObject formationSpot1;
	public GameObject formationSpot2;
	public GameObject formationSpot3;

	public GameObject slot1;
	public GameObject slot2;
	public GameObject slot3;

	public Button hire1;
	public Button hire2;
	public Button hire3;
	
	public Button dismiss1;
	public Button dismiss2;
	public Button dismiss3;

	public GameObject clickedButton;

	public Sprite knightImage;
	public Sprite rangerImage;
	public Sprite casterImage;

	public List<Sprite> knightButtonSet = new List<Sprite>();
	public List<Sprite> rangerButtonSet = new List<Sprite>();
	public List<Sprite> casterButtonSet = new List<Sprite>();

	public GameObject leftImage;
	public GameObject centerImage;
	public GameObject rightImage;

	public GameObject tempImage;
	public Text tempClassText;
	public Text tempHealthText;
	string healthText;
	string maxHealthText;
	public Text tempAttackText;
	public Text tempSpeedText;

	public Text classTextLeft;
	public Text healthTextLeft;
	public Text attackTextLeft;
	public Text speedTextLeft;

	public Text classTextCenter;
	public Text healthTextCenter;
	public Text attackTextCenter;
	public Text speedTextCenter;

	public Text classTextRight;
	public Text healthTextRight;
	public Text attackTextRight;
	public Text speedTextRight;
	int randomNumber;

	ComboCheckScript comboCheckerScript;

	public Button travelButton;

	// Use this for initialization
	void Start () 
	{
		touchManagerScript = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<TouchManagerScript> ();
		comboCheckerScript = GameObject.FindGameObjectWithTag("Manager").GetComponent<ComboCheckScript>();
		formationSpot1 = GameObject.Find ("Formation Spot Front");
		formationSpot2 = GameObject.Find ("Formation Spot Right");
		formationSpot3 = GameObject.Find ("Formation Spot Left");

		ToggleSlots ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(isTimerActive == true)
		{
			timer += Time.deltaTime;
			if(timer >= 0.05f)
			{
				if(clickedButton == hire1.gameObject)
				{
					if(randomNumber == 1)
					{
						healthText = touchManagerScript.Unit1.GetComponent<KnightScript>().getCurHealth().ToString ();
						maxHealthText = touchManagerScript.Unit1.GetComponent<KnightScript>().getMaxHealth().ToString ();
						tempHealthText.GetComponent<Text>().text = healthText + " / " + maxHealthText;
						tempAttackText.GetComponent<Text>().text = touchManagerScript.Unit1.GetComponent<KnightScript>().getMaxDamage().ToString ();
						tempSpeedText.GetComponent<Text>().text = touchManagerScript.Unit1.GetComponent<KnightScript>().getCurSpeed().ToString ();
					}
					else if(randomNumber == 2)
					{
						healthText = touchManagerScript.Unit1.GetComponent<RangerClassScript>().getCurHealth().ToString ();
						maxHealthText = touchManagerScript.Unit1.GetComponent<RangerClassScript>().getMaxHealth().ToString ();
						tempHealthText.GetComponent<Text>().text = healthText + " / " + maxHealthText;
						tempAttackText.GetComponent<Text>().text = touchManagerScript.Unit1.GetComponent<RangerClassScript>().getMaxDamage().ToString ();
						tempSpeedText.GetComponent<Text>().text = touchManagerScript.Unit1.GetComponent<RangerClassScript>().getCurSpeed().ToString ();
					}
					else if(randomNumber == 3)
					{
						healthText = touchManagerScript.Unit1.GetComponent<CasterClassScript>().getCurHealth().ToString ();
						maxHealthText = touchManagerScript.Unit1.GetComponent<CasterClassScript>().getMaxHealth().ToString ();
						tempHealthText.GetComponent<Text>().text = healthText + " / " + maxHealthText;
						tempAttackText.GetComponent<Text>().text = touchManagerScript.Unit1.GetComponent<CasterClassScript>().getMaxDamage().ToString ();
						tempSpeedText.GetComponent<Text>().text = touchManagerScript.Unit1.GetComponent<CasterClassScript>().getCurSpeed().ToString ();
					}
				}
				if(clickedButton == hire2.gameObject)
				{
					if(randomNumber == 1)
					{
						healthText = touchManagerScript.Unit2.GetComponent<KnightScript>().getCurHealth().ToString ();
						maxHealthText = touchManagerScript.Unit2.GetComponent<KnightScript>().getMaxHealth().ToString ();
						tempHealthText.GetComponent<Text>().text = healthText + " / " + maxHealthText;
						tempAttackText.GetComponent<Text>().text = touchManagerScript.Unit2.GetComponent<KnightScript>().getMaxDamage().ToString ();
						tempSpeedText.GetComponent<Text>().text = touchManagerScript.Unit2.GetComponent<KnightScript>().getCurSpeed().ToString ();
					}
					else if(randomNumber == 2)
					{
						healthText = touchManagerScript.Unit2.GetComponent<RangerClassScript>().getCurHealth().ToString ();
						maxHealthText = touchManagerScript.Unit2.GetComponent<RangerClassScript>().getMaxHealth().ToString ();
						tempHealthText.GetComponent<Text>().text = healthText + " / " + maxHealthText;
						tempAttackText.GetComponent<Text>().text = touchManagerScript.Unit2.GetComponent<RangerClassScript>().getMaxDamage().ToString ();
						tempSpeedText.GetComponent<Text>().text = touchManagerScript.Unit2.GetComponent<RangerClassScript>().getCurSpeed().ToString ();
					}
					else if(randomNumber == 3)
					{
						healthText = touchManagerScript.Unit2.GetComponent<CasterClassScript>().getCurHealth().ToString ();
						maxHealthText = touchManagerScript.Unit2.GetComponent<CasterClassScript>().getMaxHealth().ToString ();
						tempHealthText.GetComponent<Text>().text = healthText + " / " + maxHealthText;
						tempAttackText.GetComponent<Text>().text = touchManagerScript.Unit2.GetComponent<CasterClassScript>().getMaxDamage().ToString ();
						tempSpeedText.GetComponent<Text>().text = touchManagerScript.Unit2.GetComponent<CasterClassScript>().getCurSpeed().ToString ();
					}
				}
				if(clickedButton == hire3.gameObject)
				{
					if(randomNumber == 1)
					{
						healthText = touchManagerScript.Unit3.GetComponent<KnightScript>().getCurHealth().ToString ();
						maxHealthText = touchManagerScript.Unit3.GetComponent<KnightScript>().getMaxHealth().ToString ();
						tempHealthText.GetComponent<Text>().text = healthText + " / " + maxHealthText;
						tempAttackText.GetComponent<Text>().text = touchManagerScript.Unit3.GetComponent<KnightScript>().getMaxDamage().ToString ();
						tempSpeedText.GetComponent<Text>().text = touchManagerScript.Unit3.GetComponent<KnightScript>().getCurSpeed().ToString ();
					}
					else if(randomNumber == 2)
					{
						healthText = touchManagerScript.Unit3.GetComponent<RangerClassScript>().getCurHealth().ToString ();
						maxHealthText = touchManagerScript.Unit3.GetComponent<RangerClassScript>().getMaxHealth().ToString ();
						tempHealthText.GetComponent<Text>().text = healthText + " / " + maxHealthText;
						tempAttackText.GetComponent<Text>().text = touchManagerScript.Unit3.GetComponent<RangerClassScript>().getMaxDamage().ToString ();
						tempSpeedText.GetComponent<Text>().text = touchManagerScript.Unit3.GetComponent<RangerClassScript>().getCurSpeed().ToString ();
					}
					else if(randomNumber == 3)
					{
						healthText = touchManagerScript.Unit3.GetComponent<CasterClassScript>().getCurHealth().ToString ();
						maxHealthText = touchManagerScript.Unit3.GetComponent<CasterClassScript>().getMaxHealth().ToString ();
						tempHealthText.GetComponent<Text>().text = healthText + " / " + maxHealthText;
						tempAttackText.GetComponent<Text>().text = touchManagerScript.Unit3.GetComponent<CasterClassScript>().getMaxDamage().ToString ();
						tempSpeedText.GetComponent<Text>().text = touchManagerScript.Unit3.GetComponent<CasterClassScript>().getCurSpeed().ToString ();
					}
				}
				
				timer = 0.0f;
				isTimerActive = false;
		}
	}
}

	public void ToggleHireMenu()
	{
		if(isHireMenuActive)
		{
			SoundSystemManagerScript.Instance.PlayUI(UIType.DISMISS);
			hireMenu.SetActive(false);
			isHireMenuActive = false;
			travelButton.interactable = true;
		}
		else
		{
			SoundSystemManagerScript.Instance.PlayUI(UIType.HIRE);
			hireMenu.SetActive(true);
			isHireMenuActive = true;
			travelButton.interactable = false;
		}
	}

	public void CheckButton(Button button)
	{
		clickedButton = button.gameObject;
	}

	public void CheckSlots()
	{
		if(clickedButton == hire1.gameObject && touchManagerScript.Unit1 == null)
		{
			SoundSystemManagerScript.Instance.PlayUI(UIType.HIRE);
			tempPos = formationSpot1;
			slot = 1;
			tempImage = leftImage;
			tempClassText = classTextLeft;
			tempHealthText = healthTextLeft;
			tempAttackText = attackTextLeft;
			tempSpeedText = speedTextLeft;
		}
		else if(clickedButton == hire2.gameObject && touchManagerScript.Unit2 == null)
		{
			SoundSystemManagerScript.Instance.PlayUI(UIType.HIRE);
			tempPos = formationSpot2;
			slot = 2;
			tempImage = centerImage;
			tempClassText = classTextCenter;
			tempHealthText = healthTextCenter;
			tempAttackText = attackTextCenter;
			tempSpeedText = speedTextCenter;
		}
		else if(clickedButton == hire3.gameObject && touchManagerScript.Unit3 == null)
		{
			SoundSystemManagerScript.Instance.PlayUI(UIType.HIRE);
			tempPos = formationSpot3;
			slot = 3;
			tempImage = rightImage;
			tempClassText = classTextRight;
			tempHealthText = healthTextRight;
			tempAttackText = attackTextRight;
			tempSpeedText = speedTextRight;
		}
		GenerateSS (tempPos);
		ToggleSlots ();
		isTimerActive = true;
	}

	public void GenerateSS(GameObject pos)
	{
		randomNumber = Random.Range (1, 4);
		if(randomNumber == 1)
		{
			tempObject = (GameObject)Instantiate (knight, pos.transform.position, Quaternion.identity);
			tempObject.GetComponent<KnightScript>().formationPoint = pos;
			tempImage.GetComponent<Image>().sprite = knightImage;
			tempClassText.GetComponent<Text>().text = "Knight";
		}
		else if(randomNumber == 2)
		{
			tempObject = (GameObject)Instantiate (ranger, pos.transform.position, Quaternion.identity);
			tempObject.GetComponent<RangerClassScript>().formationPoint = pos;
			tempImage.GetComponent<Image>().sprite = rangerImage;
			tempClassText.GetComponent<Text>().text = "Ranger";
		}
		else if(randomNumber == 3)
		{
			tempObject = (GameObject)Instantiate (caster, pos.transform.position, Quaternion.identity);
			tempObject.GetComponent<CasterClassScript>().formationPoint = pos;
			tempImage.GetComponent<Image>().sprite = casterImage;
			tempClassText.GetComponent<Text>().text = "Caster";
		}
		touchManagerScript.AssignUnit(slot, tempObject);
		comboCheckerScript.SSComboList.Add(tempObject);
	}
	
	public void ToggleSlots()//@To hide and display UI elements accordingly
	{
		if(touchManagerScript.Unit1 == null)
		{
			hire1.gameObject.SetActive(true);
			slot1.SetActive(false);
			touchManagerScript.firstButton.GetComponent<Button>().interactable = false; 
		}
		else if(touchManagerScript.Unit1 != null)
		{
			//SoundSystemManagerScript.Instance.PlayUI(UIType.HIRE);
			//SoundSystemManagerScript.Instance.SetUIVolume(1.0f);
			hire1.gameObject.SetActive(false);
			slot1.SetActive(true);
			touchManagerScript.firstButton.GetComponent<Button>().interactable = true; 
		}
		
		if(touchManagerScript.Unit2 == null)
		{
			hire2.gameObject.SetActive(true);
			slot2.SetActive(false);
			touchManagerScript.secondButton.GetComponent<Button>().interactable = false; 
		}
		else if(touchManagerScript.Unit2 != null)
		{
			//SoundSystemManagerScript.Instance.SetUIVolume(0.5f);
			//SoundSystemManagerScript.Instance.PlayUI(UIType.HIRE);
			hire2.gameObject.SetActive(false);
			slot2.SetActive(true);
			touchManagerScript.secondButton.GetComponent<Button>().interactable = true; 
		}
		
		if(touchManagerScript.Unit3 == null)
		{
			hire3.gameObject.SetActive(true);
			slot3.SetActive(false);
			touchManagerScript.thirdButton.GetComponent<Button>().interactable = false; 
		}
		else if(touchManagerScript.Unit3 != null)
		{
			//SoundSystemManagerScript.Instance.SetUIVolume(0.5f);
			//SoundSystemManagerScript.Instance.PlayUI(UIType.HIRE);
			hire3.gameObject.SetActive(false);
			slot3.SetActive(true);
			touchManagerScript.thirdButton.GetComponent<Button>().interactable = true; 
		}
	}

	public void DismissSS()
	{
		if(clickedButton == dismiss1.gameObject && touchManagerScript.Unit1 != null)
		{
			SoundSystemManagerScript.Instance.PlayUI(UIType.DISMISS);
			Destroy(touchManagerScript.Unit1.gameObject);
			touchManagerScript.Unit1 = null;
		}
		else if(clickedButton == dismiss2.gameObject && touchManagerScript.Unit2 != null)
		{
			SoundSystemManagerScript.Instance.PlayUI(UIType.DISMISS);
			Destroy(touchManagerScript.Unit2.gameObject);
			touchManagerScript.Unit2 = null;
		}
		else if(clickedButton == dismiss3.gameObject && touchManagerScript.Unit3 != null)
		{
			SoundSystemManagerScript.Instance.PlayUI(UIType.DISMISS);
			Destroy(touchManagerScript.Unit3.gameObject);
			touchManagerScript.Unit3 = null;
		}
	}
}
