using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Runtime.InteropServices;
using System;


public class preplanningDocument : MonoBehaviour {

    OperationalInfo opInfo = new OperationalInfo();
    AdditionalOppINfo addOppInfo = new AdditionalOppINfo();
    HospitalFacilities hosFac = new HospitalFacilities();
    HelicopterPlan heliPlan = new HelicopterPlan();
    Weather weather = new Weather();
    AnimalThreats anThreat = new AnimalThreats();
    PlantThreats plTreats = new PlantThreats();
    HazardousMaterials hazMat = new HazardousMaterials();
    PublicWorks pubWorks = new PublicWorks();
    ExtendedOperations exOpp = new ExtendedOperations();
    ProfileData profDat = new ProfileData();
    Other otr = new Other();

    //for profile data deletion
    private bool hasHitClear = false;

    //for file path
    private string path = "";
    private string path2 = "";

    //for profiles
    private int numOfProflies = 3;
    private int numerifOfLastProfile = 1;
    private int n = 0;
    private string profileName = "";

    public Text loadButtonFirstProfileTextInput;
    public Text loadButtonSecondProfileTextInput;
    public Text loadButtonThirdProfileTextInput;

    public GameObject primaryHospitalNameVisualInput;
    public GameObject primaryHospitalTypeVisualInput;
    public GameObject primaryHospitalAddressVisualInput;
    public GameObject primaryHospitalDistanceVisualInput;
    public GameObject primaryHospitalEDContactVisualInput;
    public GameObject secHospitalNameVisualInput;
    public GameObject secHospitalTypeVisualInput;
    public GameObject secHospitalAddressVisualInput;
    public GameObject secHospitalDistanceVisualInput;
    public GameObject secHospitalEDContactVisualInput;
    public GameObject tertHospitalNameVisualInput;
    public GameObject tertHospitalTypeVisualInput;
    public GameObject tertHospitalAddressVisualInput;
    public GameObject tertHospitalDistanceVisualInput;
    public GameObject tertHospitalEDContactVisualInput;

    public GameObject primaryAircaftVisualInput;
    public GameObject primaryAircraftContactVisualInput;
    public GameObject secAircaftVisualInput;
    public GameObject secAircraftContactVisualInput;

    public GameObject emsRadioVisualInput;
    public GameObject emsSupervisorVisualInput;
    public GameObject fdRadioVisualInput;
    public GameObject fdOfficerVisualInput;

    public GameObject primaryNameHosProfileVisualInput;
    public GameObject primaryTypeHosProfileVisualInput;
    public GameObject primaryAdressHosProfileVisualInput;
    public GameObject primaryDistanceHosProfileVisualInput;
    public GameObject primaryEDContactHosProfileVisualInput;

    public GameObject aircraftProfVisualInput;
    public GameObject aircraftProfContactVisualInput;

    public GameObject emsRadioProfVisInput;
    public GameObject emsSupeProfVisInput;
    public GameObject fdRadProfVisInput;
    public GameObject fdOffProfVisInput;

    public Dropdown hospitleProfileDropdown;
    public Dropdown heliProfileDropdown;
    public Dropdown addOppProfileDropdown;

    #region Refernces for Input
    //References to input fields

    //profile name
    public Text profileNameInput;
    //profile name

    //Opp Info
    public Text dateMonthInput;
    public Text dateDayInput;
    public Text dateYearInput;
    public Text timeHourInput;
    public Text timeMinInput;
    public Text timeAmPMInput;
    public Text latitudeInput;
    public Text longitudeInput;
    public Text locationInput;
    public Text warrentNumInput;
    public Text suspectNumInput;
    public Text hostageNumInput;
    public Text protectionNumInput;
    public Text openTerrainSearchNumInput;
    public Text otherNumInput;
    public Text tacticalNumInput;
    public Text emsMedicNumInput;
    public Text detectiveNumInput;
    public Text patronNumInput;
    public Text k9NumInput;
    //End Opp Info

    //Add Opp Info
    public Text emsRadioInput;
    public Text emsUnit1Input;
    public Text emsUnit2Input;
    public Text emsUnit3Input;
    public Text emsStagingInput;
    public Text emsSupervisorInput;
    public Text fdRadioInput;
    public Text fdUnit1Input;
    public Text fdUnit2Input;
    public Text fdUnit3Input;
    public Text fdStagingInput;
    public Text fdOfficerInput;
    //Add Opp Info

    //Hospitle
    public Text primaryNameInput;
    public Text primaryTypeInput;
    public Text primaryAddressInput;
    public Text primaryDistanceInput;
    public Text primaryEDContactNOInput;
    public Text secondaryNameInput;
    public Text secondaryTypeInput;
    public Text secondaryAddressInput;
    public Text secondaryDistanceInput;
    public Text secondaryEDContactNOInput;
    public Text tertNameInput;
    public Text tertTypeInput;
    public Text tertAddressInput;
    public Text tertDistanceInput;
    public Text tertEDContactNOInput;
    //End Hospitle Info

    //Helicopeter Plans
    public Text heliPrimaryNameInput;
    public Text heliPrimaryContactNumInput;
    public Text heliSecondaryNameInput;
    public Text heliSecondaryContactNumInput;
    public Text landingZoneAddressInput;
    public Text landingZoneTypeInput;
    public Text heliLatitudeInput;
    public Text heliLongitudeInput;
    public Text obstructionDebries;
    public Text obstructionDebries2;
    public Text mrgsInput;
    //ENd Helicopter Plans

    //Weather
    public Text tempHighInput;
    public Text tempLowInput;
    public Text precipInput;
    public Text sunriseInput;
    public Text sunsetInput;
    public Text heatIndexInput;
    public Text windInput;
    public Text humidtyInput;
    public Text recsInput;
    public Text recs2Input;
    public Text recs3Input;

    public GameObject nightOpsInput;
    public GameObject coldRiskInput;
    public GameObject uniformAdjustmentsInput;
    public GameObject weatherBool1Input;
    public GameObject weatherBool2Input;
    public GameObject weatherBool3Input;
    public GameObject weatherBool4Input;
    public GameObject weatherBool5Input;
    public GameObject weatherBool6Input;
    public GameObject weatherBool7Input;

    //End Weather

    //Animal Threats
    public Text domesticAnimalName1Input;
    public Text domesticAnimalName2Input;
    public Text domesticAnimalName3Input;
    public Text domesticAnimalName4Input;
    public Text domesticAnimalName5Input;
    public Text domesticAnimalName6Input;
    public Text domesticAnimalName7Input;
    public Text posionSnakeName1Input;
    public Text posionSnakeName2Input;
    public Text posionSnakeName3Input;
    public Text posionSnakeName4Input;
    public Text wildAnimalName1Input;
    public Text wildAnimalName2Input;
    public Text wildAnimalName3Input;
    public Text wildAnimalName4Input;
    public Text wildAnimalName5Input;
    public Text policeDogNumInput;
    public Text vetAddressLn1Input;
    public Text vetAddressLn2Input;
    public Text policeVetNameInput;
    public Text vetContactNoInput;
    public Text vetAfterHoursContactNoInput;
    public Text policeDogNameInput;

    public GameObject domesticAnimalsInput;
    public GameObject posionousSnakesInput;
    public GameObject wildAnimalsInput;
    public GameObject policeDogsInput;
    //End Animal Threats

    //Plant and Public Works
    public Text posionControlNumInput;
    public Text posionPlantsType1Input;
    public Text posionPlantsType2Input;
    public Text posionPlantsType3Input;
    public Text posionPlantsType4Input;
    public Text posionPlantsType5Input;
    public Text rec1Input;
    public Text rec2Input;
    public Text rec3Input;
    public Text rec4Input;
    public Text rec5Input;
    public Text streedClosingLocInput;
    public Text roadHazardLocInput;
    public Text gateAccessInput;
    public Text gateLocInput;
    public Text emsLocationInput;

    public GameObject posionPlantExposiourCheck;
    public GameObject uniformAdjustmentsNeeded;
    public GameObject streetCleaningCheck;
    public GameObject raodHazardsCheck;
    public GameObject gateAccessNeeded;
    public GameObject emsNeeded;
    //End Plant and Public Works

    //Extended Ops
    public Text workCyclesOneInput;
    public Text workCyclesTwoInput;
    public Text workCyclesThreeInput;
    public Text workCyclesFourInput;
    public Text nutritionOneInput;
    public Text nutritionTwoInput;
    public Text nutritionThreeInput;
    public Text nutritionFourInput;
    public Text restroomOneInput;
    public Text restroomTwoInput;
    public Text restroomThreeInput;
    public Text restroomFourInput;
    public Text sleepOneInput;
    public Text sleepTwoInput;
    public Text sleepThreeInput;

    public GameObject workCyclesCheck;
    public GameObject nutritionCheck;
    public GameObject restroomCheck;
    public GameObject sleepDeterminedCheck;
    //End Extended Ops

    //Hazardous Materials
    public Text ignitionRiskOneInput;
    public Text ignitionRiskTwoInput;
    public Text ignitionRiskThreeInput;
    public Text clandestineLabOneInput;
    public Text clandestineLabTwoInput;
    public Text clandestineLabThreeInput;
    public Text indsutrialChemOneInput;
    public Text indsutrialChemTwoInput;
    public Text indsutrialChemThreeInput;
    public Text otherHazMatOneInput;
    public Text otherHazMatTwoInput;
    public Text otherHazMatThreeInput;
    public Text recomendOneInput;
    public Text recomendTwoInput;
    public Text hazMatTeamNumberInput;

    public GameObject ignitionCheck;
    public GameObject clandestineLabCheck;
    public GameObject industrialChemCheck;
    public GameObject otherHazMatCheck;
    public GameObject ppeCheck;
    public GameObject nomexCheck;
    public GameObject obtainViaDispatchCheck;
    //End Hazardous Materials

    //Other
    public Text otherInputOne1Input;
    public Text otherInputOne2Input;
    public Text otherInputOne3Input;
    public Text otherInputOne4Input;
    public Text otherInputOne5Input;
    public Text otherInputTwo1Input;
    public Text otherInputTwo2Input;
    public Text otherInputTwo3Input;
    public Text otherInputTwo4Input;
    public Text otherInputTwo5Input;
    public Text otherInputThree1Input;
    public Text otherInputThree2Input;
    public Text otherInputThree3Input;
    public Text otherInputThree4Input;
    public Text otherInputThree5Input;

    //End Other
    #endregion Refernces for Input



    public Text hospitleNameProfInput;
    public Text hospitleTypeProfInput;
    public Text hospitleAddressProfInput;
    public Text hospitleDistanceProfInput;
    public Text hospitleEDContactProfInput;
    public Text profileNameHospInput;

    public Text heliAircraftProfInput;
    public Text heliContactProfInput;
    public Text profileNameHeliInput;

    public Text addOppProfEDRadioInput;
    public Text addOppProfileEDOfficerInput;
    public Text addOppProfileFDRadioInput;
    public Text addOppProfileFDOfficerInput;
    public Text profileNameAddOppInput;

    public Dropdown sampleHospDropdwon;
    [HideInInspector]
    public Dropdown.OptionData hospDropProfName1, hospDropProfName2, hospDropProfName3, hospDropProfName4, hospDropProfName5, hospDropProfName6, heliDropProfName, addOppDropProfName;
    [HideInInspector]
    public List<Dropdown.OptionData> hospDropMessages = new List<Dropdown.OptionData>();
    [HideInInspector]
    public string hospStringProfName;
    [HideInInspector]
    public int indexProfName;
    public Dropdown hospitleDropdownOne;
    public Dropdown hospitleDropdownTwo;
    public Dropdown hospitleDropdownThree;

    public Dropdown sampleHeliDropdown;
    [HideInInspector]
    public Dropdown.OptionData heliDropProfName1, heliDropProfName2, heliDropProfName3, heliDropProfName4, heliDropProfName5, heliDropProfName6;
    [HideInInspector]
    public List<Dropdown.OptionData> heliDropMessages = new List<Dropdown.OptionData>();
    [HideInInspector]
    public string heliStringProfName;
    [HideInInspector]
    public int indexProfNameHeli;
    public Dropdown heliDropdownOne;
    public Dropdown heliDropdownTwo;

    public Dropdown sampleAddOpp;
    [HideInInspector]
    public Dropdown.OptionData addOppDropProfName1, addOppDropProfName2, addOppDropProfName3, addOppDropProfName4, addOppDropProfName5, addOppDropProfName6;
    [HideInInspector]
    public List<Dropdown.OptionData> addOppDropMessages = new List<Dropdown.OptionData>();
    [HideInInspector]
    string addOppStringProfName;
    [HideInInspector]
    public int indexProfNameAddOpp;
    public Dropdown addOppDropdownOne;
    public Dropdown addOppDropdownTwo;
    

    //Functions to add info to the model

    //generated data for testing
    public void generateTestPDFData()
    {
        opInfo.amPM = "Am";
        opInfo.dateDay = 21;
        opInfo.dateMonth = 08;
        opInfo.dateYear = 1993;
        opInfo.detectiveNumber = 1;
        opInfo.emsMedicNumber = 2;
        opInfo.hostageNumber = 0;
        opInfo.kNineNumber = 2;
        opInfo.latitude = "0.2123123";
        opInfo.location = "4725 Tree Ln, Charlotte, NC, 282812";
        opInfo.longitude = "1.1232558";
        opInfo.openTerrainSearch = 1;
        opInfo.otherNumber = 0;
        opInfo.otherPersonalNumber = 5;
        opInfo.patrolNumber = 2;
        opInfo.protectionNumber = 4;
        opInfo.suspectNumber = 3;
        opInfo.tacticalNumber = 10;
        opInfo.timeHour = 10;
        opInfo.timeMin = 39;
        opInfo.warrentNumber = 12348483;

        //End Op Info

        //Hospitle Facility
        hosFac.address = "2135 Scenic Drive Charlstion VA 37252";
        hosFac.distance = "10";
        hosFac.edContactNum = "(404) 929 827 9837";
        hosFac.name = "Building Le FixALot";
        hosFac.type = "Full Function";

        hosFac.address2 = "1245 Scenic Drive Charlstion VA 37252";
        hosFac.distance2 = "8";
        hosFac.edContactNum2 = "(245) 929 827 9837";
        hosFac.name2 = "Le FixALot";
        hosFac.type2 = "Full Eosie";

        hosFac.address3 = "2135 Scenic Drive Charlstion NC 37252";
        hosFac.distance3 = "5";
        hosFac.edContactNum3 = "(125) 929 827 9837";
        hosFac.name3 = "FixALot";
        hosFac.type3 = "ER only";

        //End Hospitle Info

        //Heli Plan
        heliPlan.altAirConNum = "(123) 151 1253";
        heliPlan.altAircraft = "FlightSim";
        heliPlan.contactNum = "(373) 225 2358";
        heliPlan.landingAddress = "1585 Tree Lane 24685";
        heliPlan.landingType = "Parking Lot";
        heliPlan.landLat = "0.123746f";
        heliPlan.landLong = "1.0383837f";
        heliPlan.obstruction = "None";
        heliPlan.obstruction2 = "Fallen Trees";
        heliPlan.primaryAircraft = "United Healing";
        //End Heli Plan

        //weather
        weather.coldRisk = false;
        weather.heatInded = 15;
        weather.humidty = 30;
        weather.nightOps = true;
        weather.precip = 35;
        weather.recs = "No recs";
        weather.recs2 = "Sunscreen";
        weather.recs3 = "percip";
        weather.sunrise = "6am";
        weather.sunset = "8pm";
        weather.tempHi = 83;
        weather.tempLow = 50;
        weather.uniAdjust = false;
        weather.windSpeed = 5;
        weather.weatherBool1 = false;
        weather.weatherBool2 = true;
        weather.weatherBool3 = false;
        weather.weatherBool4 = false;
        weather.weatherBool5 = false;
        weather.weatherBool6 = false;
        weather.weatherBool7 = false;

        //End Weather

        //animal threats
        anThreat.afterHoursContactNum = "913 325 2111";
        anThreat.animalControlNumber = "525 123 1245";
        anThreat.domesticAnimals = true;
        anThreat.domesticNum = 1;
        anThreat.domesticTypes = "dog";
        anThreat.obtainViaDispatch = false;
        anThreat.poisonNum = 1;
        anThreat.poisonousSnakes = true;
        anThreat.poisonousTypes = "coral snake";
        anThreat.policeDogNum = 0;
        anThreat.policeDogs = false;
        anThreat.policeVetAddressLn1 = "2405 Sen Drive";
        anThreat.policeVetAddressLn2 = "Gorengia CA 21547";
        anThreat.policeVetName = "Dr Sam";
        anThreat.vetContactNum = "989 645 4225";
        anThreat.wildAnimals = true;
        anThreat.wildAnimalTypes = "Elk";
        anThreat.wildNum = 1;
        anThreat.policeDogName = "Bryce";
        //End animal threats

        //plant threats;
        plTreats.poisonControlNum = "848 565 6457";
        plTreats.poisonousPlantTypes1 = "Posion Ivy";
        plTreats.poisonousPlantTypes2 = "Ivy";
        plTreats.poisonousPlatExpo = true;
        plTreats.recomendationsForUniforms1 = "Long pants";
        plTreats.recomendationsForUniforms2 = "Long Sleeves";
        plTreats.uniformAdjust = true;
        //End Plant threats

        //Haz Mat
        hazMat.cladestineLab = true;
        hazMat.cladestineTypes1 = "Meth";
        hazMat.hazmatTeamNumber = "625 242 5555";
        hazMat.ignitingRisks = true;
        hazMat.ignitingTypes1 = "gasoline";
        hazMat.industrialChamTypes1 = "bleach";
        hazMat.industrialChemicals = true;
        hazMat.nomiex = false;
        hazMat.obtainViaDispatch = true;
        hazMat.otherHazMat = true;
        hazMat.otherHazMatTypes1 = "Angent 51";
        hazMat.otherSpecialPPE = true;
        hazMat.recListOne = "advoid lighters";
        hazMat.recListTwo = "nothing";
        //End Haz Mat

        //pub work
        pubWorks.emsStaging = true;
        pubWorks.gateAccess = true;
        pubWorks.gateCode = "1E238";
        pubWorks.gateLoc = "1242 Tree Ln Charlotte NC 28251";
        pubWorks.roadHazardLocation = "Corner of Sharon and Tree";
        pubWorks.roadHazardLocation2 = "Smith and Weston";
        pubWorks.roadHazards = true;
        pubWorks.roadHazards2 = true;
        pubWorks.streatCleaningLoc = "N/A";
        pubWorks.streedCleaning = false;
        //End pub work

        //exOpp
        exOpp.nutritionSecured = true;
        exOpp.nutritionalList1 = "peanuts";
        exOpp.nutritionalList2 = "chips";
        exOpp.nutritionalList3 = "Cheezits";
        exOpp.restroomFacityDet = true;
        exOpp.restromList1 = "port a potty";
        exOpp.sleepAreaDetermined = true;
        exOpp.sleepAreaList1 = "truck";
        exOpp.workCyclesDetermined = true;
        exOpp.workCycleList1 = "first shift then 2nd shift";
        //End ExOpp

    }

    public void generatePDF()
    {

        string path = Application.persistentDataPath;
        path2 = Path.Combine(path, "pdfDataTest.pdf");

        string pdfName = path2;
        Debug.Log(path2);
        if (System.IO.File.Exists(pdfName))
        {
            DeleteFile(pdfName);
        }
        createPDF(pdfName);
        LaunchFile(pdfName);
        launchPDF(pdfName);
    }

    //auto open pdf
    //first ios then android

    #if UNITY_IOS
    [DllImport("__Internal")]
    internal static extern bool OpenDocumentOnIOS(string path);
#endif

    public static void LaunchFile(string _path)
    {


        if (Application.platform == RuntimePlatform.IPhonePlayer)
        {

            OpenDocumentOnIOS(_path);

        }




#if UNITY_ANDROID 
        Application.OpenURL(filename);
#endif
    }

    public void launchPDF(string filepath)
    {
        Application.OpenURL("File:///" + filepath);
        //Application.OpenURL("http://www.google.com");
    }

    //rules for table
    //1: if someething would force cells where there should be no cells you start from the top and work your way down. the first colspan/rowspan will take priority
    //2: cells must form a table, if the table is 3 collums and your cells line up so that there are 2 on the bottom row, the entire row wont be rendered

