namespace PaneledUIProductionDBVer3
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpBxRepairFix = new System.Windows.Forms.GroupBox();
            this.lblTableFailLabel = new System.Windows.Forms.Label();
            this.lblFullIntegFailLabel = new System.Windows.Forms.Label();
            this.lblICS2FailLabel = new System.Windows.Forms.Label();
            this.lblICS1FailLabel = new System.Windows.Forms.Label();
            this.lblATS2FailLabel = new System.Windows.Forms.Label();
            this.lblATS1FailLabel = new System.Windows.Forms.Label();
            this.lblPartialIntegFailLabel = new System.Windows.Forms.Label();
            this.lblTuningFailLabel = new System.Windows.Forms.Label();
            this.lblSolderingFailLabel = new System.Windows.Forms.Label();
            this.dateTimeShippingDate = new System.Windows.Forms.DateTimePicker();
            this.lblShipDataShippingDate = new System.Windows.Forms.Label();
            this.txtBxShipDataDCMSerial = new System.Windows.Forms.TextBox();
            this.lblShipDataDCMSerial = new System.Windows.Forms.Label();
            this.txtBxShipDataAdapterSerial = new System.Windows.Forms.TextBox();
            this.lblShipDataAdapterSerial = new System.Windows.Forms.Label();
            this.txtBxShipDataModemSerial = new System.Windows.Forms.TextBox();
            this.lblShipDataModemSerial = new System.Windows.Forms.Label();
            this.txtBxShipDataCSserial = new System.Windows.Forms.TextBox();
            this.lblShipDataCSserial = new System.Windows.Forms.Label();
            this.cmbDataCategory = new System.Windows.Forms.ComboBox();
            this.lblDataCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.cmbBurningYesNo = new System.Windows.Forms.ComboBox();
            this.lblBurningCheck = new System.Windows.Forms.Label();
            this.dateTPicker = new System.Windows.Forms.DateTimePicker();
            this.lblDeportDate = new System.Windows.Forms.Label();
            this.txtBxPartSerial = new System.Windows.Forms.TextBox();
            this.lblPartSerial = new System.Windows.Forms.Label();
            this.txtBxCSSerial = new System.Windows.Forms.TextBox();
            this.lblCSserial = new System.Windows.Forms.Label();
            this.cmbSerialMatching = new System.Windows.Forms.ComboBox();
            this.lblSerialMatching = new System.Windows.Forms.Label();
            this.txtBxCartonBoxDCMSerial = new System.Windows.Forms.TextBox();
            this.lblCartonBxDCMSerial = new System.Windows.Forms.Label();
            this.txtBxGiftBoxDCMSerial = new System.Windows.Forms.TextBox();
            this.lblGiftBxSerial = new System.Windows.Forms.Label();
            this.txtBxDCMSerial = new System.Windows.Forms.TextBox();
            this.lblDCMSerialNo = new System.Windows.Forms.Label();
            this.timePickerStop = new System.Windows.Forms.DateTimePicker();
            this.lblBurningStop = new System.Windows.Forms.Label();
            this.cmbTestItem = new System.Windows.Forms.ComboBox();
            this.lblTestItemDropDown = new System.Windows.Forms.Label();
            this.txtBxBurningSeriealNo = new System.Windows.Forms.TextBox();
            this.lblBurningSerialNo = new System.Windows.Forms.Label();
            this.timePickerStart = new System.Windows.Forms.DateTimePicker();
            this.lblBurningStart = new System.Windows.Forms.Label();
            this.cmbErrorCatego = new System.Windows.Forms.ComboBox();
            this.lblErrorCatego = new System.Windows.Forms.Label();
            this.cmbPointOfError = new System.Windows.Forms.ComboBox();
            this.lblPointOfError = new System.Windows.Forms.Label();
            this.txtBxDetails = new System.Windows.Forms.TextBox();
            this.lblRefNameDetails = new System.Windows.Forms.Label();
            this.cmbPassFail = new System.Windows.Forms.ComboBox();
            this.lblPassFail = new System.Windows.Forms.Label();
            this.cmbProductionProcSelect = new System.Windows.Forms.ComboBox();
            this.lblcmbModel = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.btnWrite = new System.Windows.Forms.Button();
            this.lblDefectDescription = new System.Windows.Forms.Label();
            this.txtBxDefectDescript = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.grpBxRepairFix.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.txtBxDefectDescript);
            this.panel1.Controls.Add(this.lblDefectDescription);
            this.panel1.Controls.Add(this.grpBxRepairFix);
            this.panel1.Controls.Add(this.dateTimeShippingDate);
            this.panel1.Controls.Add(this.lblShipDataShippingDate);
            this.panel1.Controls.Add(this.txtBxShipDataDCMSerial);
            this.panel1.Controls.Add(this.lblShipDataDCMSerial);
            this.panel1.Controls.Add(this.txtBxShipDataAdapterSerial);
            this.panel1.Controls.Add(this.lblShipDataAdapterSerial);
            this.panel1.Controls.Add(this.txtBxShipDataModemSerial);
            this.panel1.Controls.Add(this.lblShipDataModemSerial);
            this.panel1.Controls.Add(this.txtBxShipDataCSserial);
            this.panel1.Controls.Add(this.lblShipDataCSserial);
            this.panel1.Controls.Add(this.cmbDataCategory);
            this.panel1.Controls.Add(this.lblDataCategory);
            this.panel1.Controls.Add(this.cmbCategory);
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.lblTimeElapsed);
            this.panel1.Controls.Add(this.cmbBurningYesNo);
            this.panel1.Controls.Add(this.lblBurningCheck);
            this.panel1.Controls.Add(this.dateTPicker);
            this.panel1.Controls.Add(this.lblDeportDate);
            this.panel1.Controls.Add(this.txtBxPartSerial);
            this.panel1.Controls.Add(this.lblPartSerial);
            this.panel1.Controls.Add(this.txtBxCSSerial);
            this.panel1.Controls.Add(this.lblCSserial);
            this.panel1.Controls.Add(this.cmbSerialMatching);
            this.panel1.Controls.Add(this.lblSerialMatching);
            this.panel1.Controls.Add(this.txtBxCartonBoxDCMSerial);
            this.panel1.Controls.Add(this.lblCartonBxDCMSerial);
            this.panel1.Controls.Add(this.txtBxGiftBoxDCMSerial);
            this.panel1.Controls.Add(this.lblGiftBxSerial);
            this.panel1.Controls.Add(this.txtBxDCMSerial);
            this.panel1.Controls.Add(this.lblDCMSerialNo);
            this.panel1.Controls.Add(this.timePickerStop);
            this.panel1.Controls.Add(this.lblBurningStop);
            this.panel1.Controls.Add(this.cmbTestItem);
            this.panel1.Controls.Add(this.lblTestItemDropDown);
            this.panel1.Controls.Add(this.txtBxBurningSeriealNo);
            this.panel1.Controls.Add(this.lblBurningSerialNo);
            this.panel1.Controls.Add(this.timePickerStart);
            this.panel1.Controls.Add(this.lblBurningStart);
            this.panel1.Controls.Add(this.cmbErrorCatego);
            this.panel1.Controls.Add(this.lblErrorCatego);
            this.panel1.Controls.Add(this.cmbPointOfError);
            this.panel1.Controls.Add(this.lblPointOfError);
            this.panel1.Controls.Add(this.txtBxDetails);
            this.panel1.Controls.Add(this.lblRefNameDetails);
            this.panel1.Controls.Add(this.cmbPassFail);
            this.panel1.Controls.Add(this.lblPassFail);
            this.panel1.Controls.Add(this.cmbProductionProcSelect);
            this.panel1.Controls.Add(this.lblcmbModel);
            this.panel1.Controls.Add(this.cmbModel);
            this.panel1.Controls.Add(this.lblModel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1685, 365);
            this.panel1.TabIndex = 0;
            // 
            // grpBxRepairFix
            // 
            this.grpBxRepairFix.Controls.Add(this.lblTableFailLabel);
            this.grpBxRepairFix.Controls.Add(this.lblFullIntegFailLabel);
            this.grpBxRepairFix.Controls.Add(this.lblICS2FailLabel);
            this.grpBxRepairFix.Controls.Add(this.lblICS1FailLabel);
            this.grpBxRepairFix.Controls.Add(this.lblATS2FailLabel);
            this.grpBxRepairFix.Controls.Add(this.lblATS1FailLabel);
            this.grpBxRepairFix.Controls.Add(this.lblPartialIntegFailLabel);
            this.grpBxRepairFix.Controls.Add(this.lblTuningFailLabel);
            this.grpBxRepairFix.Controls.Add(this.lblSolderingFailLabel);
            this.grpBxRepairFix.Location = new System.Drawing.Point(628, 333);
            this.grpBxRepairFix.Name = "grpBxRepairFix";
            this.grpBxRepairFix.Size = new System.Drawing.Size(200, 146);
            this.grpBxRepairFix.TabIndex = 52;
            this.grpBxRepairFix.TabStop = false;
            this.grpBxRepairFix.Text = "수리요구 내역";
            this.grpBxRepairFix.Visible = false;
            // 
            // lblTableFailLabel
            // 
            this.lblTableFailLabel.AutoSize = true;
            this.lblTableFailLabel.Location = new System.Drawing.Point(110, 100);
            this.lblTableFailLabel.Name = "lblTableFailLabel";
            this.lblTableFailLabel.Size = new System.Drawing.Size(69, 15);
            this.lblTableFailLabel.TabIndex = 8;
            this.lblTableFailLabel.Text = "Table Fail";
            this.lblTableFailLabel.Visible = false;
            // 
            // lblFullIntegFailLabel
            // 
            this.lblFullIntegFailLabel.AutoSize = true;
            this.lblFullIntegFailLabel.Location = new System.Drawing.Point(110, 71);
            this.lblFullIntegFailLabel.Name = "lblFullIntegFailLabel";
            this.lblFullIntegFailLabel.Size = new System.Drawing.Size(79, 15);
            this.lblFullIntegFailLabel.TabIndex = 7;
            this.lblFullIntegFailLabel.Text = "완조립 Fail";
            this.lblFullIntegFailLabel.Visible = false;
            // 
            // lblICS2FailLabel
            // 
            this.lblICS2FailLabel.AutoSize = true;
            this.lblICS2FailLabel.Location = new System.Drawing.Point(110, 46);
            this.lblICS2FailLabel.Name = "lblICS2FailLabel";
            this.lblICS2FailLabel.Size = new System.Drawing.Size(65, 15);
            this.lblICS2FailLabel.TabIndex = 6;
            this.lblICS2FailLabel.Text = "ICS2 Fail";
            this.lblICS2FailLabel.Visible = false;
            // 
            // lblICS1FailLabel
            // 
            this.lblICS1FailLabel.AutoSize = true;
            this.lblICS1FailLabel.Location = new System.Drawing.Point(110, 21);
            this.lblICS1FailLabel.Name = "lblICS1FailLabel";
            this.lblICS1FailLabel.Size = new System.Drawing.Size(65, 15);
            this.lblICS1FailLabel.TabIndex = 5;
            this.lblICS1FailLabel.Text = "ICS1 Fail";
            this.lblICS1FailLabel.Visible = false;
            // 
            // lblATS2FailLabel
            // 
            this.lblATS2FailLabel.AutoSize = true;
            this.lblATS2FailLabel.Location = new System.Drawing.Point(17, 124);
            this.lblATS2FailLabel.Name = "lblATS2FailLabel";
            this.lblATS2FailLabel.Size = new System.Drawing.Size(69, 15);
            this.lblATS2FailLabel.TabIndex = 4;
            this.lblATS2FailLabel.Text = "ATS2 Fail";
            this.lblATS2FailLabel.Visible = false;
            // 
            // lblATS1FailLabel
            // 
            this.lblATS1FailLabel.AutoSize = true;
            this.lblATS1FailLabel.Location = new System.Drawing.Point(17, 99);
            this.lblATS1FailLabel.Name = "lblATS1FailLabel";
            this.lblATS1FailLabel.Size = new System.Drawing.Size(69, 15);
            this.lblATS1FailLabel.TabIndex = 3;
            this.lblATS1FailLabel.Text = "ATS1 Fail";
            this.lblATS1FailLabel.Visible = false;
            // 
            // lblPartialIntegFailLabel
            // 
            this.lblPartialIntegFailLabel.AutoSize = true;
            this.lblPartialIntegFailLabel.Location = new System.Drawing.Point(17, 71);
            this.lblPartialIntegFailLabel.Name = "lblPartialIntegFailLabel";
            this.lblPartialIntegFailLabel.Size = new System.Drawing.Size(79, 15);
            this.lblPartialIntegFailLabel.TabIndex = 2;
            this.lblPartialIntegFailLabel.Text = "반조립 Fail";
            this.lblPartialIntegFailLabel.Visible = false;
            // 
            // lblTuningFailLabel
            // 
            this.lblTuningFailLabel.AutoSize = true;
            this.lblTuningFailLabel.Location = new System.Drawing.Point(17, 46);
            this.lblTuningFailLabel.Name = "lblTuningFailLabel";
            this.lblTuningFailLabel.Size = new System.Drawing.Size(59, 15);
            this.lblTuningFailLabel.TabIndex = 1;
            this.lblTuningFailLabel.Text = "튜닝Fail";
            this.lblTuningFailLabel.Visible = false;
            // 
            // lblSolderingFailLabel
            // 
            this.lblSolderingFailLabel.AutoSize = true;
            this.lblSolderingFailLabel.Location = new System.Drawing.Point(16, 21);
            this.lblSolderingFailLabel.Name = "lblSolderingFailLabel";
            this.lblSolderingFailLabel.Size = new System.Drawing.Size(64, 15);
            this.lblSolderingFailLabel.TabIndex = 0;
            this.lblSolderingFailLabel.Text = "수삽 Fail";
            this.lblSolderingFailLabel.Visible = false;
            // 
            // dateTimeShippingDate
            // 
            this.dateTimeShippingDate.Location = new System.Drawing.Point(1250, 299);
            this.dateTimeShippingDate.Name = "dateTimeShippingDate";
            this.dateTimeShippingDate.Size = new System.Drawing.Size(200, 25);
            this.dateTimeShippingDate.TabIndex = 51;
            // 
            // lblShipDataShippingDate
            // 
            this.lblShipDataShippingDate.AutoSize = true;
            this.lblShipDataShippingDate.Location = new System.Drawing.Point(1167, 305);
            this.lblShipDataShippingDate.Name = "lblShipDataShippingDate";
            this.lblShipDataShippingDate.Size = new System.Drawing.Size(77, 15);
            this.lblShipDataShippingDate.TabIndex = 50;
            this.lblShipDataShippingDate.Text = "출하날짜 :";
            // 
            // txtBxShipDataDCMSerial
            // 
            this.txtBxShipDataDCMSerial.Location = new System.Drawing.Point(1036, 299);
            this.txtBxShipDataDCMSerial.Name = "txtBxShipDataDCMSerial";
            this.txtBxShipDataDCMSerial.Size = new System.Drawing.Size(123, 25);
            this.txtBxShipDataDCMSerial.TabIndex = 49;
            // 
            // lblShipDataDCMSerial
            // 
            this.lblShipDataDCMSerial.AutoSize = true;
            this.lblShipDataDCMSerial.Location = new System.Drawing.Point(912, 306);
            this.lblShipDataDCMSerial.Name = "lblShipDataDCMSerial";
            this.lblShipDataDCMSerial.Size = new System.Drawing.Size(118, 15);
            this.lblShipDataDCMSerial.TabIndex = 48;
            this.lblShipDataDCMSerial.Text = "DCM Serial No. :";
            // 
            // txtBxShipDataAdapterSerial
            // 
            this.txtBxShipDataAdapterSerial.Location = new System.Drawing.Point(755, 302);
            this.txtBxShipDataAdapterSerial.Name = "txtBxShipDataAdapterSerial";
            this.txtBxShipDataAdapterSerial.Size = new System.Drawing.Size(123, 25);
            this.txtBxShipDataAdapterSerial.TabIndex = 47;
            // 
            // lblShipDataAdapterSerial
            // 
            this.lblShipDataAdapterSerial.AutoSize = true;
            this.lblShipDataAdapterSerial.Location = new System.Drawing.Point(608, 306);
            this.lblShipDataAdapterSerial.Name = "lblShipDataAdapterSerial";
            this.lblShipDataAdapterSerial.Size = new System.Drawing.Size(135, 15);
            this.lblShipDataAdapterSerial.TabIndex = 46;
            this.lblShipDataAdapterSerial.Text = "Adapter Serial No. :";
            // 
            // txtBxShipDataModemSerial
            // 
            this.txtBxShipDataModemSerial.Location = new System.Drawing.Point(1036, 271);
            this.txtBxShipDataModemSerial.Name = "txtBxShipDataModemSerial";
            this.txtBxShipDataModemSerial.Size = new System.Drawing.Size(123, 25);
            this.txtBxShipDataModemSerial.TabIndex = 45;
            // 
            // lblShipDataModemSerial
            // 
            this.lblShipDataModemSerial.AutoSize = true;
            this.lblShipDataModemSerial.Location = new System.Drawing.Point(896, 276);
            this.lblShipDataModemSerial.Name = "lblShipDataModemSerial";
            this.lblShipDataModemSerial.Size = new System.Drawing.Size(134, 15);
            this.lblShipDataModemSerial.TabIndex = 44;
            this.lblShipDataModemSerial.Text = "Modem Serial No. :";
            // 
            // txtBxShipDataCSserial
            // 
            this.txtBxShipDataCSserial.Location = new System.Drawing.Point(755, 271);
            this.txtBxShipDataCSserial.Name = "txtBxShipDataCSserial";
            this.txtBxShipDataCSserial.Size = new System.Drawing.Size(123, 25);
            this.txtBxShipDataCSserial.TabIndex = 43;
            // 
            // lblShipDataCSserial
            // 
            this.lblShipDataCSserial.AutoSize = true;
            this.lblShipDataCSserial.Location = new System.Drawing.Point(631, 276);
            this.lblShipDataCSserial.Name = "lblShipDataCSserial";
            this.lblShipDataCSserial.Size = new System.Drawing.Size(106, 15);
            this.lblShipDataCSserial.TabIndex = 42;
            this.lblShipDataCSserial.Text = "CS Serial No. :";
            // 
            // cmbDataCategory
            // 
            this.cmbDataCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataCategory.FormattingEnabled = true;
            this.cmbDataCategory.Items.AddRange(new object[] {
            "공정 Data",
            "출하 Data"});
            this.cmbDataCategory.Location = new System.Drawing.Point(490, 273);
            this.cmbDataCategory.Name = "cmbDataCategory";
            this.cmbDataCategory.Size = new System.Drawing.Size(121, 23);
            this.cmbDataCategory.TabIndex = 41;
            // 
            // lblDataCategory
            // 
            this.lblDataCategory.AutoSize = true;
            this.lblDataCategory.Location = new System.Drawing.Point(437, 276);
            this.lblDataCategory.Name = "lblDataCategory";
            this.lblDataCategory.Size = new System.Drawing.Size(47, 15);
            this.lblDataCategory.TabIndex = 40;
            this.lblDataCategory.Text = "Data :";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "공정",
            "Serial Matching",
            "Data"});
            this.cmbCategory.Location = new System.Drawing.Point(265, 21);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 23);
            this.cmbCategory.TabIndex = 39;
            this.cmbCategory.SelectedValueChanged += new System.EventHandler(this.cmbCategory_SelectedValueChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(220, 24);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 15);
            this.lblCategory.TabIndex = 38;
            this.lblCategory.Text = "분류 : ";
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.Location = new System.Drawing.Point(900, 52);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(100, 23);
            this.lblTimeElapsed.TabIndex = 37;
            this.lblTimeElapsed.Text = "Time elapsed";
            // 
            // cmbBurningYesNo
            // 
            this.cmbBurningYesNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBurningYesNo.FormattingEnabled = true;
            this.cmbBurningYesNo.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbBurningYesNo.Location = new System.Drawing.Point(1130, 85);
            this.cmbBurningYesNo.Name = "cmbBurningYesNo";
            this.cmbBurningYesNo.Size = new System.Drawing.Size(121, 23);
            this.cmbBurningYesNo.TabIndex = 36;
            // 
            // lblBurningCheck
            // 
            this.lblBurningCheck.AutoSize = true;
            this.lblBurningCheck.Location = new System.Drawing.Point(1022, 88);
            this.lblBurningCheck.Name = "lblBurningCheck";
            this.lblBurningCheck.Size = new System.Drawing.Size(107, 15);
            this.lblBurningCheck.TabIndex = 35;
            this.lblBurningCheck.Text = "Burning 유/무 :";
            // 
            // dateTPicker
            // 
            this.dateTPicker.Location = new System.Drawing.Point(678, 205);
            this.dateTPicker.Name = "dateTPicker";
            this.dateTPicker.Size = new System.Drawing.Size(200, 25);
            this.dateTPicker.TabIndex = 34;
            // 
            // lblDeportDate
            // 
            this.lblDeportDate.AutoSize = true;
            this.lblDeportDate.Location = new System.Drawing.Point(551, 212);
            this.lblDeportDate.Name = "lblDeportDate";
            this.lblDeportDate.Size = new System.Drawing.Size(121, 15);
            this.lblDeportDate.TabIndex = 33;
            this.lblDeportDate.Text = "Production date :";
            // 
            // txtBxPartSerial
            // 
            this.txtBxPartSerial.Location = new System.Drawing.Point(1078, 236);
            this.txtBxPartSerial.Name = "txtBxPartSerial";
            this.txtBxPartSerial.Size = new System.Drawing.Size(123, 25);
            this.txtBxPartSerial.TabIndex = 32;
            // 
            // lblPartSerial
            // 
            this.lblPartSerial.AutoSize = true;
            this.lblPartSerial.Location = new System.Drawing.Point(966, 241);
            this.lblPartSerial.Name = "lblPartSerial";
            this.lblPartSerial.Size = new System.Drawing.Size(112, 15);
            this.lblPartSerial.TabIndex = 31;
            this.lblPartSerial.Text = "Part Serial No. :";
            // 
            // txtBxCSSerial
            // 
            this.txtBxCSSerial.Location = new System.Drawing.Point(825, 236);
            this.txtBxCSSerial.Name = "txtBxCSSerial";
            this.txtBxCSSerial.Size = new System.Drawing.Size(123, 25);
            this.txtBxCSSerial.TabIndex = 30;
            // 
            // lblCSserial
            // 
            this.lblCSserial.AutoSize = true;
            this.lblCSserial.Location = new System.Drawing.Point(701, 241);
            this.lblCSserial.Name = "lblCSserial";
            this.lblCSserial.Size = new System.Drawing.Size(106, 15);
            this.lblCSserial.TabIndex = 29;
            this.lblCSserial.Text = "CS Serial No. :";
            // 
            // cmbSerialMatching
            // 
            this.cmbSerialMatching.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSerialMatching.FormattingEnabled = true;
            this.cmbSerialMatching.Items.AddRange(new object[] {
            "Modem Matching",
            "Adapter Matching",
            "DCM Matching"});
            this.cmbSerialMatching.Location = new System.Drawing.Point(560, 236);
            this.cmbSerialMatching.Name = "cmbSerialMatching";
            this.cmbSerialMatching.Size = new System.Drawing.Size(121, 23);
            this.cmbSerialMatching.TabIndex = 28;
            // 
            // lblSerialMatching
            // 
            this.lblSerialMatching.AutoSize = true;
            this.lblSerialMatching.Location = new System.Drawing.Point(437, 239);
            this.lblSerialMatching.Name = "lblSerialMatching";
            this.lblSerialMatching.Size = new System.Drawing.Size(117, 15);
            this.lblSerialMatching.TabIndex = 27;
            this.lblSerialMatching.Text = "Serial Matching :";
            // 
            // txtBxCartonBoxDCMSerial
            // 
            this.txtBxCartonBoxDCMSerial.Location = new System.Drawing.Point(1490, 170);
            this.txtBxCartonBoxDCMSerial.Name = "txtBxCartonBoxDCMSerial";
            this.txtBxCartonBoxDCMSerial.Size = new System.Drawing.Size(123, 25);
            this.txtBxCartonBoxDCMSerial.TabIndex = 26;
            // 
            // lblCartonBxDCMSerial
            // 
            this.lblCartonBxDCMSerial.AutoSize = true;
            this.lblCartonBxDCMSerial.Location = new System.Drawing.Point(1285, 176);
            this.lblCartonBxDCMSerial.Name = "lblCartonBxDCMSerial";
            this.lblCartonBxDCMSerial.Size = new System.Drawing.Size(199, 15);
            this.lblCartonBxDCMSerial.TabIndex = 25;
            this.lblCartonBxDCMSerial.Text = "Carton Box DCM Serial No. :";
            // 
            // txtBxGiftBoxDCMSerial
            // 
            this.txtBxGiftBoxDCMSerial.Location = new System.Drawing.Point(1130, 170);
            this.txtBxGiftBoxDCMSerial.Name = "txtBxGiftBoxDCMSerial";
            this.txtBxGiftBoxDCMSerial.Size = new System.Drawing.Size(123, 25);
            this.txtBxGiftBoxDCMSerial.TabIndex = 24;
            // 
            // lblGiftBxSerial
            // 
            this.lblGiftBxSerial.AutoSize = true;
            this.lblGiftBxSerial.Location = new System.Drawing.Point(956, 176);
            this.lblGiftBxSerial.Name = "lblGiftBxSerial";
            this.lblGiftBxSerial.Size = new System.Drawing.Size(173, 15);
            this.lblGiftBxSerial.TabIndex = 23;
            this.lblGiftBxSerial.Text = "GiftBox DCM Serial No. :";
            // 
            // txtBxDCMSerial
            // 
            this.txtBxDCMSerial.Location = new System.Drawing.Point(749, 170);
            this.txtBxDCMSerial.Name = "txtBxDCMSerial";
            this.txtBxDCMSerial.Size = new System.Drawing.Size(123, 25);
            this.txtBxDCMSerial.TabIndex = 22;
            // 
            // lblDCMSerialNo
            // 
            this.lblDCMSerialNo.AutoSize = true;
            this.lblDCMSerialNo.Location = new System.Drawing.Point(625, 176);
            this.lblDCMSerialNo.Name = "lblDCMSerialNo";
            this.lblDCMSerialNo.Size = new System.Drawing.Size(118, 15);
            this.lblDCMSerialNo.TabIndex = 21;
            this.lblDCMSerialNo.Text = "DCM Serial No. :";
            // 
            // timePickerStop
            // 
            this.timePickerStop.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerStop.Location = new System.Drawing.Point(678, 81);
            this.timePickerStop.Name = "timePickerStop";
            this.timePickerStop.Size = new System.Drawing.Size(200, 25);
            this.timePickerStop.TabIndex = 20;
            // 
            // lblBurningStop
            // 
            this.lblBurningStop.AutoSize = true;
            this.lblBurningStop.Location = new System.Drawing.Point(625, 88);
            this.lblBurningStop.Name = "lblBurningStop";
            this.lblBurningStop.Size = new System.Drawing.Size(53, 15);
            this.lblBurningStop.TabIndex = 19;
            this.lblBurningStop.Text = "Stop : ";
            // 
            // cmbTestItem
            // 
            this.cmbTestItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTestItem.FormattingEnabled = true;
            this.cmbTestItem.Items.AddRange(new object[] {
            "ACLR",
            "미발진"});
            this.cmbTestItem.Location = new System.Drawing.Point(1130, 127);
            this.cmbTestItem.Name = "cmbTestItem";
            this.cmbTestItem.Size = new System.Drawing.Size(140, 23);
            this.cmbTestItem.TabIndex = 18;
            // 
            // lblTestItemDropDown
            // 
            this.lblTestItemDropDown.AutoSize = true;
            this.lblTestItemDropDown.Location = new System.Drawing.Point(1053, 130);
            this.lblTestItemDropDown.Name = "lblTestItemDropDown";
            this.lblTestItemDropDown.Size = new System.Drawing.Size(76, 15);
            this.lblTestItemDropDown.TabIndex = 17;
            this.lblTestItemDropDown.Text = "Test Item :";
            // 
            // txtBxBurningSeriealNo
            // 
            this.txtBxBurningSeriealNo.Location = new System.Drawing.Point(1130, 50);
            this.txtBxBurningSeriealNo.Name = "txtBxBurningSeriealNo";
            this.txtBxBurningSeriealNo.Size = new System.Drawing.Size(123, 25);
            this.txtBxBurningSeriealNo.TabIndex = 16;
            // 
            // lblBurningSerialNo
            // 
            this.lblBurningSerialNo.AutoSize = true;
            this.lblBurningSerialNo.Location = new System.Drawing.Point(1048, 57);
            this.lblBurningSerialNo.Name = "lblBurningSerialNo";
            this.lblBurningSerialNo.Size = new System.Drawing.Size(81, 15);
            this.lblBurningSerialNo.TabIndex = 15;
            this.lblBurningSerialNo.Text = "Serial No. :";
            // 
            // timePickerStart
            // 
            this.timePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerStart.Location = new System.Drawing.Point(678, 50);
            this.timePickerStart.Name = "timePickerStart";
            this.timePickerStart.Size = new System.Drawing.Size(200, 25);
            this.timePickerStart.TabIndex = 14;
            // 
            // lblBurningStart
            // 
            this.lblBurningStart.AutoSize = true;
            this.lblBurningStart.Location = new System.Drawing.Point(625, 57);
            this.lblBurningStart.Name = "lblBurningStart";
            this.lblBurningStart.Size = new System.Drawing.Size(52, 15);
            this.lblBurningStart.TabIndex = 13;
            this.lblBurningStart.Text = "Start : ";
            // 
            // cmbErrorCatego
            // 
            this.cmbErrorCatego.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbErrorCatego.FormattingEnabled = true;
            this.cmbErrorCatego.Items.AddRange(new object[] {
            "Gain",
            "VSWR",
            "Case",
            "Etc"});
            this.cmbErrorCatego.Location = new System.Drawing.Point(1130, 21);
            this.cmbErrorCatego.Name = "cmbErrorCatego";
            this.cmbErrorCatego.Size = new System.Drawing.Size(121, 23);
            this.cmbErrorCatego.TabIndex = 12;
            // 
            // lblErrorCatego
            // 
            this.lblErrorCatego.AutoSize = true;
            this.lblErrorCatego.Location = new System.Drawing.Point(1047, 24);
            this.lblErrorCatego.Name = "lblErrorCatego";
            this.lblErrorCatego.Size = new System.Drawing.Size(82, 15);
            this.lblErrorCatego.TabIndex = 11;
            this.lblErrorCatego.Text = "이상 분류 :";
            // 
            // cmbPointOfError
            // 
            this.cmbPointOfError.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPointOfError.FormattingEnabled = true;
            this.cmbPointOfError.Items.AddRange(new object[] {
            "DL",
            "UL",
            "etc"});
            this.cmbPointOfError.Location = new System.Drawing.Point(903, 21);
            this.cmbPointOfError.Name = "cmbPointOfError";
            this.cmbPointOfError.Size = new System.Drawing.Size(121, 23);
            this.cmbPointOfError.TabIndex = 10;
            // 
            // lblPointOfError
            // 
            this.lblPointOfError.AutoSize = true;
            this.lblPointOfError.Location = new System.Drawing.Point(815, 24);
            this.lblPointOfError.Name = "lblPointOfError";
            this.lblPointOfError.Size = new System.Drawing.Size(82, 15);
            this.lblPointOfError.TabIndex = 9;
            this.lblPointOfError.Text = "발생 지점 :";
            // 
            // txtBxDetails
            // 
            this.txtBxDetails.Location = new System.Drawing.Point(1490, 24);
            this.txtBxDetails.Multiline = true;
            this.txtBxDetails.Name = "txtBxDetails";
            this.txtBxDetails.Size = new System.Drawing.Size(270, 127);
            this.txtBxDetails.TabIndex = 8;
            // 
            // lblRefNameDetails
            // 
            this.lblRefNameDetails.AutoSize = true;
            this.lblRefNameDetails.Location = new System.Drawing.Point(1285, 21);
            this.lblRefNameDetails.Name = "lblRefNameDetails";
            this.lblRefNameDetails.Size = new System.Drawing.Size(199, 15);
            this.lblRefNameDetails.TabIndex = 6;
            this.lblRefNameDetails.Text = "Reference name and details :";
            // 
            // cmbPassFail
            // 
            this.cmbPassFail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPassFail.FormattingEnabled = true;
            this.cmbPassFail.Items.AddRange(new object[] {
            "Pass",
            "Fail"});
            this.cmbPassFail.Location = new System.Drawing.Point(678, 21);
            this.cmbPassFail.Name = "cmbPassFail";
            this.cmbPassFail.Size = new System.Drawing.Size(121, 23);
            this.cmbPassFail.TabIndex = 5;
            this.cmbPassFail.SelectedValueChanged += new System.EventHandler(this.cmbPassFail_SelectedValueChanged);
            // 
            // lblPassFail
            // 
            this.lblPassFail.AutoSize = true;
            this.lblPassFail.Location = new System.Drawing.Point(625, 24);
            this.lblPassFail.Name = "lblPassFail";
            this.lblPassFail.Size = new System.Drawing.Size(47, 15);
            this.lblPassFail.TabIndex = 4;
            this.lblPassFail.Text = "결과 :";
            // 
            // cmbProductionProcSelect
            // 
            this.cmbProductionProcSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductionProcSelect.FormattingEnabled = true;
            this.cmbProductionProcSelect.Items.AddRange(new object[] {
            "수삽",
            "Tuning",
            "반조립",
            "Table",
            "Burning",
            "ATS1",
            "ATS2",
            "ICS1",
            "ICS2",
            "완조립",
            "포장",
            "출하",
            "수리"});
            this.cmbProductionProcSelect.Location = new System.Drawing.Point(440, 21);
            this.cmbProductionProcSelect.Name = "cmbProductionProcSelect";
            this.cmbProductionProcSelect.Size = new System.Drawing.Size(121, 23);
            this.cmbProductionProcSelect.TabIndex = 3;
            this.cmbProductionProcSelect.SelectedValueChanged += new System.EventHandler(this.cmbProductionProcSelect_SelectedValueChanged);
            // 
            // lblcmbModel
            // 
            this.lblcmbModel.AutoSize = true;
            this.lblcmbModel.Location = new System.Drawing.Point(392, 24);
            this.lblcmbModel.Name = "lblcmbModel";
            this.lblcmbModel.Size = new System.Drawing.Size(52, 15);
            this.lblcmbModel.TabIndex = 2;
            this.lblcmbModel.Text = "공정 : ";
            // 
            // cmbModel
            // 
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Items.AddRange(new object[] {
            "TB-3033C",
            "TB-3093C",
            "TB-3103C"});
            this.cmbModel.Location = new System.Drawing.Point(90, 21);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(121, 23);
            this.cmbModel.TabIndex = 1;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(22, 24);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(62, 15);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Model : ";
            // 
            // btnWrite
            // 
            this.btnWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWrite.Location = new System.Drawing.Point(1621, 401);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 1;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            // 
            // lblDefectDescription
            // 
            this.lblDefectDescription.AutoSize = true;
            this.lblDefectDescription.Location = new System.Drawing.Point(852, 333);
            this.lblDefectDescription.Name = "lblDefectDescription";
            this.lblDefectDescription.Size = new System.Drawing.Size(111, 15);
            this.lblDefectDescription.TabIndex = 54;
            this.lblDefectDescription.Text = "Defect details : ";
            // 
            // txtBxDefectDescript
            // 
            this.txtBxDefectDescript.Location = new System.Drawing.Point(959, 333);
            this.txtBxDefectDescript.Multiline = true;
            this.txtBxDefectDescript.Name = "txtBxDefectDescript";
            this.txtBxDefectDescript.Size = new System.Drawing.Size(270, 149);
            this.txtBxDefectDescript.TabIndex = 55;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1709, 436);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpBxRepairFix.ResumeLayout(false);
            this.grpBxRepairFix.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBxPartSerial;
        private System.Windows.Forms.Label lblPartSerial;
        private System.Windows.Forms.TextBox txtBxCSSerial;
        private System.Windows.Forms.Label lblCSserial;
        private System.Windows.Forms.ComboBox cmbSerialMatching;
        private System.Windows.Forms.Label lblSerialMatching;
        private System.Windows.Forms.TextBox txtBxCartonBoxDCMSerial;
        private System.Windows.Forms.Label lblCartonBxDCMSerial;
        private System.Windows.Forms.TextBox txtBxGiftBoxDCMSerial;
        private System.Windows.Forms.Label lblGiftBxSerial;
        private System.Windows.Forms.TextBox txtBxDCMSerial;
        private System.Windows.Forms.Label lblDCMSerialNo;
        private System.Windows.Forms.DateTimePicker timePickerStop;
        private System.Windows.Forms.Label lblBurningStop;
        private System.Windows.Forms.ComboBox cmbTestItem;
        private System.Windows.Forms.Label lblTestItemDropDown;
        private System.Windows.Forms.TextBox txtBxBurningSeriealNo;
        private System.Windows.Forms.Label lblBurningSerialNo;
        private System.Windows.Forms.DateTimePicker timePickerStart;
        private System.Windows.Forms.Label lblBurningStart;
        private System.Windows.Forms.ComboBox cmbErrorCatego;
        private System.Windows.Forms.Label lblErrorCatego;
        private System.Windows.Forms.ComboBox cmbPointOfError;
        private System.Windows.Forms.Label lblPointOfError;
        private System.Windows.Forms.TextBox txtBxDetails;
        private System.Windows.Forms.Label lblRefNameDetails;
        private System.Windows.Forms.ComboBox cmbPassFail;
        private System.Windows.Forms.Label lblPassFail;
        private System.Windows.Forms.ComboBox cmbProductionProcSelect;
        private System.Windows.Forms.Label lblcmbModel;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.ComboBox cmbBurningYesNo;
        private System.Windows.Forms.Label lblBurningCheck;
        private System.Windows.Forms.DateTimePicker dateTPicker;
        private System.Windows.Forms.Label lblDeportDate;
        private System.Windows.Forms.Label lblTimeElapsed;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtBxShipDataDCMSerial;
        private System.Windows.Forms.Label lblShipDataDCMSerial;
        private System.Windows.Forms.TextBox txtBxShipDataAdapterSerial;
        private System.Windows.Forms.Label lblShipDataAdapterSerial;
        private System.Windows.Forms.TextBox txtBxShipDataModemSerial;
        private System.Windows.Forms.Label lblShipDataModemSerial;
        private System.Windows.Forms.TextBox txtBxShipDataCSserial;
        private System.Windows.Forms.Label lblShipDataCSserial;
        private System.Windows.Forms.ComboBox cmbDataCategory;
        private System.Windows.Forms.Label lblDataCategory;
        private System.Windows.Forms.DateTimePicker dateTimeShippingDate;
        private System.Windows.Forms.Label lblShipDataShippingDate;
        private System.Windows.Forms.GroupBox grpBxRepairFix;
        private System.Windows.Forms.Label lblFullIntegFailLabel;
        private System.Windows.Forms.Label lblICS2FailLabel;
        private System.Windows.Forms.Label lblICS1FailLabel;
        private System.Windows.Forms.Label lblATS2FailLabel;
        private System.Windows.Forms.Label lblATS1FailLabel;
        private System.Windows.Forms.Label lblPartialIntegFailLabel;
        private System.Windows.Forms.Label lblTuningFailLabel;
        private System.Windows.Forms.Label lblSolderingFailLabel;
        private System.Windows.Forms.Label lblTableFailLabel;
        private System.Windows.Forms.TextBox txtBxDefectDescript;
        private System.Windows.Forms.Label lblDefectDescription;
    }
}

