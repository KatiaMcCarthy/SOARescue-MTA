using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pageNav : MonoBehaviour {

    public preplanningDocument preplanningDocument;

    #region pg 1 set
    //  [HideInInspector]
    public GameObject field1, field2, field3, field4, field5, field6, field7, field8, field9, field10, field11, field12, field13, field14, field15,
 field16,
  field17,
  field18,
  field19,
  field20,
 field21,
  field22,
 field23,
  field24,
  field25,
  field26,
  field27,
  field28,
  field29,
  field30,
  field31,
 field32,
  field33,
  field34,
  field35,
  filed36,
  field37,
  field38,
  field39,
  field40,
  field41,
        field42;

    #endregion pg 1 set

    #region add opp info
    // [HideInInspector]
    public GameObject
        aOI1,
        aOI2,
        aOI3,
        aOI4,
        aOI5,
        aOI6,
        aOI7,
        aOI8,
        aOI9,
        aOI10,
        aOI11,
        aOI12,
        aOI13,
        aOI14,
        aOI15,
        aOI16,
        aOI17,
        aOI18,
        aOI19,
        aOI20,
        aOI21,
        aOI22,
        aOI23,
        aOI24,
        aOI25,
        aOI26,
        aOI27,
        aOI28;

    #endregion add opp info

    #region heli set
    //  [HideInInspector]
    public GameObject he1,
      he2,
      he3,
      he4,
      he5,
      he6,
      he7,
      he8,
      he9,
      he10,
      he11,
      he12,
      he13,
      he14,
      he15,
      he16,
      he17,
      he18,
      he19,
      he20,
      he21,
      he22,
      he23,
      he24,
        he25,
        he26,
        he27,
        he28,
    he29,
    he30;
    #endregion heli set

    #region weather set
    //  [HideInInspector]
    public GameObject
        we1,
        we2,
        we3,
        we4,
        we5,
        we6,
        we7,
        we8,
        we9,
        we10,
        we11,
        we12,
        we13,
        we14,
        we15,
        we16,
        we17,
        we18,
        we19,
        we20,
        we21,
        we22,
        we23,
        we24,
        we25,
        we26,
        we27,
        we28,
        we29,
        we30,
        we31,
    we32,
        we33;
    #endregion weather set

    #region an set
    //  [HideInInspector]
    public GameObject
       an1,
       an2,
       an3,
       an4,
       an5,
       an6,
       an7,
       an8,
       an9,
       an10,
       an11,
       an12,
       an13,
       an14,
       an15,
       an16,
       an17,
       an18,
       an19,
       an20,
       an21,
       an22,
       an23,
       an24,
       an25,
       an26,
       an27,
       an28,
       an29,
       an30,
       an31,
        an32,
    an33,
        an34;
    #endregion an set

    #region public plant
    // [HideInInspector]
    public GameObject
       pp1,
       pp2,
       pp3,
       pp4,
       pp5,
       pp6,
       pp7,
       pp8,

       pp10,
       pp11,
       pp12,
       pp13,
       pp14,
       pp15,
       pp16,
       pp17,
       pp18,
       pp19,

       pp21,
       pp22,
       pp23,

        pp25,
        pp26,
        pp27,
        pp28,
        pp29,
        pp30,
        pp31;
    #endregion public plant

    #region Extended Opps
    //  [HideInInspector]
    public GameObject
       xo1,
       xo2,
       xo3,
       xo4,
       xo5,
       xo6,
       xo7,
       xo8,
       xo9,
       xo10,
       xo11,
       xo12,
       xo13,
       xo14,
       xo15,
       xo16,
       xo17,
       xo18,
       xo19,
        xo20,
        xo21,
        xo22,
        xo23,
        xo24,
        xo25;
    #endregion Extended Opps

    #region hazmat
    //  [HideInInspector]
    public GameObject
     hm1,
     hm2,
     hm3,
     hm4,
     hm5,
     hm6,
     hm7,
     hm8,
     hm9,
     hm10,
     hm11,
     hm12,
     hm13,
     hm14,
     hm15,
     hm16,
     hm17,
     hm18,
     hm19,
     hm20,
     hm21,
     hm22,
     hm23,
     hm24,
        hm25,
        hm26,
        hm27,
        hm28,
        hm29,
        hm30;
    #endregion hazmat

    #region hosFac
    //  [HideInInspector]
    public GameObject
   hf1,
   hf2,
   hf3,
   hf4,
   hf5,
   hf6,
   hf7,
   hf8,
   hf9,
   hf10,
   hf11,
   hf12,
   hf13,
   hf14,
   hf15,
   hf16,
   hf17,
   hf18,
      hf19,
      hf20,
      hf21,
      hf22,
               hf23,
        hf24,
        hf25,
        hf26,
        hf27;
    #endregion hosFac

    #region Other
    //[HideInInspector]
    public GameObject
ot1,
ot2,
ot3,
ot4,
ot5,
ot6,
ot7,
ot8,
ot9,
ot10,
ot11,
ot12,
ot13,
ot14,
ot15,
ot16,
ot17,
ot18,
       ot19,
       ot20,
       ot21,
        ot22,
    ot23,
        ot24;

    #endregion Other

    #region menu
    //  [HideInInspector]
    public GameObject
        buttonToOp,
        buttonToHeli,
        buttonToWeather,
        buttonToAni,
        buttonToPublic,
        buttonToExOp,
        buttonToHazMat,
        buttonToHosFac,
        buttonToOther,
        buttonGenTest,
        buttonGenPDF,
        buttonAddOppInfo,
        backgroundImage,
        backgroundLogo,
        buttonProfilePage;


    public GameObject
       bckImage,
       bckLogo,
       buttonSaveProfile,
       buttonToMenu,
       buttonClearProfileData,
       inputProfileName,
       textProfileName,
       buttonConfirmProfileName,
       buttonLoadProfile1,
       buttonLoadProfile2,
       buttonLoadProfile3,
       buttonTestSavedProfile;

    public GameObject
        bckImageHosProf,
        bckLogoHosProf,
        profileNameHosProf,
        profileNameTextHosProf,
        hosNameHosProf,
        hosTypeHosProf,
        hosAddressHosProf,
        hosDisanceHosProf,
        hosEDHosProf,
        hospiteTestDropdown,
        buttonSaveProfileHosProf,
        sampleText,
        buttonText,
        mainMenuButtonFromProfHos,
        pageNavToProfHeliFromHos,
        pageNavToProfAddFromHos;

    public GameObject
        bckImageMenuProf,
        bckLogoMenuProf,
        hospitleButtonProf,
        heliProfileButton,
        addOppButtonProfile,
        clearProfileData,
        mainMenuButtonFromProfMenu;

    public GameObject
        bckImageHeliProf,
        bckLogoHeliProf,
        profileNameHeliProf,
        profileNameTextHeliProf,
        heliAirPrimProf,
        heliAirPrimNumProf,
        heliAirPrimTextProf,
        buttonSaveProfileHeli,
        buttonHeliText,
        dropdwonHeliSample,
        mainMenuButtonFromHeliProf,
        pageNaveToProfHospFromHeli,
        pageNavToProfAddFromHeli;

    public GameObject
        bckImageAddOppProf,
        bckLogoAddOppProf,
        profileNameAddOppProf,
        profileNameTextAddOppProf,
        addOppEMSRadioProf,
        addOppEMSSupProf,
        addOppFDRadioProf,
        addOppFDSupProf,
        addOppButtonText,
        addOppDropdownSample,
        mainMenuButtonFromAddProf,
        addOppEMSText,
        addOppSaveProfileButton,
        addOppFDText,
        pageNavToProfHospFromAdd,
        pageNavToProfHeliFromAdd;

    public GameObject
        bckOpen,
        bckLogoOpen,
        MedicalThreatBtm,
        SupplyBtn,
        TrainingBtn;

    #endregion menu

    public GameObject[] oppInfoPageItems;
    public GameObject[] heliPageItems;
    public GameObject[] weatherPageItems;
    public GameObject[] animalPageItems;
    public GameObject[] publicPageItems;
    public GameObject[] extendedPageItems;
    public GameObject[] hazmatPageItems;
    public GameObject[] hosFacPageItems;
    public GameObject[] otherPageItems;
    public GameObject[] addOpInfoPageItems;
    public GameObject[] menuItems;
    public GameObject[] profilePageItems;
    public GameObject[] profileCreateItems;
    public GameObject[] profileHospitePageItems;
    public GameObject[] profileMenuItems;
    public GameObject[] profileHeliPageItems;
    public GameObject[] profileAddOppPageItems;
    public GameObject[] openScreenPageItems;

    // Use this for initialization
    void Start () {


        //add all of the stuff from page 1 to an array of objects

        profilePageItems = new GameObject[12];
        profilePageItems[0] = bckImage;
        profilePageItems[1] = bckLogo;
        profilePageItems[2] = buttonSaveProfile;
        profilePageItems[3] = buttonTestSavedProfile;
        profilePageItems[4] = buttonToMenu;
        profilePageItems[5] = buttonClearProfileData;
        profilePageItems[6] = buttonConfirmProfileName;
        profilePageItems[7] = textProfileName;
        profilePageItems[8] = inputProfileName;
        profilePageItems[9] = buttonLoadProfile1;
        profilePageItems[10] = buttonLoadProfile2;
        profilePageItems[11] = buttonLoadProfile3;

        openScreenPageItems = new GameObject[5];
        openScreenPageItems[0] = bckOpen;
        openScreenPageItems[1] = bckLogoOpen;
        openScreenPageItems[2] = MedicalThreatBtm;
        openScreenPageItems[3] = SupplyBtn;
        openScreenPageItems[4] = TrainingBtn;



        profileCreateItems = new GameObject[3];
        profileCreateItems[0] = buttonConfirmProfileName;
        profileCreateItems[1] = textProfileName;
        profileCreateItems[2] = inputProfileName;


        oppInfoPageItems = new GameObject[42];
        oppInfoPageItems[0] = field1;
        oppInfoPageItems[1] = field2;
        oppInfoPageItems[2] = field3;
        oppInfoPageItems[3] = field4;
        oppInfoPageItems[4] = field5;
        oppInfoPageItems[5] = field6;
        oppInfoPageItems[6] = field7;
        oppInfoPageItems[7] = field8;
        oppInfoPageItems[8] = field9;
        oppInfoPageItems[9] = field10;
        oppInfoPageItems[10] = field11;
        oppInfoPageItems[11] = field12;
        oppInfoPageItems[12] = field13;
        oppInfoPageItems[13] = field14;
        oppInfoPageItems[14] = field15;
        oppInfoPageItems[15] = field16;
        oppInfoPageItems[16] = field17;
        oppInfoPageItems[17] = field18;
        oppInfoPageItems[18] = field19;
        oppInfoPageItems[19] = field20;
        oppInfoPageItems[20] = field21;
        oppInfoPageItems[21] = field22;
        oppInfoPageItems[22] = field23;
        oppInfoPageItems[23] = field24;
        oppInfoPageItems[24] = field25;
        oppInfoPageItems[25] = field26;
        oppInfoPageItems[26] = field27;
        oppInfoPageItems[27] = field28;
        oppInfoPageItems[28] = field29;
        oppInfoPageItems[29] = field30;
        oppInfoPageItems[30] = field31;
        oppInfoPageItems[31] = field32;
        oppInfoPageItems[32] = field33;
        oppInfoPageItems[33] = field34;
        oppInfoPageItems[34] = field35;
        oppInfoPageItems[35] = filed36;
        oppInfoPageItems[36] = field37;
        oppInfoPageItems[37] = field38;
        oppInfoPageItems[38] = field39;
        oppInfoPageItems[39] = field40;
        oppInfoPageItems[40] = field41;
        oppInfoPageItems[41] = field42;

        addOpInfoPageItems = new GameObject[28];
        addOpInfoPageItems[0] = aOI1;
        addOpInfoPageItems[1] = aOI2;
        addOpInfoPageItems[2] = aOI3;
        addOpInfoPageItems[3] = aOI4;
        addOpInfoPageItems[4] = aOI5;
        addOpInfoPageItems[5] = aOI6;
        addOpInfoPageItems[6] = aOI7;
        addOpInfoPageItems[7] = aOI8;
        addOpInfoPageItems[8] = aOI9;
        addOpInfoPageItems[9] = aOI10;
        addOpInfoPageItems[10] = aOI11;
        addOpInfoPageItems[11] = aOI12;
        addOpInfoPageItems[12] = aOI13;
        addOpInfoPageItems[13] = aOI14;
        addOpInfoPageItems[14] = aOI15;
        addOpInfoPageItems[15] = aOI16;
        addOpInfoPageItems[16] = aOI17;
        addOpInfoPageItems[17] = aOI18;
        addOpInfoPageItems[18] = aOI19;
        addOpInfoPageItems[19] = aOI20;
        addOpInfoPageItems[20] = aOI21;
        addOpInfoPageItems[21] = aOI22;
        addOpInfoPageItems[22] = aOI23;
        addOpInfoPageItems[23] = aOI24;
        addOpInfoPageItems[24] = aOI25;
        addOpInfoPageItems[25] = aOI26;
        addOpInfoPageItems[26] = aOI27;
        addOpInfoPageItems[27] = aOI28;


        menuItems = new GameObject[15];
        menuItems[0] = buttonToOp;
        menuItems[1] = buttonToHeli;
        menuItems[2] = buttonToWeather;
        menuItems[3] = buttonToAni;
        menuItems[4] = buttonToPublic;
        menuItems[5] = buttonToExOp;
        menuItems[6] = buttonToHazMat;
        menuItems[7] = buttonToHosFac;
        menuItems[8] = buttonToOther;
        menuItems[9] = buttonGenTest;
        menuItems[10] = buttonGenPDF;
        menuItems[11] = buttonAddOppInfo;
        menuItems[12] = backgroundImage;
        menuItems[13] = backgroundLogo;
        menuItems[14] = buttonProfilePage;

        heliPageItems = new GameObject[30];
        heliPageItems[0] = he1;
        heliPageItems[1] = he2;
        heliPageItems[2] = he3;
        heliPageItems[3] = he4;
        heliPageItems[4] = he5;
        heliPageItems[5] = he6;
        heliPageItems[6] = he7;
        heliPageItems[7] = he8;
        heliPageItems[8] = he9;
        heliPageItems[9] = he10;
        heliPageItems[10] = he11;
        heliPageItems[11] = he12;
        heliPageItems[12] = he13;
        heliPageItems[13] = he14;
        heliPageItems[14] = he15;
        heliPageItems[15] = he16;
        heliPageItems[16] = he17;
        heliPageItems[17] = he18;
        heliPageItems[18] = he19;
        heliPageItems[19] = he20;
        heliPageItems[20] = he21;
        heliPageItems[21] = he22;
        heliPageItems[22] = he23;
        heliPageItems[23] = he24;
        heliPageItems[24] = he25;
        heliPageItems[25] = he26;
        heliPageItems[26] = he27;
        heliPageItems[27] = he28;
        heliPageItems[28] = he29;
        heliPageItems[29] = he30;

        weatherPageItems = new GameObject[33];
        weatherPageItems[0] = we1;
        weatherPageItems[1] = we2;
        weatherPageItems[2] = we3;
        weatherPageItems[3] = we4;
        weatherPageItems[4] = we5;
        weatherPageItems[5] = we6;
        weatherPageItems[6] = we7;
        weatherPageItems[7] = we8;
        weatherPageItems[8] = we9;
        weatherPageItems[9] = we10;
        weatherPageItems[10] = we11;
        weatherPageItems[11] = we12;
        weatherPageItems[12] = we13;
        weatherPageItems[13] = we14;
        weatherPageItems[14] = we15;
        weatherPageItems[15] = we16;
        weatherPageItems[16] = we17;
        weatherPageItems[17] = we18;
        weatherPageItems[18] = we19;
        weatherPageItems[19] = we20;
        weatherPageItems[20] = we21;
        weatherPageItems[21] = we22;
        weatherPageItems[22] = we23;
        weatherPageItems[23] = we24;
        weatherPageItems[24] = we25;
        weatherPageItems[25] = we26;
        weatherPageItems[26] = we27;
        weatherPageItems[27] = we28;
        weatherPageItems[28] = we29;
        weatherPageItems[29] = we30;
        weatherPageItems[30] = we31;
        weatherPageItems[31] = we32;
        weatherPageItems[32] = we33;

        animalPageItems = new GameObject[34];
        animalPageItems[0] = an1;
        animalPageItems[1] = an2;
        animalPageItems[2] = an3;
        animalPageItems[3] = an4;
        animalPageItems[4] = an5;
        animalPageItems[5] = an6;
        animalPageItems[6] = an7;
        animalPageItems[7] = an8;
        animalPageItems[8] = an9;
        animalPageItems[9] = an10;
        animalPageItems[10] = an11;
        animalPageItems[11] = an12;
        animalPageItems[12] = an13;
        animalPageItems[13] = an14;
        animalPageItems[14] = an15;
        animalPageItems[15] = an16;
        animalPageItems[16] = an17;
        animalPageItems[17] = an18;
        animalPageItems[18] = an19;
        animalPageItems[19] = an20;
        animalPageItems[20] = an21;
        animalPageItems[21] = an22;
        animalPageItems[22] = an23;
        animalPageItems[23] = an24;
        animalPageItems[24] = an25;
        animalPageItems[25] = an26;
        animalPageItems[26] = an27;
        animalPageItems[27] = an28;
        animalPageItems[28] = an29;
        animalPageItems[29] = an30;
        animalPageItems[30] = an31;
        animalPageItems[31] = an32;
        animalPageItems[32] = an33;
        animalPageItems[33] = an34;

        publicPageItems = new GameObject[28];
        publicPageItems[0] = pp1;
        publicPageItems[1] = pp2;
        publicPageItems[2] = pp3;
        publicPageItems[3] = pp4;
        publicPageItems[4] = pp5;
        publicPageItems[5] = pp6;
        publicPageItems[6] = pp7;
        publicPageItems[7] = pp8;
  
        publicPageItems[8] = pp10;
        publicPageItems[9] = pp11;
        publicPageItems[10] = pp12;
        publicPageItems[11] = pp13;
        publicPageItems[12] = pp14;
        publicPageItems[13] = pp15;
        publicPageItems[14] = pp16;
        publicPageItems[15] = pp17;
        publicPageItems[16] = pp18;
        publicPageItems[17] = pp19;

        publicPageItems[18] = pp21;
        publicPageItems[19] = pp22;
        publicPageItems[20] = pp23;

        publicPageItems[21] = pp25;
        publicPageItems[22] = pp26;
        publicPageItems[23] = pp27;
        publicPageItems[24] = pp28;
        publicPageItems[25] = pp29;
        publicPageItems[26] = pp30;
        publicPageItems[27] = pp31;

        extendedPageItems = new GameObject[25];
        extendedPageItems[0] = xo1;
        extendedPageItems[1] = xo2;
        extendedPageItems[2] = xo3;
        extendedPageItems[3] = xo4;
        extendedPageItems[4] = xo5;
        extendedPageItems[5] = xo6;
        extendedPageItems[6] = xo7;
        extendedPageItems[7] = xo8;
        extendedPageItems[8] = xo9;
        extendedPageItems[9] = xo10;
        extendedPageItems[10] = xo11;
        extendedPageItems[11] = xo12;
        extendedPageItems[12] = xo13;
        extendedPageItems[13] = xo14;
        extendedPageItems[14] = xo15;
        extendedPageItems[15] = xo16;
        extendedPageItems[16] = xo17;
        extendedPageItems[17] = xo18;
        extendedPageItems[18] = xo19;
        extendedPageItems[19] = xo20;
        extendedPageItems[20] = xo21;
        extendedPageItems[21] = xo22;
        extendedPageItems[22] = xo23;
        extendedPageItems[23] = xo24;
        extendedPageItems[24] = xo25;

        hazmatPageItems = new GameObject[30];
        hazmatPageItems[0] = hm1;
        hazmatPageItems[1] = hm2;
        hazmatPageItems[2] = hm3;
        hazmatPageItems[3] = hm4;
        hazmatPageItems[4] = hm5;
        hazmatPageItems[5] = hm6;
        hazmatPageItems[6] = hm7;
        hazmatPageItems[7] = hm8;
        hazmatPageItems[8] = hm9;
        hazmatPageItems[9] = hm10;
        hazmatPageItems[10] = hm11;
        hazmatPageItems[11] = hm12;
        hazmatPageItems[12] = hm13;
        hazmatPageItems[13] = hm14;
        hazmatPageItems[14] = hm15;
        hazmatPageItems[15] = hm16;
        hazmatPageItems[16] = hm17;
        hazmatPageItems[17] = hm18;
        hazmatPageItems[18] = hm19;
        hazmatPageItems[19] = hm20;
        hazmatPageItems[20] = hm21;
        hazmatPageItems[21] = hm22;
        hazmatPageItems[22] = hm23;
        hazmatPageItems[23] = hm24;
        hazmatPageItems[24] = hm25;
        hazmatPageItems[25] = hm26;
        hazmatPageItems[26] = hm27;
        hazmatPageItems[27] = hm28;
        hazmatPageItems[28] = hm29;
        hazmatPageItems[29] = hm30;

        hosFacPageItems = new GameObject[27];
        hosFacPageItems[0] = hf1;
        hosFacPageItems[1] = hf2;
        hosFacPageItems[2] = hf3;
        hosFacPageItems[3] = hf4;
        hosFacPageItems[4] = hf5;
        hosFacPageItems[5] = hf6;
        hosFacPageItems[6] = hf7;
        hosFacPageItems[7] = hf8;
        hosFacPageItems[8] = hf9;
        hosFacPageItems[9] = hf10;
        hosFacPageItems[10] = hf11;
        hosFacPageItems[11] = hf12;
        hosFacPageItems[12] = hf13;
        hosFacPageItems[13] = hf14;
        hosFacPageItems[14] = hf15;
        hosFacPageItems[15] = hf16;
        hosFacPageItems[16] = hf17;
        hosFacPageItems[17] = hf18;
        hosFacPageItems[18] = hf19;
        hosFacPageItems[19] = hf20;
        hosFacPageItems[20] = hf21;
        hosFacPageItems[21] = hf22;
        hosFacPageItems[22] = hf23;
        hosFacPageItems[23] = hf24;
        hosFacPageItems[24] = hf25;
        hosFacPageItems[25] = hf26;
        hosFacPageItems[26] = hf27;

        otherPageItems = new GameObject[24];
        otherPageItems[0] = ot1;
        otherPageItems[1] = ot2;
        otherPageItems[2] = ot3;
        otherPageItems[3] = ot4;
        otherPageItems[4] = ot5;
        otherPageItems[5] = ot6;
        otherPageItems[6] = ot7;
        otherPageItems[7] = ot8;
        otherPageItems[8] = ot9;
        otherPageItems[9] = ot10;
        otherPageItems[10] = ot11;
        otherPageItems[11] = ot12;
        otherPageItems[12] = ot13;
        otherPageItems[13] = ot14;
        otherPageItems[14] = ot15;
        otherPageItems[15] = ot16;
        otherPageItems[16] = ot17;
        otherPageItems[17] = ot18;
        otherPageItems[18] = ot19;
        otherPageItems[19] = ot20;
        otherPageItems[20] = ot21;
        otherPageItems[21] = ot22;
        otherPageItems[22] = ot23;
        otherPageItems[23] = ot24;

        profileHospitePageItems = new GameObject[16];
        profileHospitePageItems[0] = bckImageHosProf;
        profileHospitePageItems[1] = bckLogoHosProf;
        profileHospitePageItems[2] = profileNameHosProf;
        profileHospitePageItems[3] = profileNameTextHosProf;
        profileHospitePageItems[4] = hosNameHosProf;
        profileHospitePageItems[5] = hosTypeHosProf;
        profileHospitePageItems[6] = hosAddressHosProf;
        profileHospitePageItems[7] = hosDisanceHosProf;
        profileHospitePageItems[8] = hosEDHosProf;
        profileHospitePageItems[9] = hospiteTestDropdown;
        profileHospitePageItems[10] = buttonSaveProfileHosProf;
        profileHospitePageItems[11] = sampleText;
        profileHospitePageItems[12] = buttonText;
        profileHospitePageItems[13] = mainMenuButtonFromProfHos;
        profileHospitePageItems[14] = pageNavToProfAddFromHos;
        profileHospitePageItems[15] = pageNavToProfHeliFromHos;

        profileHeliPageItems = new GameObject[13];
        profileHeliPageItems[0] = bckImageHeliProf;
        profileHeliPageItems[1] = bckLogoHeliProf;
        profileHeliPageItems[2] = profileNameHeliProf;
        profileHeliPageItems[3] = profileNameTextHeliProf;
        profileHeliPageItems[4] = heliAirPrimProf;
        profileHeliPageItems[5] = heliAirPrimNumProf;
        profileHeliPageItems[6] = heliAirPrimTextProf;
        profileHeliPageItems[7] = buttonSaveProfileHeli;
        profileHeliPageItems[8] = buttonHeliText;
        profileHeliPageItems[9] = mainMenuButtonFromHeliProf;
        profileHeliPageItems[10] = dropdwonHeliSample;
        profileHeliPageItems[11] = pageNaveToProfHospFromHeli;
        profileHeliPageItems[12] = pageNavToProfAddFromHeli;

        profileAddOppPageItems = new GameObject[16];

        profileAddOppPageItems[0] = bckImageAddOppProf;
        profileAddOppPageItems[1] = bckLogoAddOppProf;
        profileAddOppPageItems[2] = profileNameAddOppProf;
        profileAddOppPageItems[3] = profileNameTextAddOppProf;
        profileAddOppPageItems[4] = addOppEMSRadioProf;
        profileAddOppPageItems[5] = addOppEMSSupProf;
        profileAddOppPageItems[6] = addOppFDRadioProf;
        profileAddOppPageItems[7] = addOppFDSupProf;
        profileAddOppPageItems[8] = addOppButtonText;
        profileAddOppPageItems[9] = addOppDropdownSample;
        profileAddOppPageItems[10] = mainMenuButtonFromAddProf;
        profileAddOppPageItems[11] = addOppEMSText;
        profileAddOppPageItems[12] = addOppSaveProfileButton;
        profileAddOppPageItems[13] = addOppFDText;
        profileAddOppPageItems[14] = pageNavToProfHeliFromAdd;
        profileAddOppPageItems[15] = pageNavToProfHospFromAdd;



        profileMenuItems = new GameObject[7];
        profileMenuItems[0] = bckImageMenuProf;
        profileMenuItems[1] = bckLogoMenuProf;
        profileMenuItems[2] = hospitleButtonProf;
        profileMenuItems[3] = heliProfileButton;
        profileMenuItems[4] = addOppButtonProfile;
        profileMenuItems[5] = clearProfileData;
        profileMenuItems[6] = mainMenuButtonFromProfMenu;

        foreach (GameObject item in oppInfoPageItems)
        {
            item.SetActive(false);
        }

        foreach (GameObject item in heliPageItems)
        {
            item.SetActive(false);
        }

        foreach (GameObject item in weatherPageItems)
        {
            item.SetActive(false);
        }

        foreach (GameObject item in animalPageItems)
        {
            item.SetActive(false);
        }

        foreach (GameObject item in publicPageItems)
        {
            item.SetActive(false);
        }

        foreach (GameObject item in extendedPageItems)
        {
            item.SetActive(false);
        }

        foreach (GameObject item in hazmatPageItems)
        {
            item.SetActive(false);
        }

        foreach (GameObject item in hosFacPageItems)
        {
            item.SetActive(false);
        }

        foreach (GameObject item in otherPageItems)
        {
            item.SetActive(false);
        }

        foreach (GameObject item in addOpInfoPageItems)
        {
            item.SetActive(false);
        }

        foreach (GameObject item in profilePageItems)
        {
            item.SetActive(false);
        }

        foreach (GameObject item in profileHospitePageItems)
        {
            item.SetActive(false);
        }

        foreach (GameObject item in profileHeliPageItems)
        {
            item.SetActive(false);
        }

        foreach (GameObject item in profileMenuItems)
        {
            item.SetActive(false);
        }

        foreach (GameObject item in profileAddOppPageItems)
        {
            item.SetActive(false);
        }

        foreach (GameObject item in menuItems)
        {
            item.SetActive(false);
        }
    }

    public void OnOpenToMenu()
    {
        foreach (GameObject item in openScreenPageItems)
        {
            item.SetActive(false);
        }

        foreach (GameObject item in menuItems)
        {
            item.SetActive(true);
        }
    }

    public void OnButtonOppInfo()
    {
        //hides the current ui

        foreach (GameObject item in menuItems)
        {
            item.SetActive(false);
        }

        // shows the page we are going to ui

        foreach (GameObject item in oppInfoPageItems)
        {
            item.SetActive(true);
        }
    }

    public void OnButtonAddOppInfo()
    {
        //hides the current ui

        foreach (GameObject item in menuItems)
        {
            item.SetActive(false);
        }

        // shows the page we are going to ui

        foreach (GameObject item in addOpInfoPageItems)
        {
            item.SetActive(true);
        }
    }

    public void OnButtonHeli()
    {
        //hides the current ui

        foreach (GameObject item in menuItems)
        {
            item.SetActive(false);
        }

        // shows the page we are going to ui

        foreach (GameObject item in heliPageItems)
        {
            item.SetActive(true);
        }
    }

    public void OnButtonHospitleFacilties()
    {
        //hides the current ui

        foreach (GameObject item in menuItems)
        {
            item.SetActive(false);
        }

        // shows the page we are going to ui

        foreach (GameObject item in hosFacPageItems)
        {
            item.SetActive(true);
        }
    }

    public void OnButtonWeather()
    {
        //hides the current ui

        foreach (GameObject item in menuItems)
        {
            item.SetActive(false);
        }

        // shows the page we are going to ui

        foreach (GameObject item in weatherPageItems)
        {
            item.SetActive(true);
        }
    }

    public void OnButtonAnimalThreats()
    {
        //hides the current ui

        foreach (GameObject item in menuItems)
        {
            item.SetActive(false);
        }

        // shows the page we are going to ui

        foreach (GameObject item in animalPageItems)
        {
            item.SetActive(true);
        }
    }

    public void OnButtonPlantThreats()
    {
        //hides the current ui

        foreach (GameObject item in menuItems)
        {
            item.SetActive(false);
        }

        // shows the page we are going to ui

        foreach (GameObject item in publicPageItems)
        {
            item.SetActive(true);
        }
    }

    public void OnButtonHazMat()
    {
        //hides the current ui

        foreach (GameObject item in menuItems)
        {
            item.SetActive(false);
        }

        // shows the page we are going to ui

        foreach (GameObject item in hazmatPageItems)
        {
            item.SetActive(true);
        }
    }

    public void OnButtonExtendedOp()
    {
        //hides the current ui

        foreach (GameObject item in menuItems)
        {
            item.SetActive(false);
        }

        // shows the page we are going to ui

        foreach (GameObject item in extendedPageItems)
        {
            item.SetActive(true);
        }
    }

    public void OnButtonOther()
    {
        //hides the current ui

        foreach (GameObject item in menuItems)
        {
            item.SetActive(false);
        }

        // shows the page we are going to ui

        foreach (GameObject item in otherPageItems)
        {
            item.SetActive(true);
        }
    }

    public void OnButtonProfileManage()
    {
        foreach (GameObject item in menuItems)
        {
            item.SetActive(false);
        }

        // shows the page we are going to ui

        foreach (GameObject item in profilePageItems)
        {
            item.SetActive(true);
        }

        foreach (GameObject item in profileCreateItems)
        {
            item.SetActive(false);
        }
    }

    public void OnButtonProfileMenu()
    {
        foreach (GameObject item in menuItems)
        {
            item.SetActive(false);
        }

        foreach (GameObject item in profileMenuItems)
        {
            item.SetActive(true);
        }
    }

/// <summary>
/// now looking at pages to menu
/// </summary>

    public void OnMenuButtonFromOppInfo()
    {
        foreach (GameObject item in oppInfoPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in menuItems)
        {
            item.SetActive(true);
        }

    }

    public void OnMenuButtonFromAddOppInfo()
    {
        foreach (GameObject item in addOpInfoPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in menuItems)
        {
            item.SetActive(true);
        }
    }

    public void OnMenuButtonFromHosFac()
    {
        foreach (GameObject item in hosFacPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in menuItems)
        {
            item.SetActive(true);
        }

    }

    public void OnMenuButtonFromHeli()
    {
        foreach (GameObject item in heliPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in menuItems)
        {
            item.SetActive(true);
        }

    }

    public void OnMenuButtonFromWeather()
    {
        foreach (GameObject item in weatherPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in menuItems)
        {
            item.SetActive(true);
        }

    }

    public void OnMenuButtonFromAnimal()
    {
        foreach (GameObject item in animalPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in menuItems)
        {
            item.SetActive(true);
        }

    }

    public void OnMenuButtonFromPublic()
    {
        foreach (GameObject item in publicPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in menuItems)
        {
            item.SetActive(true);
        }

    }

    public void OnMenuButtonFromHazMat()
    {
        foreach (GameObject item in hazmatPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in menuItems)
        {
            item.SetActive(true);
        }

    }

    public void OnMenuButtonFromExtendOpp()
    {
        foreach (GameObject item in extendedPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in menuItems)
        {
            item.SetActive(true);
        }

    }

    public void OnMenuButtonFromOther()
    {
        foreach (GameObject item in otherPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in menuItems)
        {
            item.SetActive(true);
        }

    }

    public void OnMenuButtonFromProfileManage()
    {
        foreach (GameObject item in profilePageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in menuItems)
        {
            item.SetActive(true);
        }

    }

    public void OnMenuButtonFromProfileHos()
    {
        foreach (GameObject item in profileHospitePageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in menuItems)
        {
            item.SetActive(true);
        }
    }

    public void OnMenuButtonFromProfileHeli()
    {
        foreach (GameObject item in profileHeliPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in menuItems)
        {
            item.SetActive(true);
        }
    }

    public void OnMenuButtonFromProfileAddOpp()
    {
        foreach (GameObject item in profileAddOppPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in menuItems)
        {
            item.SetActive(true);
        }
    }


    public void OnMenuButtonFromProfileMenu()
    {
        foreach (GameObject item in profileMenuItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in menuItems)
        {
            item.SetActive(true);
        }
    }

    /// <summary>
    /// now looking at pages to pages
    /// </summary>
    /// 

    //left button opp info
    public void OnOppInfoToMenu()
    {
        foreach (GameObject item in oppInfoPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in menuItems)
        {
            item.SetActive(true);
        }
    }
       //right button opp info
    public void OnOppInfoToAddOppInfo()
    {
        foreach (GameObject item in oppInfoPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in addOpInfoPageItems)
        {
            item.SetActive(true);
        }
    }

    //left button add opp info
    public void OnAddOppInfoToOppInfo()
    {
        foreach (GameObject item in addOpInfoPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in oppInfoPageItems)
        {
            item.SetActive(true);
        }
    }
    //right button add opp info
    public void OnAddOppInfoToHosFac()
    {
        foreach (GameObject item in addOpInfoPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in hosFacPageItems)
        {
            item.SetActive(true);
        }
    }
    //left button hos fac
    public void OnHosFacToAddOppInfo()
    {
        foreach (GameObject item in hosFacPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in addOpInfoPageItems)
        {
            item.SetActive(true);
        }
    }
    //right button hos fac
    public void OnHosFacToHeliPlan()
    {
        foreach (GameObject item in hosFacPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in heliPageItems)
        {
            item.SetActive(true);
        }
    }

    //left button heli plan
    public void OnHeliPlanToHosFac()
    {
        foreach (GameObject item in heliPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in hosFacPageItems)
        {
            item.SetActive(true);
        }
    }
    //right button heli plan
    public void OnHeliPlanToWeather()
    {
        foreach (GameObject item in heliPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in weatherPageItems)
        {
            item.SetActive(true);
        }
    }

    //left button weater
    public void OnWeatherToHeliPlan()
    {
        foreach (GameObject item in weatherPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in heliPageItems)
        {
            item.SetActive(true);
        }
    }
    //right button weather
    public void OnWeatherToAnimalThreats()
    {
        foreach (GameObject item in weatherPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in animalPageItems)
        {
            item.SetActive(true);
        }
    }

    //left button Animal Threats
    public void OnAnimalThreatsToWeather()
    {
        foreach (GameObject item in animalPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in weatherPageItems)
        {
            item.SetActive(true);
        }
    }
    //right button Animal Threats
    public void OnAnimalThreatsToPlant()
    {
        foreach (GameObject item in animalPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in publicPageItems)
        {
            item.SetActive(true);
        }
    }

    //Left button public
    public void OnPublicToAnimal()
    {
        foreach (GameObject item in publicPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in animalPageItems)
        {
            item.SetActive(true);
        }
    }
    //right button public
    public void OnPublicToHazMat()
    {
        foreach (GameObject item in publicPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in hazmatPageItems)
        {
            item.SetActive(true);
        }
    }

    //left button haz
    public void OnHazMatToPublic()
    {
        foreach (GameObject item in hazmatPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in publicPageItems)
        {
            item.SetActive(true);
        }
    }
    //right button haz
    public void OnHazMatToExOp()
    {
        foreach (GameObject item in hazmatPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in extendedPageItems)
        {
            item.SetActive(true);
        }
    }

    //left button ex op
    public void OnExOppToHazMat()
    {
        foreach (GameObject item in extendedPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in hazmatPageItems)
        {
            item.SetActive(true);
        }
    }
    //right button ex op
    public void OnExOppToOther()
    {
        foreach (GameObject item in extendedPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in otherPageItems)
        {
            item.SetActive(true);
        }
    }

    //left button other
    public void OnOtherToExOpp()
    {
        foreach (GameObject item in otherPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in extendedPageItems)
        {
            item.SetActive(true);
        }
    }
    //Right button other
    public void OnOtherToMenu()
    {
        foreach (GameObject item in otherPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in menuItems)
        {
            item.SetActive(true);
        }
    }

    public void OnMainMenuToOpen()
    {
        foreach (GameObject item in menuItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in openScreenPageItems)
        {
            item.SetActive(true);
        }
    }

    public void OnProfileSaveButtonPressed ()
    {
        foreach (GameObject item in profileCreateItems)
        {
            item.SetActive(true);
        }

    }

    public void OnProfileConfirmButtonPressed()
    {
        foreach (GameObject item in profileCreateItems)
        {
            item.SetActive(false);
        }
    }


    //Profile Menu Nav

    public void OnProfileMenuToHospitle()
    {
        foreach (GameObject item in profileMenuItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in profileHospitePageItems)
        {
            item.SetActive(true);
        }

        preplanningDocument.OnClearEntryDataProfile();
    }

    public void OnProfileMenuToHeli()
    {
        foreach (GameObject item in profileMenuItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in profileHeliPageItems)
        {
            item.SetActive(true);
        }

        preplanningDocument.OnClearEntryDataProfile();
    }

    public void OnProfileMenuToAddOpp()
    {
        foreach (GameObject item in profileMenuItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in profileAddOppPageItems)
        {
            item.SetActive(true);
        }

        preplanningDocument.OnClearEntryDataProfile();
    }


    public void OnProfileHosToHeli()
    {
        foreach (GameObject item in profileHospitePageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in profileHeliPageItems)
        {
            item.SetActive(true);
        }
    }

    public void OnProfileHosToProfAddOpp()
    {
        foreach (GameObject item in profileHospitePageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in profileAddOppPageItems)
        {
            item.SetActive(true);
        }
    }

    public void OnProfileHeliToProfileHosp()
    {
        foreach (GameObject item in profileHeliPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in profileHospitePageItems)
        {
            item.SetActive(true);
        }
    }

    public void OnProfileHeliToProfileAddOpp()
    {
        foreach (GameObject item in profileHeliPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in profileAddOppPageItems)
        {
            item.SetActive(true);
        }
    }

    public void OnProfileAddToProfileHosp()
    {
        foreach (GameObject item in profileAddOppPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in profileHospitePageItems)
        {
            item.SetActive(true);
        }   
    }

    public void OnProfileAddToProfileHeli()
    {
        foreach (GameObject item in profileAddOppPageItems)
        {
            item.SetActive(false);
        }


        foreach (GameObject item in profileHeliPageItems)
        {
            item.SetActive(true);
        }
    }
}