    public void createPDF(string filename)
    {
        MemoryStream stream = new MemoryStream();

        Document doc = new Document(PageSize.A4);
        PdfWriter pdfWriter = PdfWriter.GetInstance(doc, stream);   //initalize the pdf

        PdfWriter.GetInstance(doc, new FileStream(path2, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None));  //open the pdf

        BaseFont bfHelv = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
        iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(bfHelv, 7.5f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
        iTextSharp.text.Font fontNormalSmall = new iTextSharp.text.Font(bfHelv, 6.5f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
        iTextSharp.text.Font fontNormalSmallSmall = new iTextSharp.text.Font(bfHelv, 4.5f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
        iTextSharp.text.Font fontBold = new iTextSharp.text.Font(bfHelv, 8.5f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);

        doc.Open();
        doc.NewPage();

#region OppInfo Table
        PdfPTable table = new PdfPTable(8);

        table.SpacingAfter = 10;
        // the cell object
        PdfPCell cell;
        // we add a cell with colspan 3
        cell = new PdfPCell(new Phrase("Operational Info", fontBold));

        //cell.Rowspan = 3;
        cell.BackgroundColor = new iTextSharp.text.BaseColor(0,0,0,50);
        cell.Colspan = 8;
        table.AddCell(cell);

        //Date
        string fullDate = opInfo.dateMonth + "/" + opInfo.dateDay + "/" + opInfo.dateYear;

        cell = new PdfPCell(new Phrase("Date: " + fullDate, fontNormal));
        cell.Colspan = 2;
        table.AddCell(cell);
        ///End Date

        //Location

        cell = new PdfPCell(new Phrase(opInfo.location, fontNormal));
        cell.Colspan = 4;
        cell.Rowspan = 2;

        table.AddCell(cell);
        //End Location

        //Longitude

        cell = new PdfPCell(new Phrase("Longitude: " + opInfo.longitude, fontNormal));
        cell.Colspan = 2;
        table.AddCell(cell);
        //End Longitude

        //Time
        string fullTime = opInfo.timeHour + ":" + opInfo.timeMin + " " + opInfo.amPM;

        cell = new PdfPCell(new Phrase("Time: " + fullTime, fontNormal));
        cell.Colspan = 2;
        table.AddCell(cell);
        //End Time

        //Latitude
        cell = new PdfPCell(new Phrase("Latitude: " + opInfo.latitude, fontNormal));
        cell.Colspan = 2;
        table.AddCell(cell);
        //End Latitude

        //Operioan type
        cell = new PdfPCell(new Phrase("Operation type % no. involved", fontNormalSmall));
        table.AddCell(cell);
        //End Opperation Type

        //Warrent Num
        cell = new PdfPCell(new Phrase("Warrent #: " + opInfo.warrentNumber, fontNormal));
        table.AddCell(cell);
        //End Warrent Num

        //Suspect Number
        cell = new PdfPCell(new Phrase("Suspect #: " + opInfo.suspectNumber, fontNormal));
        table.AddCell(cell);
        //End Suspect Number

        //Hostage Number
        cell = new PdfPCell(new Phrase("Hostage #: " + opInfo.hostageNumber, fontNormal));
        table.AddCell(cell);
        //End Hostage Number

        //Protection Number
        cell = new PdfPCell(new Phrase("Protection #: " + opInfo.protectionNumber, fontNormalSmall));
        table.AddCell(cell);
        //End Protection Number

        //Open Terrain Search
        cell = new PdfPCell(new Phrase("Open Terrain Search #: " + opInfo.openTerrainSearch, fontNormalSmall));
        table.AddCell(cell);
        //End Open Terrain Search

        //Other Num
        cell = new PdfPCell(new Phrase("Other #: " + opInfo.otherNumber, fontNormal));
        cell.Colspan = 2;
        table.AddCell(cell);
        //End Other Num

        //LE Personel

        cell = new PdfPCell(new Phrase("LE Personel", fontNormalSmall));
        table.AddCell(cell);
        //End LE Personel

        //Tactical Num
        cell = new PdfPCell(new Phrase("Tactical #: " + opInfo.tacticalNumber, fontNormal));
        table.AddCell(cell);
        //End Tactical Num

        //EMS Medic Number
        cell = new PdfPCell(new Phrase("Medics #: " + opInfo.emsMedicNumber, fontNormal));
        table.AddCell(cell);
        //End EMS Medic Num

        //Detectives
        cell = new PdfPCell(new Phrase("Detectives #: " + opInfo.detectiveNumber, fontNormalSmall));
        table.AddCell(cell);
        //End Detectives

        //Patrol Num
        cell = new PdfPCell(new Phrase("Patrol #: " + opInfo.patrolNumber, fontNormal));
        table.AddCell(cell);
        //End Patrol Num

        //K9
        cell = new PdfPCell(new Phrase("K9 #: " + opInfo.kNineNumber, fontNormal));
        table.AddCell(cell);
        //End K9

        //other num 2
        cell = new PdfPCell(new Phrase("Other #: " + opInfo.otherPersonalNumber, fontNormal));
        cell.Colspan = 2;
        table.AddCell(cell);
        //End other num 

        doc.Add(table);

        //END OPP INFO SECTION

#endregion OppInfo Table

#region Add Opp Table

        PdfPTable addOppTable = new PdfPTable(9);

        addOppTable.SpacingAfter = 10;
        
        cell = new PdfPCell(new Phrase("Operational Info Continued", fontBold));

        cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0, 50);
        cell.Colspan = 9;
        addOppTable.AddCell(cell);

        //Ems radio channel
        cell = new PdfPCell(new Phrase("EMS Radio Channel:", fontNormal));
        cell.Colspan = 2;
        addOppTable.AddCell(cell);
        //Ems radio channel

        //Ems radio channel entry
        cell = new PdfPCell(new Phrase(addOppInfo.emsRadio, fontNormal));
        //cell.Colspan = 2;
        addOppTable.AddCell(cell);
        //Ems radio channel entry

        //Ems suprvisor lable
        cell = new PdfPCell(new Phrase("EMS Supervisor:", fontNormal));
        cell.Colspan = 2;
        addOppTable.AddCell(cell);
        //Ems suprvisor lable

        //ems supervisor
        cell = new PdfPCell(new Phrase(addOppInfo.emsSupervisor, fontNormal));
        cell.Colspan = 4;
        addOppTable.AddCell(cell);
        //ems supervisor

        //ems units on scene lable
        cell = new PdfPCell(new Phrase("EMS Units On Scene:", fontNormal));
        cell.Colspan = 2;
        addOppTable.AddCell(cell);
        //ems units on scene lable

        //ems units on scene 
        cell = new PdfPCell(new Phrase(addOppInfo.emsUnits1 + ", " + addOppInfo.emsUnits2 + ", " + addOppInfo.emsUnits3, fontNormal));
        cell.Colspan = 7;
        addOppTable.AddCell(cell);
        //ems units on scene 

        //ems staging lable
        cell = new PdfPCell(new Phrase("EMS Staging:", fontNormal));
        cell.Colspan = 2;
        addOppTable.AddCell(cell);
        //ems staging label

        //ems staging loc
        cell = new PdfPCell(new Phrase(addOppInfo.emsStaging, fontNormal));
        cell.Colspan = 7;
        addOppTable.AddCell(cell);
        //ems staging loc

        //fd radio
        cell = new PdfPCell(new Phrase("FD Radio Channel:", fontNormal));
        cell.Colspan = 2;
        addOppTable.AddCell(cell);
        //fd radio

        //FD radio channel entry
        cell = new PdfPCell(new Phrase(addOppInfo.FDradio, fontNormal));
        //cell.Colspan = 2;
        addOppTable.AddCell(cell);
        //Fd radio channel entry

        //FD officer lable
        cell = new PdfPCell(new Phrase("FD Officer:", fontNormal));
        cell.Colspan = 2;
        addOppTable.AddCell(cell);
        //fd officer lable

        //fd officer
        cell = new PdfPCell(new Phrase(addOppInfo.fdOfficer, fontNormal));
        cell.Colspan = 4;
        addOppTable.AddCell(cell);
        //fd officer

        //FD units on scene lable
        cell = new PdfPCell(new Phrase("FD Units On Scene:", fontNormal));
        cell.Colspan = 2;
        addOppTable.AddCell(cell);
        //FD units on scene lable

        //fd units on scene 
        cell = new PdfPCell(new Phrase(addOppInfo.fdUnits1 + ", " + addOppInfo.fdUnits2 + ", " + addOppInfo.fdUnits3, fontNormal));
        cell.Colspan = 7;
        addOppTable.AddCell(cell);
        //fd units on scene 

        //fd staging lable
        cell = new PdfPCell(new Phrase("FD Staging:", fontNormal));
        cell.Colspan = 2;
        addOppTable.AddCell(cell);
        //fd staging label

        //fd staging loc
        cell = new PdfPCell(new Phrase(addOppInfo.fdStaging, fontNormal));
        cell.Colspan = 7;
        addOppTable.AddCell(cell);
        //fd staging loc

        doc.Add(addOppTable);


#endregion Add Opp Table

#region Hospitile Facilites Table
        PdfPTable table2 = new PdfPTable(10);

        table2.SpacingAfter = 10;

        // the cell object
        PdfPCell cell2;

        //Header
        cell = new PdfPCell(new Phrase("Hospital Facilities", fontBold));

        //cell.Rowspan = 3;
        cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0, 50);
        cell.Colspan = 10;
        table2.AddCell(cell);

        //End Header

        //Name
        cell = new PdfPCell(new Phrase("Name", fontNormal));
        cell.Colspan = 2;
        table2.AddCell(cell);
        //End Name

        //Type
        cell = new PdfPCell(new Phrase("Type", fontNormal));
        cell.Colspan = 2;
        table2.AddCell(cell);
        //End Type

        //Type
        cell = new PdfPCell(new Phrase("Address", fontNormal));
        cell.Colspan = 3;
        table2.AddCell(cell);
        //End Type

        //Type
        cell = new PdfPCell(new Phrase("Distance", fontNormal));
        table2.AddCell(cell);
        //End Type

        //Type
        cell = new PdfPCell(new Phrase("ED Contact Number", fontNormal));
        cell.Colspan = 2;
        table2.AddCell(cell);
        //End Type

        //Name Field 1
        cell = new PdfPCell(new Phrase(hosFac.name, fontNormal));
        cell.Colspan = 2;
        table2.AddCell(cell);
        //End Name Field 2

        //Type 1
        cell = new PdfPCell(new Phrase(hosFac.type, fontNormal));
        cell.Colspan = 2;
        table2.AddCell(cell);
        //End Type 1

        //Address 1
        cell = new PdfPCell(new Phrase(hosFac.address, fontNormal));
        cell.Colspan = 3;
        table2.AddCell(cell);
        //End Address 1

        //distance
        cell = new PdfPCell(new Phrase(hosFac.distance, fontNormal));
        table2.AddCell(cell);
        //end distance

        //ed contace 
        cell = new PdfPCell(new Phrase(hosFac.edContactNum, fontNormal));
        cell.Colspan = 2;
        table2.AddCell(cell);
        //End ed contact 

        //Name Field 2
        cell = new PdfPCell(new Phrase(hosFac.name2, fontNormal));
        cell.Colspan = 2;
        table2.AddCell(cell);
        //End Name Field 2

        //Type 2
        cell = new PdfPCell(new Phrase(hosFac.type2, fontNormal));
        cell.Colspan = 2;
        table2.AddCell(cell);
        //End Type 2

        //Address 2
        cell = new PdfPCell(new Phrase(hosFac.address2, fontNormal));
        cell.Colspan = 3;
        table2.AddCell(cell);
        //End Address 2

        //distance 2
        cell = new PdfPCell(new Phrase(hosFac.distance2, fontNormal));
        table2.AddCell(cell);
        //end distance 2

        //ed contace 2
        cell = new PdfPCell(new Phrase(hosFac.edContactNum2, fontNormal));
        cell.Colspan = 2;
        table2.AddCell(cell);
        //End ed contact 2

        //Name Field 3
        cell = new PdfPCell(new Phrase(hosFac.name3, fontNormal));
        cell.Colspan = 2;
        table2.AddCell(cell);
        //End Name Field 3

        //Type 3
        cell = new PdfPCell(new Phrase(hosFac.type3, fontNormal));
        cell.Colspan = 2;
        table2.AddCell(cell);
        //End Type 3

        //Address 3
        cell = new PdfPCell(new Phrase(hosFac.address3, fontNormal));
        cell.Colspan = 3;
        table2.AddCell(cell);
        //End Address 3

        //distance 3
        cell = new PdfPCell(new Phrase(hosFac.distance3, fontNormal));
        table2.AddCell(cell);
        //end distance 3

        //ed contace 3
        cell = new PdfPCell(new Phrase(hosFac.edContactNum3, fontNormal));
        cell.Colspan = 2;
        table2.AddCell(cell);
        //End ed contact 3

        doc.Add(table2);

#endregion Hospitile Facilites Table

#region HelicopterPlan
        //8 sections
        PdfPTable table3 = new PdfPTable(8);

        table3.SpacingAfter = 10;

        // the cell object
        PdfPCell cell3;

        //Header
        cell = new PdfPCell(new Phrase("Helicopter Plan", fontBold));

        //cell.Rowspan = 3;
        cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0, 50);
        cell.Colspan = 8;
        table3.AddCell(cell);

        //Primary Aircraft Name
        cell = new PdfPCell(new Phrase("Primary Aircraft: " + heliPlan.primaryAircraft, fontNormalSmall));
        cell.Colspan = 2;
        table3.AddCell(cell);
        //End Aircraft Name

        //Primary Contact Num
        cell = new PdfPCell(new Phrase("Contact No: " + heliPlan.contactNum, fontNormalSmall));
        cell.Colspan = 2;
        table3.AddCell(cell);
        //End Primary Contact Num

        //Alternate Aircraft
        cell = new PdfPCell(new Phrase("Backup Aircraft: " + heliPlan.altAircraft, fontNormalSmall));
        cell.Colspan = 2;
        table3.AddCell(cell);
        //End Alternate Aircraft

        //Alternate Aircraft No
        cell = new PdfPCell(new Phrase("Backup Contact: " + heliPlan.altAirConNum, fontNormalSmall));
        cell.Colspan = 2;
        table3.AddCell(cell);
        //End Alt Aircraft No

        //Landing zone
        cell = new PdfPCell(new Phrase("Landing Zone", fontNormal));
        cell.Rowspan = 2;
        table3.AddCell(cell);
        //End Landing Zone

        //Address
        cell = new PdfPCell(new Phrase("LZ Address: " + heliPlan.landingAddress, fontNormalSmall));
        cell.Colspan = 3;
        table3.AddCell(cell);
        //End Address

        //latitude
        cell = new PdfPCell(new Phrase("Latitude: " + heliPlan.landLat, fontNormal));
        cell.Colspan = 2;
        table3.AddCell(cell);
        //End latitude

        //longitude
        cell = new PdfPCell(new Phrase("Longitude: " + heliPlan.landLong, fontNormal));
        cell.Colspan = 2;
        table3.AddCell(cell);
        //End longitude

        //LZ Type
        cell = new PdfPCell(new Phrase("LZ Type: " + heliPlan.landingType, fontNormal));
        cell.Colspan = 3;
        table3.AddCell(cell);
        //End LZ Type

        //Obstruction
        cell = new PdfPCell(new Phrase("Obstruction: " + heliPlan.obstruction, fontNormal));
        cell.Colspan = 2;
        table3.AddCell(cell);
        //End Obstruction

        //Obstruction2
        cell = new PdfPCell(new Phrase("Obstruction: " + heliPlan.obstruction2, fontNormal));
        cell.Colspan = 2;
        table3.AddCell(cell);
        //End Obstruction 2

        //MRSG 
        cell = new PdfPCell(new Phrase("MGRS: " + heliPlan.mgrs, fontNormal));
        cell.Colspan = 8;
        table3.AddCell(cell);
        //End MGRS 


        doc.Add(table3);

#endregion HelicopterPlan

#region Weather

        PdfPTable table4 = new PdfPTable(25);

        table4.SpacingAfter = 10;

        // the cell object
        PdfPCell cell4;

        //Header
        cell = new PdfPCell(new Phrase("Weather", fontBold));

        //cell.Rowspan = 3;
        cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0, 50);
        cell.Colspan = 25;
        table4.AddCell(cell);

        //Temp Hi
        cell = new PdfPCell(new Phrase("Temp Hi: " + weather.tempHi, fontNormal));
        cell.Colspan = 3;
        table4.AddCell(cell);
        //End Temp Hi

        //Precip
        cell = new PdfPCell(new Phrase("Precip: " + weather.precip + "%", fontNormal));
        cell.Colspan = 3;
        table4.AddCell(cell);
        //Precip

        //Heat Index
        cell = new PdfPCell(new Phrase("Heat Index: " + weather.heatInded + " F", fontNormal));
        cell.Colspan = 3;
        table4.AddCell(cell);
        //End Heat Index

        //Hidration and Rest Guide
        cell = new PdfPCell(new Phrase("Hydration & Rest Guide (for operations >4 hrs)", fontNormal));
        cell.HorizontalAlignment = Element.ALIGN_CENTER;
        cell.Colspan = 17;
        table4.AddCell(cell);
        //End Hidration and Rest Guide

        //Temp Lo
        cell = new PdfPCell(new Phrase("Temp Lo: " + weather.tempLow, fontNormal));
        cell.Colspan = 3;
        table4.AddCell(cell);
        //End Temp Lo

        //Precip
        cell = new PdfPCell(new Phrase("Sunrise: " + weather.sunrise, fontNormal));
        cell.Colspan = 3;
        table4.AddCell(cell);
        //Precip

        //Cold Risk

        if (weather.coldRisk == true)
        {
            cell = new PdfPCell(new Phrase("Cold risk: Yes", fontNormalSmall));
            cell.Colspan = 3;
            table4.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("Cold Risk: No", fontNormalSmall));
            cell.Colspan = 3;
            table4.AddCell(cell);
        }
        //Cold Risk

        //WB Temp
        cell = new PdfPCell(new Phrase("WB Temp", fontNormal));
        cell.Colspan = 3;
        table4.AddCell(cell);
        //End WB Temp

        //<60
        if (weather.weatherBool1 == true)
        {
            cell = new PdfPCell(new Phrase("<60", fontNormal));
            cell.Colspan = 2;
            cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 102, 100);
            table4.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("<60", fontNormal));
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        //<60

        //60-78
        if (weather.weatherBool2 == true)
        {
            cell = new PdfPCell(new Phrase("60-78", fontNormal));
            cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 102, 100);
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("60-78", fontNormal));
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        //60-78

        //78-82
        if (weather.weatherBool3 == true)
        {
            cell = new PdfPCell(new Phrase("78-82", fontNormal));
            cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 102, 100);
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("78-82", fontNormal));
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        //78-82

        //82-85
        if (weather.weatherBool4 == true)
        {
            cell = new PdfPCell(new Phrase("82-85", fontNormal));
            cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 102, 100);
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("82-85", fontNormal));
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        //End 82-85

        //85-88
        if (weather.weatherBool5)
        {
            cell = new PdfPCell(new Phrase("85-88", fontNormal));
            cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 102, 100);
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("85-88", fontNormal));
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        //End 85-88

        //88-90
        if (weather.weatherBool6)
        {
            cell = new PdfPCell(new Phrase("88-90", fontNormal));
            cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 102, 100);
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("88-90", fontNormal));
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        //End 88-90

        //>90
        if (weather.weatherBool7)
        {
            cell = new PdfPCell(new Phrase(">90", fontNormal));
            cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 102, 100);
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase(">90", fontNormal));
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        //>90

        //Wind (mph)
        cell = new PdfPCell(new Phrase("Wind (mph): " + weather.windSpeed, fontNormal));
        cell.Colspan = 3;
        table4.AddCell(cell);
        //End Wind (mph)

        //Sunset
        cell = new PdfPCell(new Phrase("Sunset: " + weather.sunset, fontNormal));
        cell.Colspan = 3;
        table4.AddCell(cell);
        //Sunset

        //uniform adjustments
        if(weather.uniAdjust == true)
        {
            cell = new PdfPCell(new Phrase("uni adjust: No ", fontNormalSmall));
            cell.Colspan = 3;
            table4.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("uni adjust: No", fontNormalSmall));
            cell.Colspan = 3;
            table4.AddCell(cell);
        }
        
        //end uniform adjustements

        //H20 Qt/hr
        cell = new PdfPCell(new Phrase("H20 Qt/Hr", fontNormal));
        cell.Colspan = 3;
        table4.AddCell(cell);
        //End H20 Qt/hr

        //0.5
        if (weather.weatherBool1 == true)
        {
            cell = new PdfPCell(new Phrase("0.5", fontNormal));
            cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 102, 100);
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("0.5", fontNormal));
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        //end 0.5

        //0.5
        if (weather.weatherBool2 == true)
        {
            cell = new PdfPCell(new Phrase("0.5", fontNormal));
            cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 102, 100);
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("0.5", fontNormal));
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        //end 0.5

        //0.5
        if (weather.weatherBool3 == true)
        {
            cell = new PdfPCell(new Phrase("0.5", fontNormal));
            cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 102, 100);
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("0.5", fontNormal));
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        //end 0.5

        //0.75
        if (weather.weatherBool4 == true)
        {
            cell = new PdfPCell(new Phrase("0.75", fontNormal));
            cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 102, 100);
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("0.75", fontNormal));
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        //end 0.75

        //1.0
        if(weather.weatherBool5 == true)
        {
            cell = new PdfPCell(new Phrase("1.0", fontNormal));
            cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 102, 100);
            cell.Colspan = 2;
            table4.AddCell(cell);

        }
        else
        {
            cell = new PdfPCell(new Phrase("1.0", fontNormal));
            cell.Colspan = 2;
            table4.AddCell(cell);

        }
        //end 1.0

        //1.5
        if(weather.weatherBool6 == true)
        {
            cell = new PdfPCell(new Phrase("1.5", fontNormal));
            cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 102, 100);
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("1.5", fontNormal));
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        //end 1.5

        //2.0
        if(weather.weatherBool7 == true)
        {
            cell = new PdfPCell(new Phrase("2.0", fontNormal));
            cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 102, 100);
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("2.0", fontNormal));
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        //end 2.0

        //humity
        cell = new PdfPCell(new Phrase("Humidity (%): " + weather.humidty, fontNormalSmall));
        cell.Colspan = 3;
        table4.AddCell(cell);
        //end humity

        //Night Ops
        if(weather.nightOps == true)
        {
            cell = new PdfPCell(new Phrase("Night Ops: Yes", fontNormalSmall));
            cell.Colspan = 6;
            table4.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("Night Ops: No", fontNormalSmall));
            cell.Colspan = 6;
            table4.AddCell(cell);
        }
        //End Night opps


        //Rest min/hr
        cell = new PdfPCell(new Phrase("Rest min/hr", fontNormal));
        cell.Colspan = 3;
        table4.AddCell(cell);
        //End min/hr

        //0
        if(weather.weatherBool1 == true)
        {
            cell = new PdfPCell(new Phrase("0", fontNormal));
            cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 102, 100);
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("0", fontNormal));
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        //0

        //0
        if(weather.weatherBool2 == true)
        {
            cell = new PdfPCell(new Phrase("0", fontNormal));
            cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 102, 100);
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("0", fontNormal));
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        //0

        //0
        if (weather.weatherBool3 == true)
        {
            cell = new PdfPCell(new Phrase("0", fontNormal));
            cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 102, 100);
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("0", fontNormal));
            cell.Colspan = 2;
            table4.AddCell(cell);

        }//0

        //10
        if(weather.weatherBool4 == true)
        {
            cell = new PdfPCell(new Phrase("10", fontNormal));
            cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 102, 100);
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("10", fontNormal));
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        //10

        //15
        if(weather.weatherBool5 == true)
        {
            cell = new PdfPCell(new Phrase("15", fontNormal));
            cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 102, 100);
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("15", fontNormal));
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        //15

        //30
        if(weather.weatherBool6 == true)
        {
            cell = new PdfPCell(new Phrase("30", fontNormal));
            cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 102, 100);
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("30", fontNormal));
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        //30

        //40
        if(weather.weatherBool7 == true)
        {
            cell = new PdfPCell(new Phrase("40", fontNormal));
            cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 102, 100);
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("40", fontNormal));
            cell.Colspan = 2;
            table4.AddCell(cell);
        }
        //40

        //Rec 1
        cell = new PdfPCell(new Phrase("Recs: ", fontNormal));
        cell.Colspan = 3;
        table4.AddCell(cell);
        //Rec 1

        //rec 1-3
        cell = new PdfPCell(new Phrase(weather.recs + ", " + weather.recs2 + ", " + weather.recs3, fontNormal));
        cell.Colspan = 22;
        table4.AddCell(cell);
        //rec 1-3
        doc.Add(table4);

