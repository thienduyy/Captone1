using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndentifiedFace.Configurations
{
    public interface LanguagePackage
    {
        /* Form Login */

        string getMainFormTitle();
        string getErrorConnectToDatabaseMessage();
        string getErrorConnectToDatabaseTitle();
        string getAskRetryLoginMessage();
        string getAskRetryLoginTitle();
        string getConfirmQuitApplicationMessage();
        string getConfirmQuitApplicationTitle();
        string getAuthorName();
        string getLoginFormTitle();
        string getLoginButtonLabel();
        string getQuitButtonTitle();
        string getUsernameInputLabel();
        string getPasswordInputLabel();
        string getLoginFormFontName();
        string getLoginFormCaption();

        /* Form Main */
        string getMainFormQuitConfimMessage();
        string getMainFormQuitConfimTitle();
        string getStatusClassLabel();
        string getStatusQuantityLabel();
        string getNoDataSelectedWhenDeleteErrorMessage();
        string getNoDataSelectedWhenDeleteErrorTitle();
        string getMemberCodeAlias();
        string getDeleteMembersButtonLabel();
        string getAddMembersButtonLabel();
        string getMakingRollCallButtonLabel();
        string getMainFormMenuFileLabel();
        string getMainFormMenuFileMemberListLabel();
        string getMainFormMenuOperationLabel();
        string getMainFormMenuHelpLabel();
        string getMainFormMenuAboutLabel();

        /* Form About */
        string getAboutFormFontName();
        string getAboutFormMainCaptionFontName();
        string getAboutFormMainCaption();
        string getAboutFormTopCaption();
        string getAboutFormSubTopCaption();
        string getAboutFormCenterCaption();
        string getAboutFormSubTitle2();
        string getAboutFormSubTitle1();
        string getAboutFormTitle();


        string getLastNameAlias();
        string getFirstNameAlias();
        string getMaleAlias();
        string getFemaleAlias();
        string getSexAlias();
        string getBirthAlias();
        string getClassAlias();

        /* Form add */
        string getMemeberInfoBlockTitle();
        string getResetButtonTitle();
        string getAddMemberFormTitle();
        string getOperationsBlockTitle();

        /*  Serial Interaction  */
        string getMakingRollCallSuccessSerialMessage();
        string getMakingRollCallFailSerialMessage();

        string getFaceDetectingBlockTitle();
        string getCameraActionButtonLabel();
        string getMembersNotMakingRollCallYetTitle();
        string getMembersAlreadyMakingRollCallTitle();
        string getMakingRollCallOperationsBlockTitle();
        string getOutputDeviceSelectionTitle();
        string getMakingRollCallFormTitle();

        string getMemberNotFoundMessage();
        string getMemberNotFoundLabel();
    }
}
