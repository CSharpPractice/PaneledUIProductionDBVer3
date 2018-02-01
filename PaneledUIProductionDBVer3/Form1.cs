using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PaneledUIProductionDBVer3
{
    public partial class Form1 : Form
    {
        int YAxisAlignment = 0;
        string productionCategory = "";
        string upperCategory = "";
        const int componentBet = 32;
        int secRowYCordiLabel = 0;
        int secRowYCordiTxtBx = 0;

        bool solderingFail = false, tuningFail = false, partialIntegFail = false, tableFail = false, atsOneFail = false, atsTwoFail = false, ICSOneFail = false, ICSTwoFail = false, fullIntegFail = false;
       

        public void Initial_UI_Setting()
        {
            this.lblBurningStart.Visible = false;
            this.lblBurningStop.Visible = false;
            this.lblBurningSerialNo.Visible = false;
            this.lblBurningCheck.Visible = false;
            this.lblBurningSerialNo.Visible = false;
            this.lblTestItemDropDown.Visible = false;
            this.lblCartonBxDCMSerial.Visible = false;
            this.lblDCMSerialNo.Visible = false;
            this.lblGiftBxSerial.Visible = false;
            this.lblDeportDate.Visible = false;
            this.lblSerialMatching.Visible = false;
            this.lblCSserial.Visible = false;
            this.lblPartSerial.Visible = false;
            this.lblErrorCatego.Visible = false;
            this.lblPointOfError.Visible = false;
            this.lblTimeElapsed.Visible = false; 
            this.lblPassFail.Visible = true;
            this.lblRefNameDetails.Visible = false;
            this.lblDataCategory.Visible = false;
            this.lblShipDataCSserial.Visible = false;
            this.lblShipDataModemSerial.Visible = false;
            this.lblShipDataAdapterSerial.Visible = false;
            this.lblShipDataDCMSerial.Visible = false;
            this.lblShipDataShippingDate.Visible = false;
            this.lblcmbModel.Visible = true;
            this.lblDefectDescription.Visible = false;


            this.grpBxRepairFix.Visible = false;
            this.timePickerStart.Visible = false;
            this.timePickerStop.Visible = false;
            this.txtBxBurningSeriealNo.Visible = false;
            this.cmbBurningYesNo.Visible = false;
            this.cmbTestItem.Visible = false;
            this.txtBxDCMSerial.Visible = false;
            this.txtBxGiftBoxDCMSerial.Visible = false;
            this.txtBxCartonBoxDCMSerial.Visible = false;
            this.dateTPicker.Visible = false;
            this.txtBxPartSerial.Visible = false;
            this.txtBxCSSerial.Visible = false;
            this.cmbSerialMatching.Visible = false;
            this.cmbErrorCatego.Visible = false;
            this.cmbPointOfError.Visible = false;
            this.cmbPassFail.Visible = true;
            this.txtBxDetails.Visible = false;
            this.cmbDataCategory.Visible = false;
            this.txtBxShipDataCSserial.Visible = false;
            this.txtBxShipDataModemSerial.Visible = false;
            this.txtBxShipDataAdapterSerial.Visible = false;
            this.txtBxShipDataDCMSerial.Visible = false;
            this.dateTimeShippingDate.Visible = false;
            this.cmbProductionProcSelect.Visible = true;
            
            this.txtBxDefectDescript.Visible = false;

            this.cmbPassFail.Text = "";
            this.cmbPointOfError.Text = "";
            this.txtBxBurningSeriealNo.Text = "";
            this.cmbBurningYesNo.Text = "";
            this.cmbTestItem.Text = "";
            this.txtBxDetails.Text = "";
            this.cmbTestItem.Text = "";
            this.txtBxDCMSerial.Text = "";
            this.txtBxGiftBoxDCMSerial.Text = "";
            this.txtBxCartonBoxDCMSerial.Text = "";
            this.cmbSerialMatching.Text = "";
            this.txtBxCSSerial.Text = "";
            this.txtBxPartSerial.Text = "";
            this.cmbDataCategory.Text = "";
            this.txtBxShipDataCSserial.Text = "";
            this.txtBxShipDataModemSerial.Text = "";
            this.txtBxShipDataAdapterSerial.Text = "";
            this.txtBxShipDataDCMSerial.Text = "";


            
            

        }
        public void packaging_UI(string whetherPack)
        {
            this.lblRefNameDetails.Visible = false;
            this.txtBxDetails.Visible = false;

            this.lblPassFail.Visible = false;
            this.cmbPassFail.Visible = false;

            this.lblDCMSerialNo.Top = lblcmbModel.Location.Y;
            this.lblGiftBxSerial.Top = lblcmbModel.Location.Y;
            this.lblCartonBxDCMSerial.Top = lblcmbModel.Location.Y;

            this.txtBxDCMSerial.Top = this.cmbPassFail.Location.Y;
            this.txtBxCartonBoxDCMSerial.Top = this.cmbPassFail.Location.Y;
            this.txtBxGiftBoxDCMSerial.Top = this.cmbPassFail.Location.Y;

            this.lblDCMSerialNo.Visible = true;
            this.txtBxDCMSerial.Visible = true;

            if(whetherPack != "출하")
            { 
                this.txtBxCartonBoxDCMSerial.Visible = true;
                this.txtBxGiftBoxDCMSerial.Visible = true;
                this.lblGiftBxSerial.Visible = true;
                this.lblCartonBxDCMSerial.Visible = true;
            }
            this.lblRefNameDetails.Visible = true;
            this.txtBxDetails.Visible = true;
        }
        public void ATS_UI(int no)
        {
            this.lblTestItemDropDown.Top = this.lblPointOfError.Location.Y;
            this.lblTestItemDropDown.Left = this.lblPointOfError.Location.X;
            this.cmbTestItem.Top = this.cmbPointOfError.Location.Y;
            this.cmbTestItem.Left = this.cmbPointOfError.Location.X;
            this.lblTestItemDropDown.Visible = true;
            this.cmbTestItem.Visible = true;
            this.lblRefNameDetails.Visible = true;
            this.txtBxDetails.Visible = true;
        }

        public void burning_UI()
        {
            this.lblBurningSerialNo.Visible = true;
            this.lblBurningStart.Visible = true;
            this.lblBurningStop.Visible = true;
            this.lblBurningCheck.Visible = true;
            this.lblTimeElapsed.Visible = true;
            this.txtBxBurningSeriealNo.Visible = true;
            this.cmbBurningYesNo.Visible = true;
            this.timePickerStart.Visible = true;
            this.timePickerStop.Visible = true;
            this.lblPassFail.Visible = false;
            this.cmbPassFail.Visible = false;


            this.lblBurningStop.Top = secRowYCordiLabel;
            this.timePickerStop.Top = secRowYCordiTxtBx;
            this.lblBurningCheck.Top = secRowYCordiLabel;
            this.cmbBurningYesNo.Top = secRowYCordiTxtBx;

            lblBurningStart.Top = lblcmbModel.Location.Y;
            timePickerStart.Top = this.cmbProductionProcSelect.Location.Y;
            this.lblTimeElapsed.Top = lblcmbModel.Location.Y; 
            this.lblBurningSerialNo.Top = lblcmbModel.Location.Y; 
            this.txtBxBurningSeriealNo.Top = this.cmbProductionProcSelect.Location.Y; 
            //  timePickerStop.Top = lblcmbModel.Location.Y;


        }

        public void table_UI()
        {
            this.lblPointOfError.Visible = true;
            this.cmbPointOfError.Visible = true;
            this.cmbPointOfError.Items.Clear();
            this.cmbPointOfError.Items.AddRange(new string[] { "DL", "UL" });
            this.lblRefNameDetails.Visible = true;
            this.txtBxDetails.Visible = true;
        }


        public void Integration_UI(string fullOPartial)
        {
            this.lblPointOfError.Visible = true;
            this.cmbPointOfError.Visible = true;
            this.cmbPointOfError.Items.Clear();
            this.cmbPointOfError.Items.AddRange(new string[] {"Case","Etc"});
            this.lblRefNameDetails.Visible = true;
            this.txtBxDetails.Visible = true;
        }

        public void Tuning_UI()
        {
            this.lblPointOfError.Visible = true;
            this.cmbPointOfError.Visible = true;
            this.lblErrorCatego.Visible = true;
            this.cmbErrorCatego.Visible = true;
            this.lblRefNameDetails.Visible = true;
            this.txtBxDetails.Visible = true;
            this.cmbPointOfError.Items.AddRange(new string[] { "DL", "UL" });
            //this.cmbPassFail.Visible = true; ;
            // this.lblPassFail.Visible = true;
        }

        /*public void fixRepair_UI() {
            this.lblRefNameDetails.Visible = true;
            this.txtBxDetails.Visible = true;

        }*/

        

        public void solderingFail_UI()
        {
            this.lblRefNameDetails.Visible = true;
            this.txtBxDetails.Visible = true;
        }

        public void serialMatching_UI()
        {
            this.lblSerialMatching.Visible = true;
            this.lblCSserial.Visible = true;
            this.lblPartSerial.Visible = true;

            this.cmbSerialMatching.Visible = true;
            this.txtBxCSSerial.Visible = true;
            this.txtBxPartSerial.Visible = true;

            this.lblcmbModel.Visible = false;
            this.cmbProductionProcSelect.Visible = false;
            this.lblPassFail.Visible = false;
            this.cmbPassFail.Visible = false;

            this.lblSerialMatching.Top = this.lblcmbModel.Location.Y;
            this.lblCSserial.Top = this.lblcmbModel.Location.Y;
            this.lblPartSerial.Top = this.lblcmbModel.Location.Y;

            this.cmbSerialMatching.Top = this.cmbProductionProcSelect.Location.Y;
            this.txtBxCSSerial.Top = this.cmbProductionProcSelect.Location.Y;
            this.txtBxPartSerial.Top = this.cmbProductionProcSelect.Location.Y;

        }
      
        public void data_UI()
        {
            this.lblcmbModel.Visible = false;
            this.cmbProductionProcSelect.Visible = false;
            this.lblPassFail.Visible = false;
            this.cmbPassFail.Visible = false;

            this.lblDataCategory.Visible = true;
            this.lblShipDataCSserial.Visible = true;
            this.lblShipDataModemSerial.Visible = true;
            this.lblShipDataAdapterSerial.Visible = true;
            this.lblShipDataDCMSerial.Visible = true;
            this.lblShipDataShippingDate.Visible = true;

            this.cmbDataCategory.Visible = true;
            this.txtBxShipDataCSserial.Visible = true;
            this.txtBxShipDataModemSerial.Visible = true;
            this.txtBxShipDataAdapterSerial.Visible = true;
            this.txtBxShipDataDCMSerial.Visible = true;
            this.dateTimeShippingDate.Visible = true;

            this.lblDataCategory.Top = this.lblPassFail.Location.Y;
            this.lblShipDataCSserial.Top = this.lblPassFail.Location.Y;
            this.lblShipDataModemSerial.Top = this.lblPassFail.Location.Y;
            

            this.cmbDataCategory.Top = this.cmbPassFail.Location.Y;
            this.txtBxShipDataCSserial.Top = this.cmbPassFail.Location.Y;
            this.txtBxShipDataModemSerial.Top = this.cmbPassFail.Location.Y;

            this.lblShipDataAdapterSerial.Top = secRowYCordiLabel;
            this.lblShipDataDCMSerial.Top = secRowYCordiLabel;
            this.lblShipDataShippingDate.Top = secRowYCordiLabel;

            this.txtBxShipDataAdapterSerial.Top = secRowYCordiTxtBx;
            this.txtBxShipDataDCMSerial.Top = secRowYCordiTxtBx;
            this.dateTimeShippingDate.Top = secRowYCordiTxtBx;

        }

        public void repairFix_UI() {
            this.grpBxRepairFix.Visible = true;

            this.grpBxRepairFix.Top = cmbPassFail.Location.Y;


            this.lblDefectDescription.Visible = true;
            this.txtBxDefectDescript.Visible = true;

            this.lblDefectDescription.Top = this.lblPassFail.Location.Y;
            this.txtBxDefectDescript.Top = this.cmbPointOfError.Location.Y;

            if (solderingFail)
            {
                this.lblSolderingFailLabel.Visible = true;
            }
            if (partialIntegFail) {
                this.lblPartialIntegFailLabel.Visible = true;
            }
            if (tuningFail) {
                this.lblTuningFailLabel.Visible = true;
            }
            if (tableFail) {
                this.lblTableFailLabel.Visible = true;
            }
            if (atsOneFail) {
                this.lblATS1FailLabel.Visible = true;
            }

            if(atsTwoFail)
            {
                this.lblATS2FailLabel.Visible = true;
            }
            if (ICSOneFail)
            {
                this.lblICS1FailLabel.Visible = true;
            }
            if (ICSTwoFail)
            {
                this.lblICS2FailLabel.Visible = true;
            }
            if (fullIntegFail)
            {
                this.lblFullIntegFailLabel.Visible = true;
            }



        }

        public Form1()
        {
            InitializeComponent();
            Initial_UI_Setting();
            YAxisAlignment = this.cmbPointOfError.Location.Y;
            secRowYCordiLabel = this.lblBurningStart.Location.Y;
            secRowYCordiTxtBx = this.txtBxBurningSeriealNo.Location.Y;
            productionCategory = "수삽";
        }

        private void cmbProductionProcSelect_SelectedValueChanged(object sender, EventArgs e)
        {


            if (this.cmbProductionProcSelect.Text == "Tuning")
            {
                Initial_UI_Setting();
                productionCategory = "Tuning";
            }
            else if (this.cmbProductionProcSelect.Text == "반조립")
            {
                Initial_UI_Setting();
                productionCategory = "반조립";
            }
            else if (this.cmbProductionProcSelect.Text == "Table")
            {
                Initial_UI_Setting();
                productionCategory = "Table";
            }
            else if (this.cmbProductionProcSelect.Text == "Burning")
            {
                productionCategory = "Burning";
                Initial_UI_Setting();
                burning_UI();
            }
            else if (this.cmbProductionProcSelect.Text == "ATS1")
            {
                Initial_UI_Setting();
                productionCategory = "ATS1";


            }
            else if (this.cmbProductionProcSelect.Text == "ATS2")
            {
                Initial_UI_Setting();
                productionCategory = "ATS2";

            }
            else if (this.cmbProductionProcSelect.Text == "ICS1")
            {
                Initial_UI_Setting();
                productionCategory = "ICS1";
            }
            else if (this.cmbProductionProcSelect.Text == "ICS2")
            {
                Initial_UI_Setting();
                productionCategory = "ICS2";
            }
            else if (this.cmbProductionProcSelect.Text == "완조립")
            {
                Initial_UI_Setting();
                productionCategory = "완조립";
            }

            else if (this.cmbProductionProcSelect.Text == "포장")
            {
                Initial_UI_Setting();
                productionCategory = "포장";
                packaging_UI("포장");
            }
            else if (this.cmbProductionProcSelect.Text == "출하")
            {
                Initial_UI_Setting();
                productionCategory = "출하";
                packaging_UI("출하");
            }
            else if (this.cmbProductionProcSelect.Text == "수리")
            {
                Initial_UI_Setting();
                productionCategory = "수리";
                repairFix_UI();
            }
            else
            {
                Initial_UI_Setting();
            }
        }

        private void cmbPassFail_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmbPassFail.Text == "Fail" && this.cmbProductionProcSelect.Text == "수삽")
            {
                solderingFail = true;
                Initial_UI_Setting();
                solderingFail_UI();
            }
            else if (this.cmbPassFail.Text == "Fail" && productionCategory == "Tuning")
            {
                tuningFail = true;
                Initial_UI_Setting();
                Tuning_UI();
            }
            else if (this.cmbPassFail.Text == "Pass" && productionCategory == "Tuning")
            {
                Initial_UI_Setting();
            }
            else if (this.cmbPassFail.Text == "Fail" && productionCategory == "반조립")
            {
                partialIntegFail = true;
                Initial_UI_Setting();
                Integration_UI("반조립");
            }
            else if (this.cmbPassFail.Text == "Fail" && productionCategory == "Table")
            {
                tableFail = true;
                Initial_UI_Setting();
                table_UI();
            }
            else if (this.cmbPassFail.Text == "Fail" && productionCategory == "ATS1")
            {
                atsOneFail = true;
                Initial_UI_Setting();
                ATS_UI(1);
            }
            else if (this.cmbPassFail.Text == "Fail" && productionCategory == "ATS2")
            {
                atsTwoFail = true;
                Initial_UI_Setting();
                ATS_UI(2);
            }
            else if (this.cmbPassFail.Text == "Fail" && productionCategory == "ICS1")
            {
                ICSOneFail = true;
                Initial_UI_Setting();
                ATS_UI(3);
            }
            else if (this.cmbPassFail.Text == "Fail" && productionCategory == "ICS2")
            {
                ICSTwoFail = true;
                Initial_UI_Setting();
                ATS_UI(4);
            }
            else if (this.cmbPassFail.Text == "Fail" && productionCategory == "완조립")
            {
                fullIntegFail = true;
                Initial_UI_Setting();
                Integration_UI("완조립");
            }
            else
            {
                Initial_UI_Setting();
            }
        }

        private void cmbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmbCategory.Text == "공정")
            {
                Initial_UI_Setting();
                upperCategory = "공정";
            }
            else if (this.cmbCategory.Text == "Serial Matching")
            {
                Initial_UI_Setting();
                upperCategory = "Serial Matching";
                serialMatching_UI();
            }
            else if (this.cmbCategory.Text == "Data")
            {
                Initial_UI_Setting();
                upperCategory = "Data";
                data_UI();
            }
            else
            {
                Initial_UI_Setting();
            }

        }
    }

    
}