#endregion Weather

#region Animal Threats
        PdfPTable table5 = new PdfPTable(13);

        table5.SpacingAfter = 13;
        // the cell object
        // we add a cell with colspan 3
        cell = new PdfPCell(new Phrase("Animal Threats", fontBold));

        //cell.Rowspan = 3;
        cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0, 50);
        cell.Colspan = 13;
        table5.AddCell(cell);

        //Police dogs
        cell = new PdfPCell(new Phrase("Police Dogs: ", fontNormal));
        cell.Colspan = 2;
        table5.AddCell(cell);
        //End Police dogs

        //Police Dog Bool
        if(anThreat.policeDogs == true)
        {
            cell = new PdfPCell(new Phrase("Police Dogs: Yes", fontNormal));
            table5.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("Police Dogs: No", fontNormal));
            table5.AddCell(cell);

        }
        //End Police Dog Bool

        //Number of Police Dog
        cell = new PdfPCell(new Phrase("#: " + anThreat.policeDogNum, fontNormal));
        table5.AddCell(cell);
        //Num of Police Dog

        //Police vet name
        cell = new PdfPCell(new Phrase("Police Vet: " + anThreat.policeVetName, fontNormal));
        cell.Colspan = 3;
        table5.AddCell(cell);
        //end police vet name

        //vet contact no
        cell = new PdfPCell(new Phrase("Police Vet No: " + anThreat.vetContactNum, fontNormalSmall));
        cell.Colspan = 3;
        table5.AddCell(cell);
        //End vet contact no

        //vet after hours
        cell = new PdfPCell(new Phrase("After Hours Contact No: " + anThreat.afterHoursContactNum, fontNormalSmall));
        cell.Colspan = 3;
        table5.AddCell(cell);
        //vet after hours

        //Police dog name
        cell = new PdfPCell(new Phrase("Police Dog Name: " + anThreat.policeDogName, fontNormal));
        cell.Colspan = 3;
        table5.AddCell(cell);
        //End police dog name

        //Police Vet Address
        cell = new PdfPCell(new Phrase("Police Vet Address: " + anThreat.policeVetAddressLn1 + " " + anThreat.policeVetAddressLn2, fontNormal));
        cell.Colspan = 10;
        table5.AddCell(cell);
        //End Police vet address

        //Domestic Animal

        cell = new PdfPCell(new Phrase("Domestic Animals: ", fontNormal));
        cell.Colspan = 2;
        table5.AddCell(cell);
        ///End Domestic Animal

        //domestic bool
        if(anThreat.domesticAnimals == true)
        {
            cell = new PdfPCell(new Phrase("Yes", fontNormal));
            table5.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("No", fontNormal));
            table5.AddCell(cell);
        }
        //domestic bool

        //Domestic Animal Number
        cell = new PdfPCell(new Phrase("#: " + anThreat.domesticNum, fontNormal));
        table5.AddCell(cell);
        //End Domestic Animal Number

        //Domestic Animal Type1
        cell = new PdfPCell(new Phrase("Type: " + anThreat.domesticTypes, fontNormal));
        cell.Colspan = 2;
        table5.AddCell(cell);
        //Domestic Animal Type1

        //Domestic Animal Type2
        cell = new PdfPCell(new Phrase("Type: " + anThreat.domesticTypes2, fontNormal));
        cell.Colspan = 2;
        table5.AddCell(cell);
        //Domestic Animal Type2

        //Domestic Animal Type3
        cell = new PdfPCell(new Phrase("Type: " + anThreat.domesticTypes3, fontNormal));
        cell.Colspan = 2;
        table5.AddCell(cell);
        //Domestic Animal Type3

        //Animal Control Number
        cell = new PdfPCell(new Phrase("Animal Control Num: " + anThreat.animalControlNumber, fontNormal));
        cell.Colspan = 3;
        cell.Rowspan = 2;
        table5.AddCell(cell);
        //End Animal Control Number

        //Poisionous Snakes
        cell = new PdfPCell(new Phrase("Poisonous Snakes: ", fontNormal));
        cell.Colspan = 2;
        table5.AddCell(cell);
        //End Poisionous Snakes

        //Posionous snakes bool
        if(anThreat.poisonousSnakes == true)
        {
            cell = new PdfPCell(new Phrase("Yes", fontNormal));
            table5.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("No", fontNormal));
            table5.AddCell(cell);
        }

        //Posionous snakes bool

        //Number of Posion
        cell = new PdfPCell(new Phrase("#: " + anThreat.poisonNum, fontNormal));
        table5.AddCell(cell);
        //Num of pison

        //Posion Type 1
        cell = new PdfPCell(new Phrase("Type: " + anThreat.poisonousTypes, fontNormal));
        cell.Colspan = 2;
        table5.AddCell(cell);
        //End Posion Type 1

        //Posion Type 2
        cell = new PdfPCell(new Phrase("Type: " + anThreat.poisonousTypes2, fontNormal));
        cell.Colspan = 2;
        table5.AddCell(cell);
        //End Posion Type 2

        //Posion Type 3
        cell = new PdfPCell(new Phrase("Type: " + anThreat.poisonousTypes3, fontNormal));
        cell.Colspan = 2;
        table5.AddCell(cell);
        //End Posion Type 3

        //Wild Animals
        cell = new PdfPCell(new Phrase("Wild Animals: ", fontNormal));
        cell.Colspan = 2;
        table5.AddCell(cell);
        //End Wild Animals

        //Wild animals bool
        if(anThreat.wildAnimals == true)
        {
            cell = new PdfPCell(new Phrase("Yes", fontNormal));
            table5.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("No", fontNormal));
            table5.AddCell(cell);
        }
        //Wild animals bool

        //Number of Wild Animals
        cell = new PdfPCell(new Phrase("#: " + anThreat.wildNum, fontNormal));
        table5.AddCell(cell);
        //Num of Wild Animal

        //Posion Type 1
        cell = new PdfPCell(new Phrase("Type: " + anThreat.wildAnimalTypes, fontNormal));
        cell.Colspan = 2;
        table5.AddCell(cell);
        //End Posion Type 1

        //Posion Type 2
        cell = new PdfPCell(new Phrase("Type: " + anThreat.wildAnimalTypes2, fontNormal));
        cell.Colspan = 2;
        table5.AddCell(cell);
        //End Posion Type 2

        //Posion Type 3
        cell = new PdfPCell(new Phrase("Type: " + anThreat.wildAnimalTypes3, fontNormal));
        cell.Colspan = 2;
        table5.AddCell(cell);
        //End Posion Type 3

        //Obtain via dispatch bool
        if(anThreat.obtainViaDispatch == true)
        {
            cell = new PdfPCell(new Phrase("Obtain via Dispatch: Yes", fontNormalSmall));
            cell.Colspan = 3;
            table5.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("Obtain via Dispatch: No", fontNormalSmall));
            cell.Colspan = 3;
            table5.AddCell(cell);
        }
        //End Obtain via dispatch bool


        doc.Add(table5);

#endregion Animal Threats

#region Plant Threats

        PdfPTable PlantThreatsTable = new PdfPTable(13);

        PlantThreatsTable.SpacingAfter = 13;
        // the cell object
        // we add a cell with colspan 3
        cell = new PdfPCell(new Phrase("Plant Threats", fontBold));

        //cell.Rowspan = 3;
        cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0, 50);
        cell.Colspan = 13;
        PlantThreatsTable.AddCell(cell);

        //Posion Plant Exposure Likly
        cell = new PdfPCell(new Phrase("Poisonous plant exposure likely? ", fontNormal));
        cell.Colspan = 3;
        PlantThreatsTable.AddCell(cell);
        //End Posion Plant Exposure Likly

        //bool Holder
        if(plTreats.poisonousPlatExpo == true)
        {
            cell = new PdfPCell(new Phrase("Yes", fontNormal));
            PlantThreatsTable.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("No", fontNormal));
            PlantThreatsTable.AddCell(cell);
        }
        //bool holder

        //types 1
        cell = new PdfPCell(new Phrase("Type: " + plTreats.poisonousPlantTypes1, fontNormal));
        cell.Colspan = 2;
        PlantThreatsTable.AddCell(cell);
        //end type 1

        //types 2
        cell = new PdfPCell(new Phrase("Type: " + plTreats.poisonousPlantTypes2, fontNormal));
        cell.Colspan = 2;
        PlantThreatsTable.AddCell(cell);
        //end type 2

        //types 3
        cell = new PdfPCell(new Phrase("Type: " + plTreats.poisonousPlantTypes3, fontNormal));
        cell.Colspan = 2;
        PlantThreatsTable.AddCell(cell);
        //end type 3

        //posioin control num
        cell = new PdfPCell(new Phrase("Poison Control Num: " + plTreats.poisonControlNum, fontNormal));
        cell.Colspan = 3;
        cell.Rowspan = 2;
        PlantThreatsTable.AddCell(cell);
        //end posion control num

        //Posion Plant Exposure Likly
        cell = new PdfPCell(new Phrase("Uniform Adjustments needed? ", fontNormal));
        cell.Colspan = 3;
        PlantThreatsTable.AddCell(cell);
        //End Posion Plant Exposure Likly

        //bool Holder
        if(plTreats.uniformAdjust == true)
        {
            cell = new PdfPCell(new Phrase("Yes", fontNormal));
            PlantThreatsTable.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("No", fontNormal));
            PlantThreatsTable.AddCell(cell);
        }
        //bool holder

        //types 1
        cell = new PdfPCell(new Phrase("Type: " + plTreats.recomendationsForUniforms1, fontNormal));
        cell.Colspan = 2;
        PlantThreatsTable.AddCell(cell);
        //end type 1

        //types 2
        cell = new PdfPCell(new Phrase("Type: " + plTreats.recomendationsForUniforms2, fontNormal));
        cell.Colspan = 2;
        PlantThreatsTable.AddCell(cell);
        //end type 2

        //types 3
        cell = new PdfPCell(new Phrase("Type: " + plTreats.recomendationsForUniforms3, fontNormal));
        cell.Colspan = 2;
        PlantThreatsTable.AddCell(cell);
        //end type 3
        doc.Add(PlantThreatsTable);

#endregion Plant Threats

#region Hazardous Materials

        PdfPTable HazMatTable = new PdfPTable(16);

        HazMatTable.SpacingAfter = 10;
        // the cell object
        // we add a cell with colspan 3
        cell = new PdfPCell(new Phrase("Hazardous Materials", fontBold));

        //cell.Rowspan = 3;
        cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0, 50);
        cell.Colspan = 16;
        HazMatTable.AddCell(cell);

        //ignition risks
        cell = new PdfPCell(new Phrase("Ignition risks or NFDD use anticipated? ", fontNormal));
        cell.Colspan = 3;
        HazMatTable.AddCell(cell);
        //ingition risks

        //bool ignition
        if(hazMat.ignitingRisks == true)
        {
            cell = new PdfPCell(new Phrase("Yes", fontNormal));
            HazMatTable.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("No", fontNormal));
            HazMatTable.AddCell(cell);
        }
        //bool ignition

        //Types 1
        cell = new PdfPCell(new Phrase("Type: " + hazMat.ignitingTypes1, fontNormal));
        cell.Colspan = 2;
        HazMatTable.AddCell(cell);
        //Types 1

        //Types 2
        cell = new PdfPCell(new Phrase("Type: " + hazMat.ignitingTypes2, fontNormal));
        cell.Colspan = 2;
        HazMatTable.AddCell(cell);
        //Types 2

        //Types 3
        cell = new PdfPCell(new Phrase("Type: " + hazMat.ignitingTypes3, fontNormal));
        cell.Colspan = 2;
        HazMatTable.AddCell(cell);
        //Types 3

        //Recomendations
        cell = new PdfPCell(new Phrase("Recommendations", fontNormal));
        cell.Colspan = 4;
        HazMatTable.AddCell(cell);
        //Recomendations

        //hazmat team
        cell = new PdfPCell(new Phrase("HazMat Team Num: " + hazMat.hazmatTeamNumber, fontNormal));
        cell.Colspan = 2;
        cell.Rowspan = 2;
        HazMatTable.AddCell(cell);
        //haz mat team

        //clandestine lab
        cell = new PdfPCell(new Phrase("Clandestine Lab", fontNormal));
        cell.Colspan = 3;
        HazMatTable.AddCell(cell);
        //clandestine labs

        //bool ignition
        if(hazMat.cladestineLab == true)
        {
            cell = new PdfPCell(new Phrase("Yes", fontNormal));
            HazMatTable.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("No", fontNormal));
            HazMatTable.AddCell(cell);
        }

        //bool ignition

        //Types 1
        cell = new PdfPCell(new Phrase("Type: " + hazMat.cladestineTypes1, fontNormal));
        cell.Colspan = 2;
        HazMatTable.AddCell(cell);
        //Types 1

        //Types 2
        cell = new PdfPCell(new Phrase("Type: " + hazMat.cladestineTypes2, fontNormal));
        cell.Colspan = 2;
        HazMatTable.AddCell(cell);
        //Types 2

        //Types 3
        cell = new PdfPCell(new Phrase("Type: " + hazMat.cladestineTypes3, fontNormal));
        cell.Colspan = 2;
        HazMatTable.AddCell(cell);
        //Types 3

        //nomex
        if(hazMat.nomiex == true)
        {
            cell = new PdfPCell(new Phrase("Nomex: Yes", fontNormal));
            cell.Colspan = 2;
            HazMatTable.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("Nomex: No", fontNormal));
            cell.Colspan = 2;
            HazMatTable.AddCell(cell);
        }
        //nomex.

        //ppe
        if(hazMat.otherSpecialPPE == true)
        {
            cell = new PdfPCell(new Phrase("PPE: Yes", fontNormal));
            cell.Colspan = 2;
            HazMatTable.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("PPE: No", fontNormal));
            cell.Colspan = 2;
            HazMatTable.AddCell(cell);
        }
        //ppe

        //Industrial chem
        cell = new PdfPCell(new Phrase("Industrial Chem", fontNormal));
        cell.Colspan = 3;
        HazMatTable.AddCell(cell);
        //industrial chem

        //bool ignition
        if(hazMat.industrialChemicals == true)
        {
            cell = new PdfPCell(new Phrase("Yes", fontNormal));
            HazMatTable.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("No", fontNormal));
            HazMatTable.AddCell(cell);
        }
        //bool ignition

        //Types 1
        cell = new PdfPCell(new Phrase("Type: " + hazMat.ignitingTypes1, fontNormal));
        cell.Colspan = 2;
        HazMatTable.AddCell(cell);
        //Types 1

        //Types 2
        cell = new PdfPCell(new Phrase("Type: " + hazMat.ignitingTypes2, fontNormal));
        cell.Colspan = 2;
        HazMatTable.AddCell(cell);
        //Types 2

        //Types 3
        cell = new PdfPCell(new Phrase("Type: " + hazMat.ignitingTypes3, fontNormal));
        cell.Colspan = 2;
        HazMatTable.AddCell(cell);
        //Types 3

        //Rec List 1
        cell = new PdfPCell(new Phrase("Rec: " + hazMat.recListOne, fontNormal));
        cell.Colspan = 4;
        HazMatTable.AddCell(cell);
        //Rec List 1

        //obtain bool
        if(hazMat.obtainViaDispatch == true)
        {
            cell = new PdfPCell(new Phrase("Obtain via Dispatch: Yes", fontNormal));
            cell.Colspan = 2;
            cell.Rowspan = 2;
            HazMatTable.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("Obtain via Dispatch: No", fontNormal));
            cell.Colspan = 2;
            cell.Rowspan = 2;
            HazMatTable.AddCell(cell);
        }

        //obtain bool

        //Other Haz Mat
        cell = new PdfPCell(new Phrase("Other HazMats?", fontNormal));
        cell.Colspan = 3;
        HazMatTable.AddCell(cell);
        //Other Haz Mat

        //bool ignition
        if(hazMat.otherHazMat == true)
        {
            cell = new PdfPCell(new Phrase("Yes", fontNormal));
            HazMatTable.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("No", fontNormal));
            HazMatTable.AddCell(cell);
        }
        //bool ignition

        //Types 1
        cell = new PdfPCell(new Phrase("Type: " + hazMat.otherHazMatTypes1, fontNormal));
        cell.Colspan = 2;
        HazMatTable.AddCell(cell);
        //Types 1

        //Types 2
        cell = new PdfPCell(new Phrase("Type: " + hazMat.otherHazMatTypes2, fontNormal));
        cell.Colspan = 2;
        HazMatTable.AddCell(cell);
        //Types 2

        //Types 3
        cell = new PdfPCell(new Phrase("Type: " + hazMat.otherHazMatTypes3, fontNormal));
        cell.Colspan = 2;
        HazMatTable.AddCell(cell);
        //Types 3

        //Rec List 1
        cell = new PdfPCell(new Phrase("Rec: " + hazMat.recListTwo, fontNormal));
        cell.Colspan = 4;
        HazMatTable.AddCell(cell);
        //Rec List 1

        doc.Add(HazMatTable);
#endregion Hazardous Materials

#region Public Works
        PdfPTable pubWorksTable = new PdfPTable(14);

        pubWorksTable.SpacingAfter = 35;
        // the cell object
        // we add a cell with colspan 3
        cell = new PdfPCell(new Phrase("Public Works", fontBold));

        //cell.Rowspan = 3;
        cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0, 50);
        cell.Colspan = 14;
        pubWorksTable.AddCell(cell);

        //Street Closings
        cell = new PdfPCell(new Phrase("Street Closings", fontNormal));
        cell.Colspan = 2;
        pubWorksTable.AddCell(cell);
        //Street Closings

        //bool Street
        if(pubWorks.streedCleaning == true)
        {
            cell = new PdfPCell(new Phrase("Yes", fontNormal));
            cell.Colspan = 1;
            pubWorksTable.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("No", fontNormal));
            cell.Colspan = 1;
            pubWorksTable.AddCell(cell);
        }
        //End bool street

        //location street closing
        cell = new PdfPCell(new Phrase("Loc: " + pubWorks.streatCleaningLoc, fontNormal));
        cell.Colspan = 3;
        pubWorksTable.AddCell(cell);
        //End  location street closing

        //gate access
        cell = new PdfPCell(new Phrase("Gate Access", fontNormal));
        cell.Colspan = 2;
        pubWorksTable.AddCell(cell);
        //gate access

        //gate bool
        if(pubWorks.gateAccess == true)
        {
            cell = new PdfPCell(new Phrase("Yes", fontNormal));
            cell.Colspan = 1;
            pubWorksTable.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("No", fontNormal));
            cell.Colspan = 1;
            pubWorksTable.AddCell(cell);
        }
        //gate bool

        //gate loc
        cell = new PdfPCell(new Phrase("Gate Loc: " + pubWorks.gateLoc, fontNormal));
        cell.Colspan = 3;
        pubWorksTable.AddCell(cell);
        //gate loc

        //gate code
        cell = new PdfPCell(new Phrase("Code: " + pubWorks.gateCode, fontNormal));
        cell.Colspan = 2;
        pubWorksTable.AddCell(cell);
        //gate code

        //road hazards
        cell = new PdfPCell(new Phrase("Road Hazards", fontNormal));
        cell.Colspan = 2;
        pubWorksTable.AddCell(cell);
        //raod hazards

        //road haz bool
        if(pubWorks.roadHazards == true)
        {
            cell = new PdfPCell(new Phrase("Yes", fontNormal));
            pubWorksTable.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("No", fontNormal));
            pubWorksTable.AddCell(cell);
        }

        //road haz bool

        //road haz loc
        cell = new PdfPCell(new Phrase("Loc:" + pubWorks.roadHazardLocation, fontNormal));
        cell.Colspan = 11;
        pubWorksTable.AddCell(cell);
        //road haz loc
        
        doc.Add(pubWorksTable);
#endregion Public Works

