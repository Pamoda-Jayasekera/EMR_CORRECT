<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Acute Kidney Injury.aspx.cs" Inherits="EMR.Acute_Kidney_Injury" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        /* Center the content block */
        .centerblock {
            text-align: center;
        }

        /* Space between elements */
        .space {
            height: 20px;
        }

        /* Style for the Prediction Name */
        .prediction-name {
            font-size: 24px;
            font-weight: bold;
            color: #007BFF;
            margin-bottom: 20px;
        }

        /* Style for labels */
        .label {
            font-size: 18px;
            font-weight: bold;
        }

        /* Style for patient ID value */
        .patient-id-value {
            font-size: 18px;
        }

        /* Style for CheckBoxList container */
        .checkbox-container {
            text-align: left;
        }

        /* Style for CheckBoxList */
        .checkbox-list {
            list-style-type: none;
            padding-left: 0;
        }

        /* Style for checkbox items */
        .checkbox-item {
            font-size: 16px;
            margin-bottom: 10px;
        }

        /* Style for the Submit button */
        .submit-button {
            font-size: 18px;
            padding: 10px 20px;
            background-color: #007BFF;
            color: #fff;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }

        /* Style for the Back link */
        .back-link {
            font-size: 16px;
            color: #007BFF;
            text-decoration: none;
        }
        .auto-style1 {
            height: 83px;
        }
        .auto-style2 {
            font-size: 16px;
            margin-bottom: 10px;
            height: 50px;
        }
        .auto-style3 {
            font-size: 16px;
            margin-bottom: 10px;
            height: 48px;
        }
    </style>

   
      <div class="centerblock">
        <h3 align="center"><b>Prediction: Acute Kidney Injury</b></h3>
    </div>
    <div class="space"></div>
    <div class="centerblock">
        <div class="label">Patient ID:</div>
        <div class="patient-id-value" id="lblPatientIdValue" runat="server"></div>
    </div>
    <div class="space"></div>
    <div class="centerblock">
        <div class="checkbox-container">
            <ul class="checkbox-list">
                <li class="auto-style3">
                    <asp:CheckBox ID="cbBloodTests" runat="server" Text="Blood tests" />
                </li>
                <li class="auto-style2">
                    <asp:CheckBox ID="cbUrineTests" runat="server" Text="Urine tests" />
                </li>
                <li class="auto-style3">
                    <asp:CheckBox ID="cbImagingTests" runat="server" Text="Imaging tests (ultrasound, CT scan or MRI)" />
                </li>
            </ul>
        </div>
    </div>
    <div class="auto-style1">
        <br />
    </div>
    <div class="centerblock">
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" CssClass="submit-button" />
    </div>
    <div class="space"></div>
    <div class="centerblock">
        <asp:HyperLink ID="hlBackToPrediction" runat="server" NavigateUrl="~/Prediction.aspx" CssClass="back-link">Back to Prediction Page</asp:HyperLink>
    </div>
</asp:Content>