#region Extended Opps

        PdfPTable extOppsTable = new PdfPTable(14);

        extOppsTable.SpacingAfter = 10;
        // the cell object
        // we add a cell with colspan 3
        cell = new PdfPCell(new Phrase("Extended Ops", fontBold));

        //cell.Rowspan = 3;
        cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0, 50);
        cell.Colspan = 14;
        extOppsTable.AddCell(cell);

        //Street Closings
        cell = new PdfPCell(new Phrase("Work cycles determined", fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //Street Closings

        //work bool
        if(exOpp.workCyclesDetermined == true)
        {
            cell = new PdfPCell(new Phrase("Yes", fontNormal));
            cell.Colspan = 1;
            extOppsTable.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("No", fontNormal));
            cell.Colspan = 1;
            extOppsTable.AddCell(cell);
        }
        //work bool

        //work list
        cell = new PdfPCell(new Phrase("List: " + exOpp.workCycleList1, fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //work list

        //restroom facilities determined
        cell = new PdfPCell(new Phrase("Restroom facilities determined", fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //restroom facilities determined

        //work bool
        if(exOpp.restroomFacityDet == true)
        {
            cell = new PdfPCell(new Phrase("Yes", fontNormal));
            cell.Colspan = 1;
            extOppsTable.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("No", fontNormal));
            cell.Colspan = 1;
            extOppsTable.AddCell(cell);
        }
        //work bool

        //work list
        cell = new PdfPCell(new Phrase("List: " + exOpp.restromList1, fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //work list
        ///Line 2
        //Street Closings
        cell = new PdfPCell(new Phrase("", fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //Street Closings

        //work bool
        cell = new PdfPCell(new Phrase("", fontNormal));
        cell.Colspan = 1;
        extOppsTable.AddCell(cell);
        //work bool

        //work list
        cell = new PdfPCell(new Phrase("List: " + exOpp.workCycleList2, fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //work list

        //restroom facilities determined
        cell = new PdfPCell(new Phrase("", fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //restroom facilities determined

        //work bool
        cell = new PdfPCell(new Phrase("", fontNormal));
        cell.Colspan = 1;
        extOppsTable.AddCell(cell);
        //work bool

        //work list
        cell = new PdfPCell(new Phrase("List: " + exOpp.restromList2, fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //work list

        ///Line 3

        //Street Closings
        cell = new PdfPCell(new Phrase("", fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //Street Closings

        //work bool
        cell = new PdfPCell(new Phrase("", fontNormal));
        cell.Colspan = 1;
        extOppsTable.AddCell(cell);
        //work bool

        //work list
        cell = new PdfPCell(new Phrase("List: " + exOpp.workCycleList3, fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //work list

        //restroom facilities determined
        cell = new PdfPCell(new Phrase("", fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //restroom facilities determined

        //work bool
        cell = new PdfPCell(new Phrase("", fontNormal));
        cell.Colspan = 1;
        extOppsTable.AddCell(cell);
        //work bool

        //work list
        cell = new PdfPCell(new Phrase("List: " + exOpp.restromList3, fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //work list
        ///Line 4


        //Street Closings
        cell = new PdfPCell(new Phrase("", fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //Street Closings

        //work bool
        cell = new PdfPCell(new Phrase("", fontNormal));
        cell.Colspan = 1;
        extOppsTable.AddCell(cell);
        //work bool

        //work list
        cell = new PdfPCell(new Phrase("List: " + exOpp.workCycleList4, fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //work list

        //restroom facilities determined
        cell = new PdfPCell(new Phrase("", fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //restroom facilities determined

        //work bool
        cell = new PdfPCell(new Phrase("", fontNormal));
        cell.Colspan = 1;
        extOppsTable.AddCell(cell);
        //work bool

        //work list
        cell = new PdfPCell(new Phrase("List: " + exOpp.restromList4, fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //work list

        ///Nut

        //Nutrition
        cell = new PdfPCell(new Phrase("Nutrition secured", fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //Nutrition

        //work bool
        if(exOpp.nutritionSecured == true)
        {
            cell = new PdfPCell(new Phrase("Yes", fontNormal));
            cell.Colspan = 1;
            extOppsTable.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("No", fontNormal));
            cell.Colspan = 1;
            extOppsTable.AddCell(cell);
        }

        //work bool

        //nutrition list
        cell = new PdfPCell(new Phrase("List: " + exOpp.nutritionalList1, fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //work list

        //restroom facilities determined
        cell = new PdfPCell(new Phrase("Sleep area determined", fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //restroom facilities determined

        //work bool
        if(exOpp.sleepAreaDetermined == true)
        {
            cell = new PdfPCell(new Phrase("Yes", fontNormal));
            cell.Colspan = 1;
            extOppsTable.AddCell(cell);
        }
        else
        {
            cell = new PdfPCell(new Phrase("No", fontNormal));
            cell.Colspan = 1;
            extOppsTable.AddCell(cell);
        }

        //work bool

        //sleep list
        cell = new PdfPCell(new Phrase("List: " + exOpp.sleepAreaList1, fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //work list

        ///line 2

        //Nutrition
        cell = new PdfPCell(new Phrase("", fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //Nutrition

        //work bool
        cell = new PdfPCell(new Phrase("", fontNormal));
        cell.Colspan = 1;
        extOppsTable.AddCell(cell);
        //work bool

        //nutrition list
        cell = new PdfPCell(new Phrase("List: " + exOpp.nutritionalList2, fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //work list

        //restroom facilities determined
        cell = new PdfPCell(new Phrase("", fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //restroom facilities determined

        //work bool
        cell = new PdfPCell(new Phrase("", fontNormal));
        cell.Colspan = 1;
        extOppsTable.AddCell(cell);
        //work bool

        //sleep list
        cell = new PdfPCell(new Phrase("List: " + exOpp.sleepAreaList2, fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //work list

        ///list 3
        ///
                //Nutrition
        cell = new PdfPCell(new Phrase("", fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //Nutrition

        //work bool
        cell = new PdfPCell(new Phrase("", fontNormal));
        cell.Colspan = 1;
        extOppsTable.AddCell(cell);
        //work bool

        //nutrition list
        cell = new PdfPCell(new Phrase("List: " + exOpp.nutritionalList3, fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //work list

        //restroom facilities determined
        cell = new PdfPCell(new Phrase("", fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //restroom facilities determined

        //work bool
        cell = new PdfPCell(new Phrase("", fontNormal));
        cell.Colspan = 1;
        extOppsTable.AddCell(cell);
        //work bool

        //sleep list
        cell = new PdfPCell(new Phrase("List: " + exOpp.sleepAreaList3, fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //work list

        ///list 4
        ///
                //Nutrition
        cell = new PdfPCell(new Phrase("", fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //Nutrition

        //work bool
        cell = new PdfPCell(new Phrase("", fontNormal));
        cell.Colspan = 1;
        extOppsTable.AddCell(cell);
        //work bool

        //nutrition list
        cell = new PdfPCell(new Phrase("List: " + exOpp.nutritionalList4, fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //work list

        //restroom facilities determined
        cell = new PdfPCell(new Phrase("", fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //restroom facilities determined

        //work bool
        cell = new PdfPCell(new Phrase("", fontNormal));
        cell.Colspan = 1;
        extOppsTable.AddCell(cell);
        //work bool

        //sleep list
        cell = new PdfPCell(new Phrase("List: " + exOpp.sleepAreaList4, fontNormal));
        cell.Colspan = 3;
        extOppsTable.AddCell(cell);
        //work list


        doc.Add(extOppsTable);
#endregion Extended Opps

#region Other
        PdfPTable otherTable = new PdfPTable(9);

        otherTable.SpacingAfter = 10;
        // the cell object
        // we add a cell with colspan 3
        cell = new PdfPCell(new Phrase("Other", fontBold));

        //cell.Rowspan = 3;
        cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0, 50);
        cell.Colspan = 9;
        otherTable.AddCell(cell);

        //Other 1
        cell = new PdfPCell(new Phrase(" " + otr.intputOne1, fontNormal));
        cell.Colspan = 3;
        otherTable.AddCell(cell);
        //Other 1

        //Other 1
        cell = new PdfPCell(new Phrase(" " + otr.inputTwo1, fontNormal));
        cell.Colspan = 3;
        otherTable.AddCell(cell);
        //Other 1

        //Other 1
        cell = new PdfPCell(new Phrase(" " + otr.inputThree1, fontNormal));
        cell.Colspan = 3;
        otherTable.AddCell(cell);
        //Other 1

        //Other 1
        cell = new PdfPCell(new Phrase(" " + otr.intputOne2, fontNormal));
        cell.Colspan = 3;
        otherTable.AddCell(cell);
        //Other 1

        //Other 1
        cell = new PdfPCell(new Phrase(" " + otr.inputTwo2, fontNormal));
        cell.Colspan = 3;
        otherTable.AddCell(cell);
        //Other 1

        //Other 1
        cell = new PdfPCell(new Phrase(" " + otr.inputThree2, fontNormal));
        cell.Colspan = 3;
        otherTable.AddCell(cell);
        //Other 1

        //Other 1
        cell = new PdfPCell(new Phrase(" " + otr.intputOne3, fontNormal));
        cell.Colspan = 3;
        otherTable.AddCell(cell);
        //Other 1

        //Other 1
        cell = new PdfPCell(new Phrase(" " + otr.inputTwo3, fontNormal));
        cell.Colspan = 3;
        otherTable.AddCell(cell);
        //Other 1

        //Other 1
        cell = new PdfPCell(new Phrase(" " + otr.inputThree3, fontNormal));
        cell.Colspan = 3;
        otherTable.AddCell(cell);
        //Other 1

        //Other 1
        cell = new PdfPCell(new Phrase(" " + otr.intputOne4, fontNormal));
        cell.Colspan = 3;
        otherTable.AddCell(cell);
        //Other 1

        //Other 1
        cell = new PdfPCell(new Phrase(" " + otr.inputTwo4, fontNormal));
        cell.Colspan = 3;
        otherTable.AddCell(cell);
        //Other 1

        //Other 1
        cell = new PdfPCell(new Phrase(" " + otr.inputThree4, fontNormal));
        cell.Colspan = 3;
        otherTable.AddCell(cell);
        //Other 1

        //Other 1
        cell = new PdfPCell(new Phrase(" " + otr.intputOne5, fontNormal));
        cell.Colspan = 3;
        otherTable.AddCell(cell);
        //Other 1

        //Other 1
        cell = new PdfPCell(new Phrase(" " + otr.inputTwo5, fontNormal));
        cell.Colspan = 3;
        otherTable.AddCell(cell);
        //Other 1

        //Other 1
        cell = new PdfPCell(new Phrase(" " + otr.inputThree5, fontNormal));
        cell.Colspan = 3;
        otherTable.AddCell(cell);
        //Other 1

        doc.Add(otherTable);

#endregion Other


        doc.Close();

        pdfWriter.Close();
        stream.Close();


    }

    //assinges data from input to data model
    public void testEventName()
    {
        string currentEvent = EventSystem.current.currentSelectedGameObject.name;

        Debug.Log(currentEvent);

        Debug.Log(EventSystem.current.currentSelectedGameObject);

        switch (currentEvent)
        {
            //Start Opp Readin
            case "dateMonth":
                int dateMonthValue;
                int.TryParse(dateMonthInput.text, out dateMonthValue);
                opInfo.dateMonth = dateMonthValue;
                break;

            case "dateDay":
                int dateDayValue;
                int.TryParse(dateDayInput.text, out dateDayValue);
                opInfo.dateDay = dateDayValue;
                break;

            case "dateYear":
                int dateYearValue;
                int.TryParse(dateYearInput.text, out dateYearValue);
                opInfo.dateYear = dateYearValue;
                break;

            case "opTimeHour":
                int timeHourValue;
                int.TryParse(timeHourInput.text, out timeHourValue);
                opInfo.timeHour = timeHourValue;
                break;

            case "opTimeMin":
                int timeMinValue;
                int.TryParse(timeMinInput.text, out timeMinValue);
                opInfo.timeMin = timeMinValue;
                break;

            case "AmPm":
                opInfo.amPM = timeAmPMInput.text;
                break;

            case "Latitude":
                opInfo.latitude = latitudeInput.text;
                break;

            case "Longitude":
                opInfo.longitude = longitudeInput.text;
                break;

            case "Location":
                opInfo.location = locationInput.text;
                break;

            case "Warrent NumberIN":
                int warrentNumberValue;
                int.TryParse(warrentNumInput.text, out warrentNumberValue);
                opInfo.warrentNumber = warrentNumberValue;
                break;

            case "SuspectNumberIn":
                int suspectNumberValue;
                int.TryParse(suspectNumInput.text, out suspectNumberValue);
                opInfo.suspectNumber = suspectNumberValue;
                break;

            case "Hostage NumberIN":
                int hostageNumberValue;
                int.TryParse(hostageNumInput.text, out hostageNumberValue);
                opInfo.hostageNumber = hostageNumberValue;
                break;

            case "ProtectionNumInput":
                int protectionNumValue;
                int.TryParse(protectionNumInput.text, out protectionNumValue);
                opInfo.protectionNumber = protectionNumValue;
                break;

            case "Open Terrain Number IN":
                int openTerrainNumValue;
                int.TryParse(openTerrainSearchNumInput.text, out openTerrainNumValue);
                opInfo.openTerrainSearch = openTerrainNumValue;
                break;

            case "Other In":
                int otherNumValue;
                int.TryParse(otherNumInput.text, out otherNumValue);
                opInfo.otherNumber = otherNumValue;
                break;

            case "Tactical Number IN":
                int tacticalNumValue;
                int.TryParse(tacticalNumInput.text, out tacticalNumValue);
                opInfo.tacticalNumber = tacticalNumValue;
                break;

            case "EMS/Medic IN":
                int emsMedicNumValue;
                int.TryParse(emsMedicNumInput.text, out emsMedicNumValue);
                opInfo.emsMedicNumber = emsMedicNumValue;
                break;

            case "Detective Num IN":
                int detectiveNumValue;
                int.TryParse(detectiveNumInput.text, out detectiveNumValue);
                opInfo.detectiveNumber = detectiveNumValue;
                break;

            case "Patrol IN":
                int patrolNumValue;
                int.TryParse(patronNumInput.text, out patrolNumValue);
                opInfo.patrolNumber = patrolNumValue;
                break;

            case "K9 IN":
                int k9NumValue;
                int.TryParse(k9NumInput.text, out k9NumValue);
                opInfo.kNineNumber = k9NumValue;
                break;

            //End Opp Readin

            //Start Add Op Info

            case "EMS Radio IN":
                addOppInfo.emsRadio = emsRadioInput.text;
                break;

            case "EMS Unit One IN":
                addOppInfo.emsUnits1 = emsUnit1Input.text;
                break;

            case "EMS Unit Two IN":
                addOppInfo.emsUnits2 = emsUnit2Input.text;
                break;

            case "EMS Unit Three IN":
                addOppInfo.emsUnits3 = emsUnit3Input.text;
                break;

            case "EMS Staging IN":
                addOppInfo.emsStaging = emsStagingInput.text;
                break;

            case "EMS Supervisior IN":
                addOppInfo.emsSupervisor = emsSupervisorInput.text;
                break;

            case "FD Radio Channel IN":
                addOppInfo.FDradio = fdRadioInput.text;
                break;

            case "FD Units One IN":
                addOppInfo.fdUnits1 = fdUnit1Input.text;
                break;
            case "FD Units Two IN":
                addOppInfo.fdUnits2 = fdUnit2Input.text;
                break;
            case "FD Units Three IN":
                addOppInfo.fdUnits3 = fdUnit3Input.text;
                break;

            case "FD Staging IN":
                addOppInfo.fdStaging = fdStagingInput.text;
                break;

            case "FD Officer IN":
                addOppInfo.fdOfficer = fdOfficerInput.text;
                break;

            //End Add Op Info

            //Start Hospitle 

            case "hosPrimaryName In":
                hosFac.name = primaryNameInput.text;
                break;

            case "hosPrimary Type In":
                hosFac.type = primaryTypeInput.text;
                break;

            case "hosPrimary Address IN":
                hosFac.address = primaryAddressInput.text;
                break;

            case "hosPrimary Distance IN":
                hosFac.distance = primaryDistanceInput.text;
                break;

            case "hosPrimary ED Contact No IN":
                hosFac.edContactNum = primaryEDContactNOInput.text;
                break;

            case "hosSecondaryName IN":
                hosFac.name2 = secondaryNameInput.text;
                break;

            case "hosSecondary Type IN":
                hosFac.type2 = secondaryTypeInput.text;
                break;

            case "hosSecondary Address IN":
                hosFac.address2 = secondaryAddressInput.text;
                break;

            case "hosSecondary Distance IN":
                hosFac.distance2 = secondaryDistanceInput.text;
                break;

            case "hosSecondary ED Contact No IN":
                hosFac.edContactNum2 = secondaryEDContactNOInput.text;
                break;

            case "hosTert Name IN":
                hosFac.name3 = tertNameInput.text;
                break;

            case "hosTert Type IN":
                hosFac.type3 = tertTypeInput.text;
                break;

            case "hosTert Address IN":
                hosFac.address3 = tertAddressInput.text;
                break;

            case "hosTert Distance IN":
                hosFac.distance3 = tertDistanceInput.text;
                break;

            case "hosTert ED Contact No IN":
                hosFac.edContactNum3 = tertEDContactNOInput.text;
                break;

            //End Hospitles

            case "Primary Aircraft IN":
                heliPlan.primaryAircraft = heliPrimaryNameInput.text;
                break;

            case "Primary Contact Num":
                heliPlan.contactNum = heliPrimaryContactNumInput.text;
                break;

            case "Secondary Aircraft IN":
                heliPlan.altAircraft = heliSecondaryNameInput.text;
                break;

            case "Secondary Contact Num IN":
                heliPlan.altAirConNum = heliSecondaryContactNumInput.text;
                break;

            case "Landing Zone Address IN":
                heliPlan.landingAddress = landingZoneAddressInput.text;
                break;

            case "Landing Zone Type IN":
                heliPlan.landingType = landingZoneTypeInput.text;
                break;

            case "heliLatitude IN":
                heliPlan.landLat = heliLatitudeInput.text;
                break;

            case "heliLongitude IN":
                heliPlan.landLong = heliLongitudeInput.text;
                break;

            case "Obstruction IN":
                heliPlan.obstruction = obstructionDebries.text;
                break;

            case "Obstruction2 IN":
                heliPlan.obstruction2 = obstructionDebries2.text;
                break;

            case "MRGS IN":
                heliPlan.mgrs = mrgsInput.text;
                    break;

            //End Helicopter Plan

            //Weather
            case "Temp Hi IN":
                float tempHiValue;
                float.TryParse(tempHighInput.text, out tempHiValue);
                weather.tempHi = tempHiValue;
                break;

            case "Temp Lo IN":
                float tempLowValue;
                float.TryParse(tempLowInput.text, out tempLowValue);
                weather.tempLow = tempLowValue;
                break;

            case "Wind IN":
                float windValue;
                float.TryParse(windInput.text, out windValue);
                weather.windSpeed = windValue;
                break;

            case "Humidity IN":
                float humidityValue;
                float.TryParse(humidtyInput.text, out humidityValue);
                weather.humidty = humidityValue;
                break;

            case "Precip IN":
                float precipValue;
                float.TryParse(precipInput.text, out precipValue);
                weather.precip = precipValue;
                break;

            case "Sunrise IN":
                weather.sunrise = sunriseInput.text;
                break;

            case "Sunset IN":
                weather.sunset = sunsetInput.text;
                break;

            case "Heat Index IN":
                float heatIndexValue;
                float.TryParse(heatIndexInput.text, out heatIndexValue);
                weather.heatInded = heatIndexValue;
                break;

            case "Recs One IN":
                weather.recs = recsInput.text;
                break;

            case "Recs Two IN":
                weather.recs2 = recs2Input.text;
                break;

            case "Recs Three IN":
                weather.recs3 = recs3Input.text;
                break;

            case "Night Opps IN":
                weather.nightOps = nightOpsInput.GetComponent<Toggle>().isOn;
                break;

            case "Cold Risk IN":
                weather.coldRisk = coldRiskInput.GetComponent<Toggle>().isOn;
                break;

            case "Uniform Adjustments IN":
                weather.uniAdjust = uniformAdjustmentsInput.GetComponent<Toggle>().isOn;
                Debug.Log(weather.uniAdjust);
                break;
            //End Weather

            //Animal Threats
            case "Domestic Animals IN":
                anThreat.domesticAnimals = domesticAnimalsInput.GetComponent<Toggle>().isOn;
                break;

            case "Domestic Animal Name 1 IN":
                anThreat.domesticTypes = domesticAnimalName1Input.text;
                break;

            case "Domestic Animal Name 2 IN":
                anThreat.domesticTypes2 = domesticAnimalName2Input.text;
                break;

            case "Domestic Animal Name 3 IN":
                anThreat.domesticTypes3 = domesticAnimalName3Input.text;
                break;

            case "Domestic Animal Name 4 IN":
                anThreat.domesticTypes4 = domesticAnimalName4Input.text;
                break;

            case "Domestic Animal Name 5 IN":
                anThreat.domesticTypes5 = domesticAnimalName5Input.text;
                break;

            case "Domestic Animal Name 6 IN":
                anThreat.domesticTypes6 = domesticAnimalName6Input.text;
                break;

            case "Domestic Animal Name 7 IN":
                anThreat.domesticTypes7 = domesticAnimalName7Input.text;
                break;

            case "Posion Snake Name 1 IN":
                anThreat.poisonousTypes = posionSnakeName1Input.text;
                break;

            case "Posion Snake Name 2 IN":
                anThreat.poisonousTypes2 = posionSnakeName2Input.text;
                break;

            case "Posion Snake Name 3 IN":
                anThreat.poisonousTypes3 = posionSnakeName3Input.text;
                break;

            case "Posion Snake Name 4 IN":
                anThreat.poisonousTypes4 = posionSnakeName4Input.text;
                break;

            case "Wild Animal Name 1 IN":
                anThreat.wildAnimalTypes = wildAnimalName1Input.text;
                break;

            case "Wild Animal Name 2 IN":
                anThreat.wildAnimalTypes2 = wildAnimalName2Input.text;
                break;

            case "Wild Animal Name 3 IN":
                anThreat.wildAnimalTypes3 = wildAnimalName3Input.text;
                break;

            case "Wild Animal Name 4 IN":
                anThreat.wildAnimalTypes4 = wildAnimalName4Input.text;
                break;

            case "Wild Animal Name 5 IN":
                anThreat.wildAnimalTypes5 = wildAnimalName5Input.text;
                break;

            case "Police Dog Num IN":
                int policeDogNumValue;
                int.TryParse(policeDogNumInput.text, out policeDogNumValue);
                anThreat.policeDogNum = policeDogNumValue;
                break;

            case "Vet Adress ln 1 IN":
                anThreat.policeVetAddressLn1 = vetAddressLn1Input.text;
                break;

            case "Vet Adress ln 2 IN":
                anThreat.policeVetAddressLn2 = vetAddressLn2Input.text;
                break;

            case "Police Vet Name IN":
                anThreat.policeVetName = policeVetNameInput.text;
                break;

            case "Vet Contact No IN":
                anThreat.vetContactNum = vetContactNoInput.text;
                break;

            case "After Hours Contact No IN":
                anThreat.afterHoursContactNum = vetAfterHoursContactNoInput.text;
                break;

            case "Posionous Snakes IN":
                anThreat.poisonousSnakes = posionousSnakesInput.GetComponent<Toggle>().isOn;
                break;

            case "Wild Animals IN":
                anThreat.wildAnimals = wildAnimalsInput.GetComponent<Toggle>().isOn;
                break;

            case "Police Dogs IN":
                anThreat.policeDogs = policeDogsInput.GetComponent<Toggle>().isOn;
                break;

            //End Animal Threats

            //Plant and Public Works

            case "Posion Control Number IN":
                plTreats.poisonControlNum = posionControlNumInput.text;
                break;

            case "Posion Plants Type One IN":
                plTreats.poisonousPlantTypes1 = posionPlantsType1Input.text;
                break;

            case "Posion Plants Type Two IN":
                plTreats.poisonousPlantTypes2 = posionPlantsType2Input.text;
                break;

            case "Posion Plants Type Three IN":
                plTreats.poisonousPlantTypes3 = posionPlantsType3Input.text;
                break;

            case "Posion Plants Type Four IN":
                plTreats.poisonousPlantTypes4 = posionPlantsType4Input.text;
                break;

            case "Posion Plants Type Five IN":
                plTreats.poisonousPlantTypes5 = posionPlantsType5Input.text;
                break;

            case "Rec One IN":
                plTreats.recomendationsForUniforms1 = rec1Input.text;
                break;

            case "Rec Two IN":
                plTreats.recomendationsForUniforms2 = rec2Input.text;
                break;

            case "Rec Three IN":
                plTreats.recomendationsForUniforms3 = rec3Input.text;
                break;

            case "Rec Four IN":
                plTreats.recomendationsForUniforms4 = rec4Input.text;
                break;

            case "Rec Five IN":
                plTreats.recomendationsForUniforms5 = rec5Input.text;
                break;

            case "Posion Plant Exposuer Likely":
                plTreats.poisonousPlatExpo = posionPlantExposiourCheck.GetComponent<Toggle>().isOn;
                break;

            case "Uniform Adjust Likely":
                plTreats.uniformAdjust = uniformAdjustmentsNeeded.GetComponent<Toggle>().isOn;
                break;

            case "Street Cleaning Check":
                pubWorks.streedCleaning = streetCleaningCheck.GetComponent<Toggle>().isOn;
                break;

            case "Road Hazards Check":
                pubWorks.roadHazards = raodHazardsCheck.GetComponent<Toggle>().isOn;
                break;

            case "Gate Access Check":
                pubWorks.gateAccess = gateAccessNeeded.GetComponent<Toggle>().isOn;
                break;

            case "EMS Check":
                pubWorks.emsStaging = emsNeeded.GetComponent<Toggle>().isOn;
                break;

            case "Street Closing Loc IN":
                pubWorks.streatCleaningLoc = streedClosingLocInput.text;
                break;

            case "Road Hazard Loc IN":
                pubWorks.roadHazardLocation = roadHazardLocInput.text;
                break;

            case "Gate Access IN":
                pubWorks.gateCode = gateAccessInput.text;
                break;

            case "Gate Loc IN":
                pubWorks.gateLoc = gateLocInput.text;
                break;

            case "EMS Loc":
                pubWorks.emsLoc = emsLocationInput.text;
                break;

            //Plant and Public Works

            //Extended Opps

            case "Work Cycles Determined Check":
                exOpp.workCyclesDetermined = workCyclesCheck.GetComponent<Toggle>().isOn;
                break;

            case "Work Cycle One IN":
                exOpp.workCycleList1 = workCyclesOneInput.text;
                break;

            case "Work Cycle Two IN":
                exOpp.workCycleList2 = workCyclesTwoInput.text;
                break;

            case "Work Cycle Three IN":
                exOpp.workCycleList3 = workCyclesThreeInput.text;
                break;

            case "Work Cycle Four IN":
                exOpp.workCycleList4 = workCyclesFourInput.text;
                break;

            case "Restroom Facilities Check":
                exOpp.restroomFacityDet = restroomCheck.GetComponent<Toggle>().isOn;
                break;

            case "Restroom One List IN":
                exOpp.restromList1 = restroomOneInput.text;
                break;

            case "Restroom Two List IN":
                exOpp.restromList2 = restroomTwoInput.text;
                break;

            case "Restroom Three List IN":
                exOpp.restromList3 = restroomThreeInput.text;
                break;

            case "Restroom Four List IN":
                exOpp.restromList4 = restroomFourInput.text;
                break;

            case "Nutrition Secured Check":
                exOpp.nutritionSecured = nutritionCheck.GetComponent<Toggle>().isOn;
                break;

            case "Nutrition Secured One List IN":
                exOpp.nutritionalList1 = nutritionOneInput.text;
                break;

            case "Nutrition Secured Two List IN":
                exOpp.nutritionalList2 = nutritionTwoInput.text;
                break;

            case "Nutrition Secured Three List IN":
                exOpp.nutritionalList3 = nutritionThreeInput.text;
                break;

            case "Nutrition Secured Four List IN":
                exOpp.nutritionalList4 = nutritionFourInput.text;
                break;

            case "Sleep Area Determined Check":
                exOpp.sleepAreaDetermined = sleepDeterminedCheck.GetComponent<Toggle>().isOn;
                break;

            case "Sleep Area One List IN":
                exOpp.sleepAreaList1 = sleepOneInput.text;
                break;

            case "Sleep Area Two List IN":
                exOpp.sleepAreaList2 = sleepTwoInput.text;
                break;

            case "Sleep Area Three List IN":
                exOpp.sleepAreaList3 = sleepThreeInput.text;
                break;

            //End Extended Opps

            //Hazardous Materials
            case "Ignition Risks or NFDD Check":
                hazMat.ignitingRisks = ignitionCheck.GetComponent<Toggle>().isOn;
                break;

            case "Ignition Type One IN":
                hazMat.ignitingTypes1 = ignitionRiskOneInput.text;
                break;

            case "Ignition Type Two IN":
                hazMat.ignitingTypes2 = ignitionRiskTwoInput.text;
                break;

            case "Ignition Type Three IN":
                hazMat.ignitingTypes3 = ignitionRiskThreeInput.text;
                break;

            case "Clandestine Lab Check":
                hazMat.cladestineLab = clandestineLabCheck.GetComponent<Toggle>().isOn;
                break;

            case "Clandestine Lab Type One IN":
                hazMat.cladestineTypes1 = clandestineLabOneInput.text;
                break;

            case "Clandestine Lab Type Two IN":
                hazMat.cladestineTypes2 = clandestineLabTwoInput.text;
                break;

            case "Clandestine Lab Type Three IN":
                hazMat.cladestineTypes3 = clandestineLabThreeInput.text;
                break;

            case "Industrial Check":
                hazMat.industrialChemicals = industrialChemCheck.GetComponent<Toggle>().isOn;
                break;

            case "Industrial Chemicals Type One IN":
                hazMat.industrialChamTypes1 = indsutrialChemOneInput.text;
                break;

            case "Industrial Chemicals Type Two IN":
                hazMat.industrialChamTypes2 = indsutrialChemTwoInput.text;
                break;

            case "Industrial Chemicals Type Three IN":
                hazMat.industrialChamTypes3 = indsutrialChemThreeInput.text;
                break;

            case "Other HazMats Check":
                hazMat.otherHazMat = otherHazMatCheck.GetComponent<Toggle>().isOn;
                break;

            case "Other HazMat Type One IN":
                hazMat.otherHazMatTypes1 = otherHazMatOneInput.text;
                break;

            case "Other HazMat Type Two IN":
                hazMat.otherHazMatTypes2 = otherHazMatTwoInput.text;
                break;

            case "Other HazMat Type Three IN":
                hazMat.otherHazMatTypes3 = otherHazMatThreeInput.text;
                break;

            case "Rec List Type One IN":
                hazMat.recListOne = recomendOneInput.text;
                break;

            case "Rec List Type Two IN":
                hazMat.recListTwo = recomendTwoInput.text;
                break;

            case "HazMat Team Number":
                hazMat.hazmatTeamNumber = hazMatTeamNumberInput.text;
                break;

            case "PPE Check":
                hazMat.otherSpecialPPE = ppeCheck.GetComponent<Toggle>().isOn;
                break;

            case "Obtain Via Dispatch Check":
                hazMat.obtainViaDispatch = obtainViaDispatchCheck.GetComponent<Toggle>().isOn;
                break;

            case "Nomex Check":
                hazMat.nomiex = nomexCheck.GetComponent<Toggle>().isOn;
                break;
            //End Hazardous Materials


            //Other
            case "Other Input One 1":
                otr.intputOne1 = otherInputOne1Input.text;
                break;

            case "Other Input One 2":
                otr.intputOne2 = otherInputOne2Input.text;
                break;

            case "Other Input One 3":
                otr.intputOne3 = otherInputOne3Input.text;
                break;

            case "Other Input One 4":
                otr.intputOne4 = otherInputOne4Input.text;
                break;

            case "Other Input One 5":
                otr.intputOne5 = otherInputOne5Input.text;
                break;

            case "Other Input Two 1":
                otr.inputTwo1 = otherInputTwo1Input.text;
                break;

            case "Other Input Two 2":
                otr.inputTwo2 = otherInputTwo2Input.text;
                break;

            case "Other Input Two 3":
                otr.inputTwo3 = otherInputTwo3Input.text;
                break;

            case "Other Input Two 4":
                otr.inputTwo4 = otherInputTwo4Input.text;
                break;

            case "Other Input Two 5":
                otr.inputTwo5 = otherInputTwo5Input.text;
                break;

            case "Other Input Three 1":
                otr.inputThree1 = otherInputThree1Input.text;
                break;

            case "Other Input Three 2":
                otr.inputThree2 = otherInputThree2Input.text;
                break;

            case "Other Input Three 3":
                otr.inputThree3 = otherInputThree3Input.text;
                break;

            case "Other Input Three 4":
                otr.inputThree4 = otherInputThree4Input.text;
                break;

            case "Other Input Three 5":
                otr.inputThree5 = otherInputThree5Input.text;
                break;
            //End Other

            //profile stuff
            case "Profile Name IN":
                profileName = profileNameInput.text;
                break;
            //end profile stuff

            //Profile Hospitle Input
            case "hosPrimaryName In Prof":
                profDat.hospitleName = hospitleNameProfInput.text;
                break;

            case "hosPrimary Type In Prof":
                profDat.hospitleType = hospitleTypeProfInput.text;
                break;

            case "hosPrimary Address In Prof":
                profDat.hospitleAddress = hospitleAddressProfInput.text;
                break;

            case "hosPrimary Distance In Prof":
                profDat.hospitleDistance = hospitleDistanceProfInput.text;
                break;

            case "hosPrimary ED Contact No In Prof":
                profDat.hospitleEDContact = hospitleEDContactProfInput.text;
                break;

            case "Hospitel Profile Name In":
                profDat.profileNameHospitle = profileNameHospInput.text;
                break;


            //End Profile Hospitle Input

            //Profile Heli Input
            case "Primary Aircraft IN Profile":
                profDat.heliPlanAircraft = heliAircraftProfInput.text;
                break;

            case "Primary Contact Num IN Profile":
                profDat.heliPlanContactNum = heliContactProfInput.text;
                break;

            case "Heli Profile Name In":
                profDat.profileNameHeli = profileNameHeliInput.text;
                break;


            //End Profile Heli Input

            //Profile Add Opp Input

            case "EMS Radio IN Prof":
                profDat.addOppEMSRadio = addOppProfEDRadioInput.text;
                break;

            case "EMS Supervisior IN Prof":
                profDat.addOppEMSOfficer = addOppProfileEDOfficerInput.text;
                break;

            case "FD Radio Channel IN Prof":
                profDat.addOppFDRadio = addOppProfileFDRadioInput.text;
                break;

            case "FD Officer IN Prof":
                profDat.addOppFDOfficer = addOppProfileFDOfficerInput.text;
                break;

            case "AddOpp Profile Name In":
                profDat.profileNameAddOpp = profileNameAddOppInput.text;
                break;


            //End Profile Add Opp Input
            default:
                break;
        }


    }

    //initalizis buttons for profiling

    public void Start()
    {
        

        UpdateDropdownHospProfile();
        UpdateHeliDropdownProfile();
        UpdateDropdownAddOppProfile();

    }

    //clears the dropdowns and adds the saved profiles to the dropdown to heli
    public void UpdateHeliDropdownProfile()
    {
        heliDropMessages.Clear();
        //for the sample
        sampleHeliDropdown.ClearOptions();

        //for the actual
        heliDropdownOne.ClearOptions();
        heliDropdownTwo.ClearOptions();
        //for the sample

        //needs a unique dropdown data per data field
        heliDropProfName1 = new Dropdown.OptionData();
        heliDropProfName2 = new Dropdown.OptionData();
        heliDropProfName3 = new Dropdown.OptionData();
        heliDropProfName4 = new Dropdown.OptionData();
        heliDropProfName5 = new Dropdown.OptionData();
        heliDropProfName6 = new Dropdown.OptionData();

        if (PlayerPrefs.HasKey("ProfileHeli1"))
        {
            heliDropProfName1.text = PlayerPrefs.GetString("ProfileHeli1");
            heliDropMessages.Add(heliDropProfName1);
        }

        if (PlayerPrefs.HasKey("ProfileHeli2"))
        {
            heliDropProfName2.text = PlayerPrefs.GetString("ProfileHeli2");
            heliDropMessages.Add(heliDropProfName2);
        }

        if (PlayerPrefs.HasKey("ProfileHeli3"))
        {
            heliDropProfName3.text = PlayerPrefs.GetString("ProfileHeli3");
            heliDropMessages.Add(heliDropProfName3);
        }

        if (PlayerPrefs.HasKey("ProfileHeli4"))
        {
            heliDropProfName4.text = PlayerPrefs.GetString("ProfileHeli4");
            heliDropMessages.Add(heliDropProfName4);
        }

        if (PlayerPrefs.HasKey("ProfileHeli5"))
        {
            heliDropProfName5.text = PlayerPrefs.GetString("ProfileHeli5");
            heliDropMessages.Add(heliDropProfName5);
        }

        if (PlayerPrefs.HasKey("ProfileHeli6"))
        {
            heliDropProfName6.text = PlayerPrefs.GetString("ProfileHeli6");
            heliDropMessages.Add(heliDropProfName6);
        }

        foreach (Dropdown.OptionData message in heliDropMessages)
        {
            Debug.Log(message.ToString());
            //adds the entry to the dropdown
            sampleHeliDropdown.options.Add(message);

            //for the acutal
            heliDropdownOne.options.Add(message);
            heliDropdownTwo.options.Add(message);
            //makes index equal to the total number of enteries
            indexProfNameHeli = heliDropMessages.Count - 1;
        }
    }

    //clears the dropdwons and adds the saved profiles to the dropdown
    public void UpdateDropdownHospProfile()
    {
        hospDropMessages.Clear();
        //for the sample
        sampleHospDropdwon.ClearOptions();

        //for the actual
        hospitleDropdownOne.ClearOptions();
        hospitleDropdownTwo.ClearOptions();
        hospitleDropdownThree.ClearOptions();
        //for the sample

        //needs a unique dropdown data per data field
        hospDropProfName1 = new Dropdown.OptionData();
        hospDropProfName2 = new Dropdown.OptionData();
        hospDropProfName3 = new Dropdown.OptionData();
        hospDropProfName4 = new Dropdown.OptionData();
        hospDropProfName5 = new Dropdown.OptionData();
        hospDropProfName6 = new Dropdown.OptionData();



#region Checks
        if (PlayerPrefs.HasKey("ProfileHosp1"))
        {
            hospDropProfName1.text = PlayerPrefs.GetString("ProfileHosp1");
            hospDropMessages.Add(hospDropProfName1);
        }

        if (PlayerPrefs.HasKey("ProfileHosp2"))
        {
            hospDropProfName2.text = PlayerPrefs.GetString("ProfileHosp2");
            hospDropMessages.Add(hospDropProfName2);
        }

        if (PlayerPrefs.HasKey("ProfileHosp3"))
        {
            hospDropProfName3.text = PlayerPrefs.GetString("ProfileHosp3");
            hospDropMessages.Add(hospDropProfName3);
        }

        if (PlayerPrefs.HasKey("ProfileHosp4"))
        {
            hospDropProfName4.text = PlayerPrefs.GetString("ProfileHosp4");
            hospDropMessages.Add(hospDropProfName4);
        }

        if (PlayerPrefs.HasKey("ProfileHosp5"))
        {
            hospDropProfName5.text = PlayerPrefs.GetString("ProfileHosp5");
            hospDropMessages.Add(hospDropProfName5);
        }

        if (PlayerPrefs.HasKey("ProfileHosp6"))
        {
            hospDropProfName6.text = PlayerPrefs.GetString("ProfileHosp6");
            hospDropMessages.Add(hospDropProfName6);
        }

#endregion Checks


        

        foreach (Dropdown.OptionData message in hospDropMessages)
        {
            Debug.Log(message.ToString());
            //adds the entry to the dropdown
            sampleHospDropdwon.options.Add(message);

            //for the acutal
            hospitleDropdownOne.options.Add(message);
            hospitleDropdownTwo.options.Add(message);
            hospitleDropdownThree.options.Add(message);
            //makes index equal to the total number of enteries
            indexProfName = hospDropMessages.Count - 1;
        }

    }

    //clears the dropdowns and adds the saved profiles to the dropdown
    public void UpdateDropdownAddOppProfile()
    {
        addOppDropMessages.Clear();
        //for the sample
        sampleAddOpp.ClearOptions();

        //for the actual
        addOppDropdownOne.ClearOptions();
        addOppDropdownTwo.ClearOptions();
        //for the sample

        //needs a unique dropdown data per data field
        addOppDropProfName1 = new Dropdown.OptionData();
        addOppDropProfName2 = new Dropdown.OptionData();
        addOppDropProfName3 = new Dropdown.OptionData();
        addOppDropProfName4 = new Dropdown.OptionData();
        addOppDropProfName5 = new Dropdown.OptionData();
        addOppDropProfName6 = new Dropdown.OptionData();



#region Checks
        if (PlayerPrefs.HasKey("ProfileAddOpp1"))
        {
            addOppDropProfName1.text = PlayerPrefs.GetString("ProfileAddOpp1");
            addOppDropMessages.Add(addOppDropProfName1);
        }

        if (PlayerPrefs.HasKey("ProfileAddOpp2"))
        {
            addOppDropProfName2.text = PlayerPrefs.GetString("ProfileAddOpp2");
            addOppDropMessages.Add(addOppDropProfName2);
        }

        if (PlayerPrefs.HasKey("ProfileAddOpp3"))
        {
            addOppDropProfName3.text = PlayerPrefs.GetString("ProfileAddOpp3");
            addOppDropMessages.Add(addOppDropProfName3);
        }

        if (PlayerPrefs.HasKey("ProfileAddOpp4"))
        {
            addOppDropProfName4.text = PlayerPrefs.GetString("ProfileAddOpp4");
            addOppDropMessages.Add(addOppDropProfName4);
        }

        if (PlayerPrefs.HasKey("ProfileAddOpp5"))
        {
            addOppDropProfName5.text = PlayerPrefs.GetString("ProfileAddOpp5");
            addOppDropMessages.Add(addOppDropProfName5);
        }

        if (PlayerPrefs.HasKey("ProfileAddOpp6"))
        {
            addOppDropProfName6.text = PlayerPrefs.GetString("ProfileAddOpp6");
            addOppDropMessages.Add(addOppDropProfName6);
        }

#endregion Checks




        foreach (Dropdown.OptionData message in addOppDropMessages)
        {
            Debug.Log(message.ToString());
            //adds the entry to the dropdown
            sampleAddOpp.options.Add(message);

            //for the acutal
            addOppDropdownOne.options.Add(message);
            addOppDropdownTwo.options.Add(message);
            //makes index equal to the total number of enteries
            indexProfNameAddOpp = addOppDropMessages.Count - 1;
        }

    }

    //checks for preexisting functions

    public void CheckHeliProfile()
    {
        for (int i = 0; i < 100; i++)
        {
            if(PlayerPrefs.HasKey("ProfileHeli" + i))
            {
                if(PlayerPrefs.GetString("ProfileHeli" + i) == profDat.profileNameHeli)
                {
                    Debug.Log("has the key");

                    n = (i * 100);

                    PlayerPrefs.DeleteKey((n + 6).ToString());
                    PlayerPrefs.DeleteKey((n + 7).ToString());

                    PlayerPrefs.DeleteKey("ProfileHeli" + i.ToString());
                }
            }
        }
    }

    public void CheckHospProfile()
    {
        for (int i = 0; i < 100; i++)
        {
            if (PlayerPrefs.HasKey("ProfileHosp" + i))
            {
                if (PlayerPrefs.GetString("ProfileHosp" + i) == profDat.profileNameHeli)
                {
                    Debug.Log("has the key");

                    n = (i * 100);
                    PlayerPrefs.DeleteKey((n + 1).ToString());
                    PlayerPrefs.DeleteKey((n + 2).ToString());
                    PlayerPrefs.DeleteKey((n + 3).ToString());
                    PlayerPrefs.DeleteKey((n + 4).ToString());
                    PlayerPrefs.DeleteKey((n + 5).ToString());


                    PlayerPrefs.DeleteKey("ProfileHosp" + i.ToString());
                }
            }
        }
    }

    public void CheckAddOppProfile()
    {
        for (int i = 0; i < 100; i++)
        {
            if (PlayerPrefs.HasKey("ProfileAddOpp" + i))
            {
                if (PlayerPrefs.GetString("ProfileAddOpp" + i) == profDat.profileNameHeli)
                {
                    Debug.Log("has the key");

                    n = (i * 100);
                    PlayerPrefs.DeleteKey((n + 10).ToString());
                    PlayerPrefs.DeleteKey((n + 11).ToString());
                    PlayerPrefs.DeleteKey((n + 12).ToString());
                    PlayerPrefs.DeleteKey((n + 13).ToString());


                    PlayerPrefs.DeleteKey("ProfileAddOpp" + i.ToString());
                }
            }
        }
    }
    //end checks for preexisting key value pares


    //saves the data for profiling

    //saves the data for hospitle profile
    public void OnButtonSaveHospProfileData()
    {

        int profLastHosp = PlayerPrefs.GetInt("Last ProfileHosp");

        CheckHospProfile();

        profLastHosp++;
        PlayerPrefs.SetInt("Last ProfileHosp", profLastHosp);

        n = (profLastHosp * 100);

        PlayerPrefs.SetString("ProfileHosp" + profLastHosp.ToString(), profDat.profileNameHospitle);

        PlayerPrefs.SetString((n + 1).ToString(), profDat.hospitleName);
        PlayerPrefs.SetString((n + 2).ToString(), profDat.hospitleType);
        PlayerPrefs.SetString((n + 3).ToString(), profDat.hospitleAddress);
        PlayerPrefs.SetString((n + 4).ToString(), profDat.hospitleDistance);
        PlayerPrefs.SetString((n + 5).ToString(), profDat.hospitleEDContact);

        UpdateDropdownHospProfile();
    }

    public void OnButtonSaveHeliProfileData()
    {

        int profLastHeli = PlayerPrefs.GetInt("Last ProfileHeli");

        CheckHeliProfile();

        profLastHeli++;
        PlayerPrefs.SetInt("Last ProfileHeli", profLastHeli);

        n = (profLastHeli * 100);

        PlayerPrefs.SetString("ProfileHeli" + profLastHeli.ToString(), profDat.profileNameHeli);

        PlayerPrefs.SetString((n + 6).ToString(), profDat.heliPlanAircraft);
        PlayerPrefs.SetString((n + 7).ToString(), profDat.heliPlanContactNum);
 

        UpdateHeliDropdownProfile();


    }

    public void OnButtonSaveAddOppProfileData()
    {
        int profLastAddOpp = PlayerPrefs.GetInt("Last ProfileAddOpp");

        CheckAddOppProfile();

        profLastAddOpp++;
        PlayerPrefs.SetInt("Last ProfileAddOpp", profLastAddOpp);

        n = (profLastAddOpp * 100);

        PlayerPrefs.SetString("ProfileAddOpp" + profLastAddOpp.ToString(), profDat.profileNameAddOpp);

        PlayerPrefs.SetString((n + 10).ToString(), profDat.addOppEMSRadio);
        PlayerPrefs.SetString((n + 11).ToString(), profDat.addOppEMSOfficer);
        PlayerPrefs.SetString((n + 12).ToString(), profDat.addOppFDRadio);
        PlayerPrefs.SetString((n + 13).ToString(), profDat.addOppFDOfficer);

        UpdateDropdownAddOppProfile();
    }

    public void OnClearEntryDataProfile()
    {
        if (hasHitClear == true)
        {

            Debug.Log("has hit clear button");
            hospitleNameProfInput.text = "";
            hospitleTypeProfInput.text = "";
            hospitleAddressProfInput.text = "";
            hospitleDistanceProfInput.text = "";
            hospitleEDContactProfInput.text = "";
            profileNameHospInput.text = "";

            heliAircraftProfInput.text = "";
            heliContactProfInput.text = "";
            profileNameHeliInput.text = "";

            addOppProfEDRadioInput.text = "";
            addOppProfileEDOfficerInput.text = "";
            addOppProfileFDRadioInput.text = "";
            addOppProfileFDOfficerInput.text = "";
            profileNameAddOppInput.text = "";

            hasHitClear = false;
        }
    }

    public void OnButtonClearProfileData()
    {

        hasHitClear = true;


        PlayerPrefs.DeleteAll();

        UpdateDropdownHospProfile();
        UpdateDropdownAddOppProfile();
        UpdateHeliDropdownProfile();


    }

    //DROPDOWN SELECTIONS

    public void OnProfileAddOpDropdown()
    {
        if (addOppProfileDropdown.value == 0)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One");

            n = (addOppProfileDropdown.value + 1) * 100;

            addOppInfo.emsRadio = (PlayerPrefs.GetString((n + 10).ToString()));
            addOppInfo.emsSupervisor = (PlayerPrefs.GetString((n + 11).ToString()));

            emsRadioVisualInput.GetComponent<InputField>().text = addOppInfo.emsRadio;
            emsSupervisorVisualInput.GetComponent<InputField>().text = addOppInfo.emsSupervisor;
        }

        else if (addOppProfileDropdown.value == 1)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One");

            n = (addOppProfileDropdown.value + 1) * 100;

            addOppInfo.emsRadio = (PlayerPrefs.GetString((n + 10).ToString()));
            addOppInfo.emsSupervisor = (PlayerPrefs.GetString((n + 11).ToString()));

            emsRadioVisualInput.GetComponent<InputField>().text = addOppInfo.emsRadio;
            emsSupervisorVisualInput.GetComponent<InputField>().text = addOppInfo.emsSupervisor;
        }

        if (addOppProfileDropdown.value == 2)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One");

            n = (addOppProfileDropdown.value + 1) * 100;

            addOppInfo.emsRadio = (PlayerPrefs.GetString((n + 10).ToString()));
            addOppInfo.emsSupervisor = (PlayerPrefs.GetString((n + 11).ToString()));

            emsRadioVisualInput.GetComponent<InputField>().text = addOppInfo.emsRadio;
            emsSupervisorVisualInput.GetComponent<InputField>().text = addOppInfo.emsSupervisor;
        }

        if (addOppProfileDropdown.value == 3)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One");

            n = (addOppProfileDropdown.value + 1) * 100;

            addOppInfo.emsRadio = (PlayerPrefs.GetString((n + 10).ToString()));
            addOppInfo.emsSupervisor = (PlayerPrefs.GetString((n + 11).ToString()));

            emsRadioVisualInput.GetComponent<InputField>().text = addOppInfo.emsRadio;
            emsSupervisorVisualInput.GetComponent<InputField>().text = addOppInfo.emsSupervisor;
        }

        if (addOppProfileDropdown.value == 4)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One");

            n = (addOppProfileDropdown.value + 1) * 100;

            addOppInfo.emsRadio = (PlayerPrefs.GetString((n + 10).ToString()));
            addOppInfo.emsSupervisor = (PlayerPrefs.GetString((n + 11).ToString()));

            emsRadioVisualInput.GetComponent<InputField>().text = addOppInfo.emsRadio;
            emsSupervisorVisualInput.GetComponent<InputField>().text = addOppInfo.emsSupervisor;
        }

        if (addOppProfileDropdown.value == 5)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One");

            n = (addOppProfileDropdown.value + 1) * 100;

            addOppInfo.emsRadio = (PlayerPrefs.GetString((n + 10).ToString()));
            addOppInfo.emsSupervisor = (PlayerPrefs.GetString((n + 11).ToString()));

            emsRadioVisualInput.GetComponent<InputField>().text = addOppInfo.emsRadio;
            emsSupervisorVisualInput.GetComponent<InputField>().text = addOppInfo.emsSupervisor;
        }

        if (addOppProfileDropdown.value == 6)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One");

            n = (addOppProfileDropdown.value + 1) * 100;

            addOppInfo.emsRadio = (PlayerPrefs.GetString((n + 10).ToString()));
            addOppInfo.emsSupervisor = (PlayerPrefs.GetString((n + 11).ToString()));

            emsRadioVisualInput.GetComponent<InputField>().text = addOppInfo.emsRadio;
            emsSupervisorVisualInput.GetComponent<InputField>().text = addOppInfo.emsSupervisor;
        }
    }


    public void OnProfileHeliDropdownSelected()
    {
        if (heliProfileDropdown.value == 0)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One");

            n = (heliProfileDropdown.value + 1) * 100;

            heliPlan.primaryAircraft = (PlayerPrefs.GetString((n + 6).ToString()));
            heliPlan.contactNum = (PlayerPrefs.GetString((n + 7).ToString()));

            aircraftProfVisualInput.GetComponent<InputField>().text = heliPlan.primaryAircraft;
            aircraftProfContactVisualInput.GetComponent<InputField>().text = heliPlan.contactNum;

        }

        if (heliProfileDropdown.value == 1)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One");

            n = (heliProfileDropdown.value + 1) * 100;

            heliPlan.primaryAircraft = (PlayerPrefs.GetString((n + 6).ToString()));
            heliPlan.contactNum = (PlayerPrefs.GetString((n + 7).ToString()));

            aircraftProfVisualInput.GetComponent<InputField>().text = heliPlan.primaryAircraft;
            aircraftProfContactVisualInput.GetComponent<InputField>().text = heliPlan.contactNum;

        }

        if (heliProfileDropdown.value == 2)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One");

            n = (heliProfileDropdown.value + 1) * 100;

            heliPlan.primaryAircraft = (PlayerPrefs.GetString((n + 6).ToString()));
            heliPlan.contactNum = (PlayerPrefs.GetString((n + 7).ToString()));

            aircraftProfVisualInput.GetComponent<InputField>().text = heliPlan.primaryAircraft;
            aircraftProfContactVisualInput.GetComponent<InputField>().text = heliPlan.contactNum;

        }

        if (heliProfileDropdown.value == 3)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One");

            n = (heliProfileDropdown.value + 1) * 100;

            heliPlan.primaryAircraft = (PlayerPrefs.GetString((n + 6).ToString()));
            heliPlan.contactNum = (PlayerPrefs.GetString((n + 7).ToString()));

            aircraftProfVisualInput.GetComponent<InputField>().text = heliPlan.primaryAircraft;
            aircraftProfContactVisualInput.GetComponent<InputField>().text = heliPlan.contactNum;

        }

        if (heliProfileDropdown.value == 4)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One");

            n = (heliProfileDropdown.value + 1) * 100;

            heliPlan.primaryAircraft = (PlayerPrefs.GetString((n + 6).ToString()));
            heliPlan.contactNum = (PlayerPrefs.GetString((n + 7).ToString()));

            aircraftProfVisualInput.GetComponent<InputField>().text = heliPlan.primaryAircraft;
            aircraftProfContactVisualInput.GetComponent<InputField>().text = heliPlan.contactNum;

        }

        if (heliProfileDropdown.value == 5)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One");

            n = (heliProfileDropdown.value + 1) * 100;

            heliPlan.primaryAircraft = (PlayerPrefs.GetString((n + 6).ToString()));
            heliPlan.contactNum = (PlayerPrefs.GetString((n + 7).ToString()));

            aircraftProfVisualInput.GetComponent<InputField>().text = heliPlan.primaryAircraft;
            aircraftProfContactVisualInput.GetComponent<InputField>().text = heliPlan.contactNum;

        }

        if (heliProfileDropdown.value == 6)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One");

            n = (heliProfileDropdown.value + 1) * 100;

            heliPlan.primaryAircraft = (PlayerPrefs.GetString((n + 6).ToString()));
            heliPlan.contactNum = (PlayerPrefs.GetString((n + 7).ToString()));

            aircraftProfVisualInput.GetComponent<InputField>().text = heliPlan.primaryAircraft;
            aircraftProfContactVisualInput.GetComponent<InputField>().text = heliPlan.contactNum;

        }
    }

    public void OnProfileHospDropdownSelceted()
    {
        if (hospitleProfileDropdown.value == 0)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One3");

            n = (hospitleProfileDropdown.value + 1) * 100;

            hosFac.name3 = (PlayerPrefs.GetString((n + 1).ToString()));
            hosFac.type3 = (PlayerPrefs.GetString((n + 2).ToString()));
            hosFac.address3 = (PlayerPrefs.GetString((n + 3).ToString()));
            hosFac.distance3 = (PlayerPrefs.GetString((n + 4).ToString()));
            hosFac.edContactNum3 = (PlayerPrefs.GetString((n + 5).ToString()));

            primaryNameHosProfileVisualInput.GetComponent<InputField>().text = hosFac.name3;
            primaryTypeHosProfileVisualInput.GetComponent<InputField>().text = hosFac.type3;
            primaryAdressHosProfileVisualInput.GetComponent<InputField>().text = hosFac.address3;
            primaryDistanceHosProfileVisualInput.GetComponent<InputField>().text = hosFac.distance3;
            primaryEDContactHosProfileVisualInput.GetComponent<InputField>().text = hosFac.edContactNum3;

        }

        if (hospitleProfileDropdown.value == 1)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One3");

            n = (hospitleProfileDropdown.value + 1) * 100;

            hosFac.name3 = (PlayerPrefs.GetString((n + 1).ToString()));
            hosFac.type3 = (PlayerPrefs.GetString((n + 2).ToString()));
            hosFac.address3 = (PlayerPrefs.GetString((n + 3).ToString()));
            hosFac.distance3 = (PlayerPrefs.GetString((n + 4).ToString()));
            hosFac.edContactNum3 = (PlayerPrefs.GetString((n + 5).ToString()));

            primaryNameHosProfileVisualInput.GetComponent<InputField>().text = hosFac.name3;
            primaryTypeHosProfileVisualInput.GetComponent<InputField>().text = hosFac.type3;
            primaryAdressHosProfileVisualInput.GetComponent<InputField>().text = hosFac.address3;
            primaryDistanceHosProfileVisualInput.GetComponent<InputField>().text = hosFac.distance3;
            primaryEDContactHosProfileVisualInput.GetComponent<InputField>().text = hosFac.edContactNum3;

        }

        if (hospitleProfileDropdown.value == 2)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One3");

            n = (hospitleProfileDropdown.value + 1) * 100;

            hosFac.name3 = (PlayerPrefs.GetString((n + 1).ToString()));
            hosFac.type3 = (PlayerPrefs.GetString((n + 2).ToString()));
            hosFac.address3 = (PlayerPrefs.GetString((n + 3).ToString()));
            hosFac.distance3 = (PlayerPrefs.GetString((n + 4).ToString()));
            hosFac.edContactNum3 = (PlayerPrefs.GetString((n + 5).ToString()));

            primaryNameHosProfileVisualInput.GetComponent<InputField>().text = hosFac.name3;
            primaryTypeHosProfileVisualInput.GetComponent<InputField>().text = hosFac.type3;
            primaryAdressHosProfileVisualInput.GetComponent<InputField>().text = hosFac.address3;
            primaryDistanceHosProfileVisualInput.GetComponent<InputField>().text = hosFac.distance3;
            primaryEDContactHosProfileVisualInput.GetComponent<InputField>().text = hosFac.edContactNum3;

        }
        if (hospitleProfileDropdown.value == 3)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One3");

            n = (hospitleProfileDropdown.value + 1) * 100;

            hosFac.name3 = (PlayerPrefs.GetString((n + 1).ToString()));
            hosFac.type3 = (PlayerPrefs.GetString((n + 2).ToString()));
            hosFac.address3 = (PlayerPrefs.GetString((n + 3).ToString()));
            hosFac.distance3 = (PlayerPrefs.GetString((n + 4).ToString()));
            hosFac.edContactNum3 = (PlayerPrefs.GetString((n + 5).ToString()));

            primaryNameHosProfileVisualInput.GetComponent<InputField>().text = hosFac.name3;
            primaryTypeHosProfileVisualInput.GetComponent<InputField>().text = hosFac.type3;
            primaryAdressHosProfileVisualInput.GetComponent<InputField>().text = hosFac.address3;
            primaryDistanceHosProfileVisualInput.GetComponent<InputField>().text = hosFac.distance3;
            primaryEDContactHosProfileVisualInput.GetComponent<InputField>().text = hosFac.edContactNum3;

        }

        if (hospitleProfileDropdown.value == 4)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One3");

            n = (hospitleProfileDropdown.value + 1) * 100;

            hosFac.name3 = (PlayerPrefs.GetString((n + 1).ToString()));
            hosFac.type3 = (PlayerPrefs.GetString((n + 2).ToString()));
            hosFac.address3 = (PlayerPrefs.GetString((n + 3).ToString()));
            hosFac.distance3 = (PlayerPrefs.GetString((n + 4).ToString()));
            hosFac.edContactNum3 = (PlayerPrefs.GetString((n + 5).ToString()));

            primaryNameHosProfileVisualInput.GetComponent<InputField>().text = hosFac.name3;
            primaryTypeHosProfileVisualInput.GetComponent<InputField>().text = hosFac.type3;
            primaryAdressHosProfileVisualInput.GetComponent<InputField>().text = hosFac.address3;
            primaryDistanceHosProfileVisualInput.GetComponent<InputField>().text = hosFac.distance3;
            primaryEDContactHosProfileVisualInput.GetComponent<InputField>().text = hosFac.edContactNum3;

        }

        if (hospitleProfileDropdown.value == 5)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One3");

            n = (hospitleProfileDropdown.value + 1) * 100;

            hosFac.name3 = (PlayerPrefs.GetString((n + 1).ToString()));
            hosFac.type3 = (PlayerPrefs.GetString((n + 2).ToString()));
            hosFac.address3 = (PlayerPrefs.GetString((n + 3).ToString()));
            hosFac.distance3 = (PlayerPrefs.GetString((n + 4).ToString()));
            hosFac.edContactNum3 = (PlayerPrefs.GetString((n + 5).ToString()));

            primaryNameHosProfileVisualInput.GetComponent<InputField>().text = hosFac.name3;
            primaryTypeHosProfileVisualInput.GetComponent<InputField>().text = hosFac.type3;
            primaryAdressHosProfileVisualInput.GetComponent<InputField>().text = hosFac.address3;
            primaryDistanceHosProfileVisualInput.GetComponent<InputField>().text = hosFac.distance3;
            primaryEDContactHosProfileVisualInput.GetComponent<InputField>().text = hosFac.edContactNum3;

        }

        if (hospitleProfileDropdown.value == 6)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One3");

            n = (hospitleProfileDropdown.value + 1) * 100;

            hosFac.name3 = (PlayerPrefs.GetString((n + 1).ToString()));
            hosFac.type3 = (PlayerPrefs.GetString((n + 2).ToString()));
            hosFac.address3 = (PlayerPrefs.GetString((n + 3).ToString()));
            hosFac.distance3 = (PlayerPrefs.GetString((n + 4).ToString()));
            hosFac.edContactNum3 = (PlayerPrefs.GetString((n + 5).ToString()));

            primaryNameHosProfileVisualInput.GetComponent<InputField>().text = hosFac.name3;
            primaryTypeHosProfileVisualInput.GetComponent<InputField>().text = hosFac.type3;
            primaryAdressHosProfileVisualInput.GetComponent<InputField>().text = hosFac.address3;
            primaryDistanceHosProfileVisualInput.GetComponent<InputField>().text = hosFac.distance3;
            primaryEDContactHosProfileVisualInput.GetComponent<InputField>().text = hosFac.edContactNum3;

        }
    }




        //hospitle
    public void OnHospDropdwonThreeSelection()
    {
#region DropdownThree

        if (hospitleDropdownThree.value == 0)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One3");

            n = (hospitleDropdownThree.value + 1) * 100;

            hosFac.name3 = (PlayerPrefs.GetString((n + 1).ToString()));
            hosFac.type3 = (PlayerPrefs.GetString((n + 2).ToString()));
            hosFac.address3 = (PlayerPrefs.GetString((n + 3).ToString()));
            hosFac.distance3 = (PlayerPrefs.GetString((n + 4).ToString()));
            hosFac.edContactNum3 = (PlayerPrefs.GetString((n + 5).ToString()));

            tertHospitalNameVisualInput.GetComponent<InputField>().text = hosFac.name3;
            tertHospitalTypeVisualInput.GetComponent<InputField>().text = hosFac.type3;
            tertHospitalAddressVisualInput.GetComponent<InputField>().text = hosFac.address3;
            tertHospitalDistanceVisualInput.GetComponent<InputField>().text = hosFac.distance3;
            tertHospitalEDContactVisualInput.GetComponent<InputField>().text = hosFac.edContactNum3;

        }
        else if (hospitleDropdownThree.value == 1)
        {
            Debug.Log("Selected Two3");

            n = (hospitleDropdownThree.value + 1) * 100;

            hosFac.name3 = (PlayerPrefs.GetString((n + 1).ToString()));
            hosFac.type3 = (PlayerPrefs.GetString((n + 2).ToString()));
            hosFac.address3 = (PlayerPrefs.GetString((n + 3).ToString()));
            hosFac.distance3 = (PlayerPrefs.GetString((n + 4).ToString()));
            hosFac.edContactNum3 = (PlayerPrefs.GetString((n + 5).ToString()));

            tertHospitalNameVisualInput.GetComponent<InputField>().text = hosFac.name3;
            tertHospitalTypeVisualInput.GetComponent<InputField>().text = hosFac.type3;
            tertHospitalAddressVisualInput.GetComponent<InputField>().text = hosFac.address3;
            tertHospitalDistanceVisualInput.GetComponent<InputField>().text = hosFac.distance3;
            tertHospitalEDContactVisualInput.GetComponent<InputField>().text = hosFac.edContactNum3;
        }
        else if (hospitleDropdownThree.value == 2)
        {
            Debug.Log("Selected Three3");

            n = (hospitleDropdownThree.value + 1) * 100;

            hosFac.name3 = (PlayerPrefs.GetString((n + 1).ToString()));
            hosFac.type3 = (PlayerPrefs.GetString((n + 2).ToString()));
            hosFac.address3 = (PlayerPrefs.GetString((n + 3).ToString()));
            hosFac.distance3 = (PlayerPrefs.GetString((n + 4).ToString()));
            hosFac.edContactNum3 = (PlayerPrefs.GetString((n + 5).ToString()));

            tertHospitalNameVisualInput.GetComponent<InputField>().text = hosFac.name3;
            tertHospitalTypeVisualInput.GetComponent<InputField>().text = hosFac.type3;
            tertHospitalAddressVisualInput.GetComponent<InputField>().text = hosFac.address3;
            tertHospitalDistanceVisualInput.GetComponent<InputField>().text = hosFac.distance3;
            tertHospitalEDContactVisualInput.GetComponent<InputField>().text = hosFac.edContactNum3;
        }
        else if (hospitleDropdownThree.value == 3)
        {
            n = (hospitleDropdownThree.value + 1) * 100;

            hosFac.name3 = (PlayerPrefs.GetString((n + 1).ToString()));
            hosFac.type3 = (PlayerPrefs.GetString((n + 2).ToString()));
            hosFac.address3 = (PlayerPrefs.GetString((n + 3).ToString()));
            hosFac.distance3 = (PlayerPrefs.GetString((n + 4).ToString()));
            hosFac.edContactNum3 = (PlayerPrefs.GetString((n + 5).ToString()));

            tertHospitalNameVisualInput.GetComponent<InputField>().text = hosFac.name3;
            tertHospitalTypeVisualInput.GetComponent<InputField>().text = hosFac.type3;
            tertHospitalAddressVisualInput.GetComponent<InputField>().text = hosFac.address3;
            tertHospitalDistanceVisualInput.GetComponent<InputField>().text = hosFac.distance3;
            tertHospitalEDContactVisualInput.GetComponent<InputField>().text = hosFac.edContactNum3;
        }
        else if (hospitleDropdownThree.value == 4)
        {
            n = (hospitleDropdownThree.value + 1) * 100;

            hosFac.name3 = (PlayerPrefs.GetString((n + 1).ToString()));
            hosFac.type3 = (PlayerPrefs.GetString((n + 2).ToString()));
            hosFac.address3 = (PlayerPrefs.GetString((n + 3).ToString()));
            hosFac.distance3 = (PlayerPrefs.GetString((n + 4).ToString()));
            hosFac.edContactNum3 = (PlayerPrefs.GetString((n + 5).ToString()));

            tertHospitalNameVisualInput.GetComponent<InputField>().text = hosFac.name3;
            tertHospitalTypeVisualInput.GetComponent<InputField>().text = hosFac.type3;
            tertHospitalAddressVisualInput.GetComponent<InputField>().text = hosFac.address3;
            tertHospitalDistanceVisualInput.GetComponent<InputField>().text = hosFac.distance3;
            tertHospitalEDContactVisualInput.GetComponent<InputField>().text = hosFac.edContactNum3;
        }
        else if (hospitleDropdownThree.value == 5)
        {
            n = (hospitleDropdownThree.value + 1) * 100;

            hosFac.name3 = (PlayerPrefs.GetString((n + 1).ToString()));
            hosFac.type3 = (PlayerPrefs.GetString((n + 2).ToString()));
            hosFac.address3 = (PlayerPrefs.GetString((n + 3).ToString()));
            hosFac.distance3 = (PlayerPrefs.GetString((n + 4).ToString()));
            hosFac.edContactNum3 = (PlayerPrefs.GetString((n + 5).ToString()));

            tertHospitalNameVisualInput.GetComponent<InputField>().text = hosFac.name3;
            tertHospitalTypeVisualInput.GetComponent<InputField>().text = hosFac.type3;
            tertHospitalAddressVisualInput.GetComponent<InputField>().text = hosFac.address3;
            tertHospitalDistanceVisualInput.GetComponent<InputField>().text = hosFac.distance3;
            tertHospitalEDContactVisualInput.GetComponent<InputField>().text = hosFac.edContactNum3;
        }
#endregion DropdownThree
    }
    public void OnHospDropdownTwoSelected()
    {
#region DropdownTwo
        if (hospitleDropdownTwo.value == 0)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One2");

            n = (hospitleDropdownTwo.value + 1) * 100;

            Debug.Log(n);

            hosFac.name2 = (PlayerPrefs.GetString((n + 1).ToString()));
            hosFac.type2 = (PlayerPrefs.GetString((n + 2).ToString()));
            hosFac.address2 = (PlayerPrefs.GetString((n + 3).ToString()));
            hosFac.distance2 = (PlayerPrefs.GetString((n + 4).ToString()));
            hosFac.edContactNum2 = (PlayerPrefs.GetString((n + 5).ToString()));


            Debug.Log(hosFac.name2);
            Debug.Log(hosFac.type2);
            Debug.Log(hosFac.address2);
            Debug.Log(hosFac.distance2);
            Debug.Log(hosFac.edContactNum2);

            secHospitalNameVisualInput.GetComponent<InputField>().text = hosFac.name2;
            secHospitalTypeVisualInput.GetComponent<InputField>().text = hosFac.type2;
            secHospitalAddressVisualInput.GetComponent<InputField>().text = hosFac.address2;
            secHospitalDistanceVisualInput.GetComponent<InputField>().text = hosFac.distance2;
            secHospitalEDContactVisualInput.GetComponent<InputField>().text = hosFac.edContactNum2;

        }
        else if (hospitleDropdownTwo.value == 1)
        {
            Debug.Log("Selected Two2");

            n = (hospitleDropdownTwo.value + 1) * 100;
            Debug.Log(n);
            hosFac.name2 = (PlayerPrefs.GetString((n + 1).ToString()));
            hosFac.type2 = (PlayerPrefs.GetString((n + 2).ToString()));
            hosFac.address2 = (PlayerPrefs.GetString((n + 3).ToString()));
            hosFac.distance2 = (PlayerPrefs.GetString((n + 4).ToString()));
            hosFac.edContactNum2 = (PlayerPrefs.GetString((n + 5).ToString()));


            Debug.Log(hosFac.name2);
            Debug.Log(hosFac.type2);
            Debug.Log(hosFac.address2);
            Debug.Log(hosFac.distance2);
            Debug.Log(hosFac.edContactNum2);

            secHospitalNameVisualInput.GetComponent<InputField>().text = hosFac.name2;
            secHospitalTypeVisualInput.GetComponent<InputField>().text = hosFac.type2;
            secHospitalAddressVisualInput.GetComponent<InputField>().text = hosFac.address2;
            secHospitalDistanceVisualInput.GetComponent<InputField>().text = hosFac.distance2;
            secHospitalEDContactVisualInput.GetComponent<InputField>().text = hosFac.edContactNum2;
        }
        else if (hospitleDropdownTwo.value == 2)
        {
            Debug.Log("Selected Three2");

            n = (hospitleDropdownTwo.value + 1) * 100;

            hosFac.name2 = (PlayerPrefs.GetString((n + 1).ToString()));
            hosFac.type2 = (PlayerPrefs.GetString((n + 2).ToString()));
            hosFac.address2 = (PlayerPrefs.GetString((n + 3).ToString()));
            hosFac.distance2 = (PlayerPrefs.GetString((n + 4).ToString()));
            hosFac.edContactNum2 = (PlayerPrefs.GetString((n + 5).ToString()));

            secHospitalNameVisualInput.GetComponent<InputField>().text = hosFac.name2;
            secHospitalTypeVisualInput.GetComponent<InputField>().text = hosFac.type2;
            secHospitalAddressVisualInput.GetComponent<InputField>().text = hosFac.address2;
            secHospitalDistanceVisualInput.GetComponent<InputField>().text = hosFac.distance2;
            secHospitalEDContactVisualInput.GetComponent<InputField>().text = hosFac.edContactNum2;
        }
        else if (hospitleDropdownTwo.value == 3)
        {
            n = (hospitleDropdownTwo.value + 1) * 100;

            hosFac.name2 = (PlayerPrefs.GetString((n + 1).ToString()));
            hosFac.type2 = (PlayerPrefs.GetString((n + 2).ToString()));
            hosFac.address2 = (PlayerPrefs.GetString((n + 3).ToString()));
            hosFac.distance2 = (PlayerPrefs.GetString((n + 4).ToString()));
            hosFac.edContactNum2 = (PlayerPrefs.GetString((n + 5).ToString()));

            secHospitalNameVisualInput.GetComponent<InputField>().text = hosFac.name2;
            secHospitalTypeVisualInput.GetComponent<InputField>().text = hosFac.type2;
            secHospitalAddressVisualInput.GetComponent<InputField>().text = hosFac.address2;
            secHospitalDistanceVisualInput.GetComponent<InputField>().text = hosFac.distance2;
            secHospitalEDContactVisualInput.GetComponent<InputField>().text = hosFac.edContactNum2;
        }
        else if (hospitleDropdownTwo.value == 4)
        {
            n = (hospitleDropdownTwo.value + 1) * 100;

            hosFac.name2 = (PlayerPrefs.GetString((n + 1).ToString()));
            hosFac.type2 = (PlayerPrefs.GetString((n + 2).ToString()));
            hosFac.address2 = (PlayerPrefs.GetString((n + 3).ToString()));
            hosFac.distance2 = (PlayerPrefs.GetString((n + 4).ToString()));
            hosFac.edContactNum2 = (PlayerPrefs.GetString((n + 5).ToString()));

            secHospitalNameVisualInput.GetComponent<InputField>().text = hosFac.name2;
            secHospitalTypeVisualInput.GetComponent<InputField>().text = hosFac.type2;
            secHospitalAddressVisualInput.GetComponent<InputField>().text = hosFac.address2;
            secHospitalDistanceVisualInput.GetComponent<InputField>().text = hosFac.distance2;
            secHospitalEDContactVisualInput.GetComponent<InputField>().text = hosFac.edContactNum2;
        }
        else if (hospitleDropdownTwo.value == 5)
        {
            n = (hospitleDropdownTwo.value + 1) * 100;

            hosFac.name2 = (PlayerPrefs.GetString((n + 1).ToString()));
            hosFac.type2 = (PlayerPrefs.GetString((n + 2).ToString()));
            hosFac.address2 = (PlayerPrefs.GetString((n + 3).ToString()));
            hosFac.distance2 = (PlayerPrefs.GetString((n + 4).ToString()));
            hosFac.edContactNum2 = (PlayerPrefs.GetString((n + 5).ToString()));

            secHospitalNameVisualInput.GetComponent<InputField>().text = hosFac.name2;
            secHospitalTypeVisualInput.GetComponent<InputField>().text = hosFac.type2;
            secHospitalAddressVisualInput.GetComponent<InputField>().text = hosFac.address2;
            secHospitalDistanceVisualInput.GetComponent<InputField>().text = hosFac.distance2;
            secHospitalEDContactVisualInput.GetComponent<InputField>().text = hosFac.edContactNum2;
        }
#endregion DropdownTwo
    }
    public void OnHospDropdownOneSelection()
    {
        //set up to do 6 differnt profiles
#region DropdownOne
        if (hospitleDropdownOne.value == 0)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One");

            n = (hospitleDropdownOne.value + 1) * 100;

            hosFac.name = (PlayerPrefs.GetString((n + 1).ToString()));
            hosFac.type = (PlayerPrefs.GetString((n + 2).ToString()));
            hosFac.address = (PlayerPrefs.GetString((n + 3).ToString()));
            hosFac.distance = (PlayerPrefs.GetString((n + 4).ToString()));
            hosFac.edContactNum = (PlayerPrefs.GetString((n + 5).ToString()));

            primaryHospitalNameVisualInput.GetComponent<InputField>().text = hosFac.name;
            primaryHospitalTypeVisualInput.GetComponent<InputField>().text = hosFac.type;
            primaryHospitalAddressVisualInput.GetComponent<InputField>().text = hosFac.address;
            primaryHospitalDistanceVisualInput.GetComponent<InputField>().text = hosFac.distance;
            primaryHospitalEDContactVisualInput.GetComponent<InputField>().text = hosFac.edContactNum;

        }
        else if (hospitleDropdownOne.value == 1)
        {
            Debug.Log("Selected Two");

            n = (hospitleDropdownOne.value + 1) * 100;

            hosFac.name = (PlayerPrefs.GetString((n + 1).ToString()));
            hosFac.type = (PlayerPrefs.GetString((n + 2).ToString()));
            hosFac.address = (PlayerPrefs.GetString((n + 3).ToString()));
            hosFac.distance = (PlayerPrefs.GetString((n + 4).ToString()));
            hosFac.edContactNum = (PlayerPrefs.GetString((n + 5).ToString()));

            primaryHospitalNameVisualInput.GetComponent<InputField>().text = hosFac.name;
            primaryHospitalTypeVisualInput.GetComponent<InputField>().text = hosFac.type;
            primaryHospitalAddressVisualInput.GetComponent<InputField>().text = hosFac.address;
            primaryHospitalDistanceVisualInput.GetComponent<InputField>().text = hosFac.distance;
            primaryHospitalEDContactVisualInput.GetComponent<InputField>().text = hosFac.edContactNum;
        }
        else if (hospitleDropdownOne.value == 2)
        {
            Debug.Log("Selected Three");

            n = (hospitleDropdownOne.value + 1) * 100;

            hosFac.name = (PlayerPrefs.GetString((n + 1).ToString()));
            hosFac.type = (PlayerPrefs.GetString((n + 2).ToString()));
            hosFac.address = (PlayerPrefs.GetString((n + 3).ToString()));
            hosFac.distance = (PlayerPrefs.GetString((n + 4).ToString()));
            hosFac.edContactNum = (PlayerPrefs.GetString((n + 5).ToString()));

            primaryHospitalNameVisualInput.GetComponent<InputField>().text = hosFac.name;
            primaryHospitalTypeVisualInput.GetComponent<InputField>().text = hosFac.type;
            primaryHospitalAddressVisualInput.GetComponent<InputField>().text = hosFac.address;
            primaryHospitalDistanceVisualInput.GetComponent<InputField>().text = hosFac.distance;
            primaryHospitalEDContactVisualInput.GetComponent<InputField>().text = hosFac.edContactNum;
        }
        else if (hospitleDropdownOne.value == 3)
        {
            n = (hospitleDropdownOne.value + 1) * 100;

            hosFac.name = (PlayerPrefs.GetString((n + 1).ToString()));
            hosFac.type = (PlayerPrefs.GetString((n + 2).ToString()));
            hosFac.address = (PlayerPrefs.GetString((n + 3).ToString()));
            hosFac.distance = (PlayerPrefs.GetString((n + 4).ToString()));
            hosFac.edContactNum = (PlayerPrefs.GetString((n + 5).ToString()));

            primaryHospitalNameVisualInput.GetComponent<InputField>().text = hosFac.name;
            primaryHospitalTypeVisualInput.GetComponent<InputField>().text = hosFac.type;
            primaryHospitalAddressVisualInput.GetComponent<InputField>().text = hosFac.address;
            primaryHospitalDistanceVisualInput.GetComponent<InputField>().text = hosFac.distance;
            primaryHospitalEDContactVisualInput.GetComponent<InputField>().text = hosFac.edContactNum;
        }
        else if (hospitleDropdownOne.value == 4)
        {
            n = (hospitleDropdownOne.value + 1) * 100;

            hosFac.name = (PlayerPrefs.GetString((n + 1).ToString()));
            hosFac.type = (PlayerPrefs.GetString((n + 2).ToString()));
            hosFac.address = (PlayerPrefs.GetString((n + 3).ToString()));
            hosFac.distance = (PlayerPrefs.GetString((n + 4).ToString()));
            hosFac.edContactNum = (PlayerPrefs.GetString((n + 5).ToString()));

            primaryHospitalNameVisualInput.GetComponent<InputField>().text = hosFac.name;
            primaryHospitalTypeVisualInput.GetComponent<InputField>().text = hosFac.type;
            primaryHospitalAddressVisualInput.GetComponent<InputField>().text = hosFac.address;
            primaryHospitalDistanceVisualInput.GetComponent<InputField>().text = hosFac.distance;
            primaryHospitalEDContactVisualInput.GetComponent<InputField>().text = hosFac.edContactNum;
        }
        else if (hospitleDropdownOne.value == 5)
        {
            n = (hospitleDropdownOne.value + 1) * 100;

            hosFac.name = (PlayerPrefs.GetString((n + 1).ToString()));
            hosFac.type = (PlayerPrefs.GetString((n + 2).ToString()));
            hosFac.address = (PlayerPrefs.GetString((n + 3).ToString()));
            hosFac.distance = (PlayerPrefs.GetString((n + 4).ToString()));
            hosFac.edContactNum = (PlayerPrefs.GetString((n + 5).ToString()));

            primaryHospitalNameVisualInput.GetComponent<InputField>().text = hosFac.name;
            primaryHospitalTypeVisualInput.GetComponent<InputField>().text = hosFac.type;
            primaryHospitalAddressVisualInput.GetComponent<InputField>().text = hosFac.address;
            primaryHospitalDistanceVisualInput.GetComponent<InputField>().text = hosFac.distance;
            primaryHospitalEDContactVisualInput.GetComponent<InputField>().text = hosFac.edContactNum;
        }
#endregion DropdownOne

    }
        //heli
    public void OnHeliDropdownOneSelection()
    {
#region HeliDropdwon
        if (heliDropdownOne.value == 0)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One");

            n = (heliDropdownOne.value + 1) * 100;

            heliPlan.primaryAircraft = (PlayerPrefs.GetString((n + 6).ToString()));
            heliPlan.contactNum = (PlayerPrefs.GetString((n + 7).ToString()));

            primaryAircaftVisualInput.GetComponent<InputField>().text = heliPlan.primaryAircraft;
            primaryAircraftContactVisualInput.GetComponent<InputField>().text = heliPlan.contactNum;

        }

        if (heliDropdownOne.value == 1)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One");

            n = (heliDropdownOne.value + 1) * 100;

            heliPlan.primaryAircraft = (PlayerPrefs.GetString((n + 6).ToString()));
            heliPlan.contactNum = (PlayerPrefs.GetString((n + 7).ToString()));

            primaryAircaftVisualInput.GetComponent<InputField>().text = heliPlan.primaryAircraft;
            primaryAircraftContactVisualInput.GetComponent<InputField>().text = heliPlan.contactNum;

        }
        if (heliDropdownOne.value == 2)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One");

            n = (heliDropdownOne.value + 1) * 100;

            heliPlan.primaryAircraft = (PlayerPrefs.GetString((n + 6).ToString()));
            heliPlan.contactNum = (PlayerPrefs.GetString((n + 7).ToString()));

            primaryAircaftVisualInput.GetComponent<InputField>().text = heliPlan.primaryAircraft;
            primaryAircraftContactVisualInput.GetComponent<InputField>().text = heliPlan.contactNum;

        }
        if (heliDropdownOne.value == 3)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One");

            n = (heliDropdownOne.value + 1) * 100;

            heliPlan.primaryAircraft = (PlayerPrefs.GetString((n + 6).ToString()));
            heliPlan.contactNum = (PlayerPrefs.GetString((n + 7).ToString()));

            primaryAircaftVisualInput.GetComponent<InputField>().text = heliPlan.primaryAircraft;
            primaryAircraftContactVisualInput.GetComponent<InputField>().text = heliPlan.contactNum;

        }
        if (heliDropdownOne.value == 4)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One");

            n = (heliDropdownOne.value + 1) * 100;

            heliPlan.primaryAircraft = (PlayerPrefs.GetString((n + 6).ToString()));
            heliPlan.contactNum = (PlayerPrefs.GetString((n + 7).ToString()));

            primaryAircaftVisualInput.GetComponent<InputField>().text = heliPlan.primaryAircraft;
            primaryAircraftContactVisualInput.GetComponent<InputField>().text = heliPlan.contactNum;

        }
        if (heliDropdownOne.value == 5)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One");

            n = (heliDropdownOne.value + 1) * 100;

            heliPlan.primaryAircraft = (PlayerPrefs.GetString((n + 6).ToString()));
            heliPlan.contactNum = (PlayerPrefs.GetString((n + 7).ToString()));

            primaryAircaftVisualInput.GetComponent<InputField>().text = heliPlan.primaryAircraft;
            primaryAircraftContactVisualInput.GetComponent<InputField>().text = heliPlan.contactNum;

        }
#endregion HeliDropdown
    }
    public void OnHeliDropdownTwoSelection()
    {
        if (heliDropdownTwo.value == 0)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One");

            n = (heliDropdownTwo.value + 1) * 100;

            heliPlan.altAircraft = (PlayerPrefs.GetString((n + 6).ToString()));
            heliPlan.altAirConNum = (PlayerPrefs.GetString((n + 7).ToString()));

            secAircaftVisualInput.GetComponent<InputField>().text = heliPlan.altAircraft;
            secAircraftContactVisualInput.GetComponent<InputField>().text = heliPlan.altAirConNum;

        }

        if (heliDropdownTwo.value == 1)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One");

            n = (heliDropdownTwo.value + 1) * 100;

            heliPlan.altAircraft = (PlayerPrefs.GetString((n + 6).ToString()));
            heliPlan.altAirConNum = (PlayerPrefs.GetString((n + 7).ToString()));

            secAircaftVisualInput.GetComponent<InputField>().text = heliPlan.altAircraft;
            secAircraftContactVisualInput.GetComponent<InputField>().text = heliPlan.altAirConNum;

        }

        if (heliDropdownTwo.value == 2)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One");

            n = (heliDropdownTwo.value + 1) * 100;

            heliPlan.altAircraft = (PlayerPrefs.GetString((n + 6).ToString()));
            heliPlan.altAirConNum = (PlayerPrefs.GetString((n + 7).ToString()));

            secAircaftVisualInput.GetComponent<InputField>().text = heliPlan.altAircraft;
            secAircraftContactVisualInput.GetComponent<InputField>().text = heliPlan.altAirConNum;

        }

        if (heliDropdownTwo.value == 2)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One");

            n = (heliDropdownTwo.value + 1) * 100;

            heliPlan.altAircraft = (PlayerPrefs.GetString((n + 6).ToString()));
            heliPlan.altAirConNum = (PlayerPrefs.GetString((n + 7).ToString()));

            secAircaftVisualInput.GetComponent<InputField>().text = heliPlan.altAircraft;
            secAircraftContactVisualInput.GetComponent<InputField>().text = heliPlan.altAirConNum;

        }

        if (heliDropdownTwo.value == 3)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One");

            n = (heliDropdownTwo.value + 1) * 100;

            heliPlan.altAircraft = (PlayerPrefs.GetString((n + 6).ToString()));
            heliPlan.altAirConNum = (PlayerPrefs.GetString((n + 7).ToString()));

            secAircaftVisualInput.GetComponent<InputField>().text = heliPlan.altAircraft;
            secAircraftContactVisualInput.GetComponent<InputField>().text = heliPlan.altAirConNum;

        }

        if (heliDropdownTwo.value == 4)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One");

            n = (heliDropdownTwo.value + 1) * 100;

            heliPlan.altAircraft = (PlayerPrefs.GetString((n + 6).ToString()));
            heliPlan.altAirConNum = (PlayerPrefs.GetString((n + 7).ToString()));

            secAircaftVisualInput.GetComponent<InputField>().text = heliPlan.altAircraft;
            secAircraftContactVisualInput.GetComponent<InputField>().text = heliPlan.altAirConNum;

        }

        if (heliDropdownTwo.value == 5)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One");

            n = (heliDropdownTwo.value + 1) * 100;

            heliPlan.altAircraft = (PlayerPrefs.GetString((n + 6).ToString()));
            heliPlan.altAirConNum = (PlayerPrefs.GetString((n + 7).ToString()));

            secAircaftVisualInput.GetComponent<InputField>().text = heliPlan.altAircraft;
            secAircraftContactVisualInput.GetComponent<InputField>().text = heliPlan.altAirConNum;

        }

        if (heliDropdownTwo.value == 6)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One");

            n = (heliDropdownTwo.value + 1) * 100;

            heliPlan.altAircraft = (PlayerPrefs.GetString((n + 6).ToString()));
            heliPlan.altAirConNum = (PlayerPrefs.GetString((n + 7).ToString()));

            secAircaftVisualInput.GetComponent<InputField>().text = heliPlan.altAircraft;
            secAircraftContactVisualInput.GetComponent<InputField>().text = heliPlan.altAirConNum;

        }
    }
    //Add Opp
    public void OnAddOppDropdownOneSelected()
    {
        if (addOppDropdownOne.value == 0)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One");

            n = (addOppDropdownOne.value + 1) * 100;

            addOppInfo.emsRadio = (PlayerPrefs.GetString((n + 10).ToString()));
            addOppInfo.emsSupervisor = (PlayerPrefs.GetString((n + 11).ToString()));

            emsRadioVisualInput.GetComponent<InputField>().text = addOppInfo.emsRadio;
            emsSupervisorVisualInput.GetComponent<InputField>().text = addOppInfo.emsSupervisor;
        }

        if (addOppDropdownOne.value == 1)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected Two");

            n = (addOppDropdownOne.value + 1) * 100;

            addOppInfo.emsRadio = (PlayerPrefs.GetString((n + 10).ToString()));
            addOppInfo.emsSupervisor = (PlayerPrefs.GetString((n + 11).ToString()));

            emsRadioVisualInput.GetComponent<InputField>().text = addOppInfo.emsRadio;
            emsSupervisorVisualInput.GetComponent<InputField>().text = addOppInfo.emsSupervisor;
        }

        if (addOppDropdownOne.value == 2)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected Three");

            n = (addOppDropdownOne.value + 1) * 100;

            addOppInfo.emsRadio = (PlayerPrefs.GetString((n + 10).ToString()));
            addOppInfo.emsSupervisor = (PlayerPrefs.GetString((n + 11).ToString()));

            emsRadioVisualInput.GetComponent<InputField>().text = addOppInfo.emsRadio;
            emsSupervisorVisualInput.GetComponent<InputField>().text = addOppInfo.emsSupervisor;
        }

        if (addOppDropdownOne.value == 3)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected Four");

            n = (addOppDropdownOne.value + 1) * 100;

            addOppInfo.emsRadio = (PlayerPrefs.GetString((n + 10).ToString()));
            addOppInfo.emsSupervisor = (PlayerPrefs.GetString((n + 11).ToString()));

            emsRadioVisualInput.GetComponent<InputField>().text = addOppInfo.emsRadio;
            emsSupervisorVisualInput.GetComponent<InputField>().text = addOppInfo.emsSupervisor;
        }

        if (addOppDropdownOne.value == 4)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected Five");

            n = (addOppDropdownOne.value + 1) * 100;

            addOppInfo.emsRadio = (PlayerPrefs.GetString((n + 10).ToString()));
            addOppInfo.emsSupervisor = (PlayerPrefs.GetString((n + 11).ToString()));

            emsRadioVisualInput.GetComponent<InputField>().text = addOppInfo.emsRadio;
            emsSupervisorVisualInput.GetComponent<InputField>().text = addOppInfo.emsSupervisor;
        }

        if (addOppDropdownOne.value == 5)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected Six");

            n = (addOppDropdownOne.value + 1) * 100;

            addOppInfo.emsRadio = (PlayerPrefs.GetString((n + 10).ToString()));
            addOppInfo.emsSupervisor = (PlayerPrefs.GetString((n + 11).ToString()));

            emsRadioVisualInput.GetComponent<InputField>().text = addOppInfo.emsRadio;
            emsSupervisorVisualInput.GetComponent<InputField>().text = addOppInfo.emsSupervisor;
        }
    }
    public void OnAddOppDropdownTwoSelected()
    {
        if (addOppDropdownTwo.value == 0)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected One");

            n = (addOppDropdownTwo.value + 1) * 100;

            addOppInfo.FDradio = (PlayerPrefs.GetString((n + 12).ToString()));
            addOppInfo.fdOfficer = (PlayerPrefs.GetString((n + 13).ToString()));

            fdRadioVisualInput.GetComponent<InputField>().text = addOppInfo.FDradio;
            fdOfficerVisualInput.GetComponent<InputField>().text = addOppInfo.fdOfficer;
        }

        if (addOppDropdownTwo.value == 1)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected Two");

            n = (addOppDropdownTwo.value + 1) * 100;

            addOppInfo.FDradio = (PlayerPrefs.GetString((n + 12).ToString()));
            addOppInfo.fdOfficer = (PlayerPrefs.GetString((n + 13).ToString()));

            fdRadioVisualInput.GetComponent<InputField>().text = addOppInfo.FDradio;
            fdOfficerVisualInput.GetComponent<InputField>().text = addOppInfo.fdOfficer;
        }

        if (addOppDropdownTwo.value == 2)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected Three");

            n = (addOppDropdownTwo.value + 1) * 100;

            addOppInfo.FDradio = (PlayerPrefs.GetString((n + 12).ToString()));
            addOppInfo.fdOfficer = (PlayerPrefs.GetString((n + 13).ToString()));

            fdRadioVisualInput.GetComponent<InputField>().text = addOppInfo.FDradio;
            fdOfficerVisualInput.GetComponent<InputField>().text = addOppInfo.fdOfficer;
        }

        if (addOppDropdownTwo.value == 3)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected Four");

            n = (addOppDropdownTwo.value + 1) * 100;

            addOppInfo.FDradio = (PlayerPrefs.GetString((n + 12).ToString()));
            addOppInfo.fdOfficer = (PlayerPrefs.GetString((n + 13).ToString()));

            fdRadioVisualInput.GetComponent<InputField>().text = addOppInfo.FDradio;
            fdOfficerVisualInput.GetComponent<InputField>().text = addOppInfo.fdOfficer;
        }

        if (addOppDropdownTwo.value == 4)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected Five");

            n = (addOppDropdownTwo.value + 1) * 100;

            addOppInfo.FDradio = (PlayerPrefs.GetString((n + 12).ToString()));
            addOppInfo.fdOfficer = (PlayerPrefs.GetString((n + 13).ToString()));

            fdRadioVisualInput.GetComponent<InputField>().text = addOppInfo.FDradio;
            fdOfficerVisualInput.GetComponent<InputField>().text = addOppInfo.fdOfficer;
        }

        if (addOppDropdownTwo.value == 5)
        {
            //profille 1 is selected, assign value
            Debug.Log("Selected Six");

            n = (addOppDropdownTwo.value + 1) * 100;

            addOppInfo.FDradio = (PlayerPrefs.GetString((n + 12).ToString()));
            addOppInfo.fdOfficer = (PlayerPrefs.GetString((n + 13).ToString()));

            fdRadioVisualInput.GetComponent<InputField>().text = addOppInfo.FDradio;
            fdOfficerVisualInput.GetComponent<InputField>().text = addOppInfo.fdOfficer;
        }

    }

    /// <summary>
    ///  Unused Code
    /// </summary>

    ////testing to see if data is stored  FOR TESTING ONLY, WILL BE DISABLED
    //public void OnButtonTestSavedProfileData()
    //{
    //    int profLast = PlayerPrefs.GetInt("Last Profile");
    //    n = (profLast * 100);

    //    Debug.Log(PlayerPrefs.GetString((n + 1).ToString()));
    //    Debug.Log(PlayerPrefs.GetString((n + 2).ToString()));
    //    Debug.Log(PlayerPrefs.GetString((n + 3).ToString()));
    //    Debug.Log(PlayerPrefs.GetString((n + 4).ToString()));
    //    Debug.Log(PlayerPrefs.GetString((n + 5).ToString()));
    //    Debug.Log(PlayerPrefs.GetString((n + 6).ToString()));
    //    Debug.Log(PlayerPrefs.GetString((n + 7).ToString()));
    //    Debug.Log(PlayerPrefs.GetString((n + 8).ToString()));
    //    Debug.Log(PlayerPrefs.GetString((n + 9).ToString()));
    //    Debug.Log(PlayerPrefs.GetString((n + 10).ToString()));
    //    Debug.Log(PlayerPrefs.GetString((n + 11).ToString()));
    //    Debug.Log(PlayerPrefs.GetString((n + 12).ToString()));
    //    Debug.Log(PlayerPrefs.GetString((n + 13).ToString()));
    //    Debug.Log(PlayerPrefs.GetString((n + 14).ToString()));
    //    Debug.Log(PlayerPrefs.GetString((n + 15).ToString()));
    //    Debug.Log(PlayerPrefs.GetString((n + 16).ToString()));
    //    Debug.Log(PlayerPrefs.GetString((n + 17).ToString()));
    //    Debug.Log(PlayerPrefs.GetString((n + 18).ToString()));
    //    Debug.Log(PlayerPrefs.GetString((n + 19).ToString()));
    //    Debug.Log(PlayerPrefs.GetString((n + 20).ToString()));
    //    Debug.Log(PlayerPrefs.GetString((n + 21).ToString()));
    //    Debug.Log(PlayerPrefs.GetString((n + 22).ToString()));
    //    Debug.Log(PlayerPrefs.GetString((n + 23).ToString()));


    //    if (PlayerPrefs.HasKey("Profile1"))
    //    {
    //        Debug.Log(PlayerPrefs.GetString("Profile1"));  //returns the first profile name

    //    }

    //    if (PlayerPrefs.HasKey("Profile2"))
    //    {
    //        Debug.Log(PlayerPrefs.GetString("Profile2"));  //returns the first profile name

    //    }

    //    if (PlayerPrefs.HasKey("Profile3"))
    //    {
    //        Debug.Log(PlayerPrefs.GetString("Profile3"));  //returns the first profile name

    //    }

    //    if (PlayerPrefs.HasKey("Profile4"))
    //    {
    //        Debug.Log(PlayerPrefs.GetString("Profile4"));  //returns the first profile name

    //    }

    //    if (PlayerPrefs.HasKey("Profile5"))
    //    {
    //        Debug.Log(PlayerPrefs.GetString("Profile5"));  //returns the first profile name

    //    }

    //    if (PlayerPrefs.HasKey("Profile6"))
    //    {
    //        Debug.Log(PlayerPrefs.GetString("Profile6"));  //returns the first profile name

    //    }

    //    Debug.Log(PlayerPrefs.GetInt("Last Profile")); //returns the last profile numeric


    //}


    //public void UpdateProfileButtons()
    //{
    //    if (PlayerPrefs.HasKey("Profile1"))
    //    {
    //        loadButtonFirstProfileTextInput.text = "Load: " + PlayerPrefs.GetString("Profile1");
    //    }
    //    else
    //    {
    //        loadButtonFirstProfileTextInput.text = "No Save Data";
    //    }
    //    if (PlayerPrefs.HasKey("Profile2"))
    //    {
    //        loadButtonSecondProfileTextInput.text = "Load: " + PlayerPrefs.GetString("Profile2");
    //    }
    //    else
    //    {
    //        loadButtonSecondProfileTextInput.text = "No Save Data";
    //    }
    //    if (PlayerPrefs.HasKey("Profile3"))
    //    {
    //        loadButtonThirdProfileTextInput.text = "Load: " + PlayerPrefs.GetString("Profile3");
    //    }
    //    else
    //    {
    //        loadButtonThirdProfileTextInput.text = "No Save Data";
    //    }
    //}
    //public void OnButtonSaveProfileData()
    //{
    //    //if number of last proflie = 1 then
    //    //do nothing

    //    //if != 1 then increase it by one (there is a new profile being added)


    //    int profLast = PlayerPrefs.GetInt("Last Profile");
    //    profLast++;
    //    PlayerPrefs.SetInt("Last Profile", profLast);

    //    n = (profLast * 100);


    //    PlayerPrefs.SetString("Profile" + profLast.ToString(), profileName);
    //    //do this for each of the fields that need to be saved

    //    PlayerPrefs.SetString((n + 1).ToString(), hosFac.name);
    //    PlayerPrefs.SetString((n + 2).ToString(), hosFac.type);
    //    PlayerPrefs.SetString((n + 3).ToString(), hosFac.address);
    //    PlayerPrefs.SetString((n + 4).ToString(), hosFac.distance);
    //    PlayerPrefs.SetString((n + 5).ToString(), hosFac.edContactNum);

    //    PlayerPrefs.SetString((n + 6).ToString(), hosFac.name2);
    //    PlayerPrefs.SetString((n + 7).ToString(), hosFac.type2);
    //    PlayerPrefs.SetString((n + 8).ToString(), hosFac.address2);
    //    PlayerPrefs.SetString((n + 9).ToString(), hosFac.distance2);
    //    PlayerPrefs.SetString((n + 10).ToString(), hosFac.edContactNum2);

    //    PlayerPrefs.SetString((n + 12).ToString(), hosFac.name3);
    //    PlayerPrefs.SetString((n + 12).ToString(), hosFac.type3);
    //    PlayerPrefs.SetString((n + 13).ToString(), hosFac.address3);
    //    PlayerPrefs.SetString((n + 14).ToString(), hosFac.distance3);
    //    PlayerPrefs.SetString((n + 15).ToString(), hosFac.edContactNum3);

    //    PlayerPrefs.SetString((n + 16).ToString(), heliPlan.primaryAircraft);
    //    PlayerPrefs.SetString((n + 17).ToString(), heliPlan.contactNum);

    //    PlayerPrefs.SetString((n + 18).ToString(), heliPlan.altAircraft);
    //    PlayerPrefs.SetString((n + 19).ToString(), heliPlan.altAirConNum);

    //    PlayerPrefs.SetString((n + 20).ToString(), addOppInfo.emsRadio);
    //    PlayerPrefs.SetString((n + 21).ToString(), addOppInfo.emsSupervisor);
    //    PlayerPrefs.SetString((n + 22).ToString(), addOppInfo.FDradio);
    //    PlayerPrefs.SetString((n + 23).ToString(), addOppInfo.fdOfficer);

    //    UpdateProfileButtons();
    //}
    //public void OnButtonLoadFirstProfile()
    //{
    //    OnButtonLoadProfile(1);
    //}
    //public void OnButtonLoadSecondProfile()
    //{
    //    OnButtonLoadProfile(2);
    //}
    //public void OnButtonLoadThirdProfile()
    //{
    //    OnButtonLoadProfile(3);
    //}

    ////we assign the profile data to our current data struct and to the visuals
    //public void OnButtonLoadProfile(int ProfileSelected)
    //{
    //    n = (ProfileSelected * 100);
        
    //    //data  do this for each of the fields that need to be upadated

    //    hosFac.name = (PlayerPrefs.GetString((n + 1).ToString()));
    //    hosFac.type = (PlayerPrefs.GetString((n + 2).ToString()));
    //    hosFac.address = (PlayerPrefs.GetString((n + 3).ToString()));
    //    hosFac.distance = (PlayerPrefs.GetString((n + 4).ToString()));
    //    hosFac.edContactNum = (PlayerPrefs.GetString((n + 5).ToString()));

    //    hosFac.name2 = (PlayerPrefs.GetString((n + 6).ToString()));
    //    hosFac.type2 = (PlayerPrefs.GetString((n + 7).ToString()));
    //    hosFac.address2 = (PlayerPrefs.GetString((n + 8).ToString()));
    //    hosFac.distance2 = (PlayerPrefs.GetString((n + 9).ToString()));
    //    hosFac.edContactNum2 = (PlayerPrefs.GetString((n + 10).ToString()));

    //    hosFac.name3 = (PlayerPrefs.GetString((n + 11).ToString()));
    //    hosFac.type3 = (PlayerPrefs.GetString((n + 12).ToString()));
    //    hosFac.address3 = (PlayerPrefs.GetString((n + 13).ToString()));
    //    hosFac.distance3 = (PlayerPrefs.GetString((n + 14).ToString()));
    //    hosFac.edContactNum3 = (PlayerPrefs.GetString((n + 15).ToString()));

    //    heliPlan.primaryAircraft = (PlayerPrefs.GetString((n + 16).ToString()));
    //    heliPlan.contactNum = (PlayerPrefs.GetString((n + 17).ToString()));

    //    heliPlan.altAircraft = (PlayerPrefs.GetString((n + 18).ToString()));
    //    heliPlan.altAirConNum = (PlayerPrefs.GetString((n + 19).ToString()));

    //    addOppInfo.emsRadio = (PlayerPrefs.GetString((n + 20).ToString()));
    //    addOppInfo.emsSupervisor = (PlayerPrefs.GetString((n + 21).ToString()));
    //    addOppInfo.FDradio = (PlayerPrefs.GetString((n + 22).ToString()));
    //    addOppInfo.fdOfficer = (PlayerPrefs.GetString((n + 23).ToString()));

    //    //visuals, do this for each of the fields that need to be updated 

    //    primaryHospitalNameVisualInput.GetComponent<InputField>().text = hosFac.name;
    //    primaryHospitalTypeVisualInput.GetComponent<InputField>().text = hosFac.type;
    //    primaryHospitalAddressVisualInput.GetComponent<InputField>().text = hosFac.address;
    //    primaryHospitalDistanceVisualInput.GetComponent<InputField>().text = hosFac.distance;
    //    primaryHospitalEDContactVisualInput.GetComponent<InputField>().text = hosFac.edContactNum;

    //    secHospitalNameVisualInput.GetComponent<InputField>().text = hosFac.name2;
    //    secHospitalTypeVisualInput.GetComponent<InputField>().text = hosFac.type2;
    //    secHospitalAddressVisualInput.GetComponent<InputField>().text = hosFac.address2;
    //    secHospitalDistanceVisualInput.GetComponent<InputField>().text = hosFac.distance2;
    //    secHospitalEDContactVisualInput.GetComponent<InputField>().text = hosFac.edContactNum2;

    //    tertHospitalNameVisualInput.GetComponent<InputField>().text = hosFac.name3;
    //    tertHospitalTypeVisualInput.GetComponent<InputField>().text = hosFac.type3;
    //    tertHospitalAddressVisualInput.GetComponent<InputField>().text = hosFac.address3;
    //    tertHospitalDistanceVisualInput.GetComponent<InputField>().text = hosFac.distance3;
    //    tertHospitalEDContactVisualInput.GetComponent<InputField>().text = hosFac.edContactNum3;

    //    primaryAircaftVisualInput.GetComponent<InputField>().text = heliPlan.primaryAircraft;
    //    primaryAircraftContactVisualInput.GetComponent<InputField>().text = heliPlan.contactNum;

    //    secAircaftVisualInput.GetComponent<InputField>().text = heliPlan.altAircraft;
    //    secAircraftContactVisualInput.GetComponent<InputField>().text = heliPlan.altAirConNum;

    //    emsRadioVisualInput.GetComponent<InputField>().text = addOppInfo.emsRadio;
    //    emsSupervisorVisualInput.GetComponent<InputField>().text = addOppInfo.emsSupervisor;
    //    fdRadioVisualInput.GetComponent<InputField>().text = addOppInfo.FDradio;
    //    fdOfficerVisualInput.GetComponent<InputField>().text = addOppInfo.fdOfficer;
    //}

    public void OnTrainingButton()
    {
        Application.OpenURL("https://www.soarescue.com/courses");
    }

    public void OnSupplyButton()
    {
        Application.OpenURL("https://www.soarescue.com/shop");
    }

    public void DeleteFile(string filename)
    {

        string deletePath = Path.Combine("/private", "pdfDataTest.pdf");
#if UNITY_IOS
        System.IO.File.Delete(deletePath);        
#endif

#if UNITY_ANDROID || UNITY_EDITOR
        System.IO.File.Delete(filename);
#endif

    }
}
