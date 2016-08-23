namespace vSlide
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toggleFeedingButton = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.pingPongTimer = new System.Windows.Forms.Timer(this.components);
            this.inputCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.currSliderValueRelLabel = new System.Windows.Forms.Label();
            this.currSliderValueInfoLabel = new System.Windows.Forms.Label();
            this.currSliderValueLabel = new System.Windows.Forms.Label();
            this.maxSliderValueInfoLabel = new System.Windows.Forms.Label();
            this.maxSliderValueLabel = new System.Windows.Forms.Label();
            this.currFeederStateInfoLabel = new System.Windows.Forms.Label();
            this.vJoyDllVersionInfoLabel = new System.Windows.Forms.Label();
            this.vJoyDriverVersionInfoLabel = new System.Windows.Forms.Label();
            this.vJoyDriverFoundInfoLabel = new System.Windows.Forms.Label();
            this.vJoyDriverFoundLabel = new System.Windows.Forms.Label();
            this.vJoyDriverVersionLabel = new System.Windows.Forms.Label();
            this.vJoyDllVersionLabel = new System.Windows.Forms.Label();
            this.currFeederStateLabel = new System.Windows.Forms.Label();
            this.usedVJoyDeviceLabel = new System.Windows.Forms.Label();
            this.usedVJoyDeviceInfoLabel = new System.Windows.Forms.Label();
            this.otherFormsMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mappingThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sliderAxisInfoLabel3 = new System.Windows.Forms.Label();
            this.sliderAxisInfoLabel2 = new System.Windows.Forms.Label();
            this.sliderAxisInfoLabel1 = new System.Windows.Forms.Label();
            this.sliderInfolabel = new System.Windows.Forms.Label();
            this.pingPongCheckBox = new System.Windows.Forms.CheckBox();
            this.sliderTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.useLevelKeysLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.holdModeLevelLabel = new System.Windows.Forms.Label();
            this.holdTresholdLevelLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tickIntervalLevelLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tickIntervalSliderLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.holdTresholdSliderLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.holdModeSliderLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.useSliderKeysLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.sliderDeltaSliderLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.canNotFeedInfoLabel = new System.Windows.Forms.Label();
            this.debugModeCheckBox = new System.Windows.Forms.CheckBox();
            this.debugInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.otherFormsMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderTrackBar)).BeginInit();
            this.debugInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toggleFeedingButton
            // 
            this.toggleFeedingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleFeedingButton.Enabled = false;
            this.toggleFeedingButton.Location = new System.Drawing.Point(632, 425);
            this.toggleFeedingButton.Name = "toggleFeedingButton";
            this.toggleFeedingButton.Size = new System.Drawing.Size(98, 30);
            this.toggleFeedingButton.TabIndex = 0;
            this.toggleFeedingButton.Text = "Start feeding";
            this.toggleFeedingButton.UseVisualStyleBackColor = true;
            this.toggleFeedingButton.Click += new System.EventHandler(this.toggleFeedingButton_Click);
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(12, 31);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(558, 333);
            this.logTextBox.TabIndex = 1;
            // 
            // pingPongTimer
            // 
            this.pingPongTimer.Interval = 5;
            this.pingPongTimer.Tick += new System.EventHandler(this.pingPongTimer_Tick);
            // 
            // inputCheckTimer
            // 
            this.inputCheckTimer.Interval = 5;
            this.inputCheckTimer.Tick += new System.EventHandler(this.inputCheckTimer_Tick);
            // 
            // currSliderValueRelLabel
            // 
            this.currSliderValueRelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currSliderValueRelLabel.AutoSize = true;
            this.currSliderValueRelLabel.Location = new System.Drawing.Point(739, 134);
            this.currSliderValueRelLabel.Name = "currSliderValueRelLabel";
            this.currSliderValueRelLabel.Size = new System.Drawing.Size(21, 13);
            this.currSliderValueRelLabel.TabIndex = 9;
            this.currSliderValueRelLabel.Text = "0%";
            // 
            // currSliderValueInfoLabel
            // 
            this.currSliderValueInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currSliderValueInfoLabel.AutoSize = true;
            this.currSliderValueInfoLabel.Location = new System.Drawing.Point(589, 134);
            this.currSliderValueInfoLabel.Name = "currSliderValueInfoLabel";
            this.currSliderValueInfoLabel.Size = new System.Drawing.Size(88, 13);
            this.currSliderValueInfoLabel.TabIndex = 10;
            this.currSliderValueInfoLabel.Text = "Curr Slider Value:";
            // 
            // currSliderValueLabel
            // 
            this.currSliderValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currSliderValueLabel.AutoSize = true;
            this.currSliderValueLabel.Location = new System.Drawing.Point(691, 134);
            this.currSliderValueLabel.Name = "currSliderValueLabel";
            this.currSliderValueLabel.Size = new System.Drawing.Size(13, 13);
            this.currSliderValueLabel.TabIndex = 11;
            this.currSliderValueLabel.Text = "0";
            // 
            // maxSliderValueInfoLabel
            // 
            this.maxSliderValueInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxSliderValueInfoLabel.AutoSize = true;
            this.maxSliderValueInfoLabel.Location = new System.Drawing.Point(589, 119);
            this.maxSliderValueInfoLabel.Name = "maxSliderValueInfoLabel";
            this.maxSliderValueInfoLabel.Size = new System.Drawing.Size(89, 13);
            this.maxSliderValueInfoLabel.TabIndex = 12;
            this.maxSliderValueInfoLabel.Text = "Max Slider Value:";
            // 
            // maxSliderValueLabel
            // 
            this.maxSliderValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxSliderValueLabel.AutoSize = true;
            this.maxSliderValueLabel.Location = new System.Drawing.Point(691, 119);
            this.maxSliderValueLabel.Name = "maxSliderValueLabel";
            this.maxSliderValueLabel.Size = new System.Drawing.Size(13, 13);
            this.maxSliderValueLabel.TabIndex = 13;
            this.maxSliderValueLabel.Text = "0";
            // 
            // currFeederStateInfoLabel
            // 
            this.currFeederStateInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currFeederStateInfoLabel.AutoSize = true;
            this.currFeederStateInfoLabel.Location = new System.Drawing.Point(589, 104);
            this.currFeederStateInfoLabel.Name = "currFeederStateInfoLabel";
            this.currFeederStateInfoLabel.Size = new System.Drawing.Size(72, 13);
            this.currFeederStateInfoLabel.TabIndex = 14;
            this.currFeederStateInfoLabel.Text = "Current State:";
            // 
            // vJoyDllVersionInfoLabel
            // 
            this.vJoyDllVersionInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vJoyDllVersionInfoLabel.AutoSize = true;
            this.vJoyDllVersionInfoLabel.Location = new System.Drawing.Point(589, 64);
            this.vJoyDllVersionInfoLabel.Name = "vJoyDllVersionInfoLabel";
            this.vJoyDllVersionInfoLabel.Size = new System.Drawing.Size(83, 13);
            this.vJoyDllVersionInfoLabel.TabIndex = 15;
            this.vJoyDllVersionInfoLabel.Text = "vJoy dll Version:";
            // 
            // vJoyDriverVersionInfoLabel
            // 
            this.vJoyDriverVersionInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vJoyDriverVersionInfoLabel.AutoSize = true;
            this.vJoyDriverVersionInfoLabel.Location = new System.Drawing.Point(589, 49);
            this.vJoyDriverVersionInfoLabel.Name = "vJoyDriverVersionInfoLabel";
            this.vJoyDriverVersionInfoLabel.Size = new System.Drawing.Size(101, 13);
            this.vJoyDriverVersionInfoLabel.TabIndex = 16;
            this.vJoyDriverVersionInfoLabel.Text = "vJoy Driver Version:";
            // 
            // vJoyDriverFoundInfoLabel
            // 
            this.vJoyDriverFoundInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vJoyDriverFoundInfoLabel.AutoSize = true;
            this.vJoyDriverFoundInfoLabel.Location = new System.Drawing.Point(589, 34);
            this.vJoyDriverFoundInfoLabel.Name = "vJoyDriverFoundInfoLabel";
            this.vJoyDriverFoundInfoLabel.Size = new System.Drawing.Size(93, 13);
            this.vJoyDriverFoundInfoLabel.TabIndex = 17;
            this.vJoyDriverFoundInfoLabel.Text = "vJoy Driver found:";
            // 
            // vJoyDriverFoundLabel
            // 
            this.vJoyDriverFoundLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vJoyDriverFoundLabel.AutoSize = true;
            this.vJoyDriverFoundLabel.Location = new System.Drawing.Point(691, 33);
            this.vJoyDriverFoundLabel.Name = "vJoyDriverFoundLabel";
            this.vJoyDriverFoundLabel.Size = new System.Drawing.Size(10, 13);
            this.vJoyDriverFoundLabel.TabIndex = 18;
            this.vJoyDriverFoundLabel.Text = "-";
            // 
            // vJoyDriverVersionLabel
            // 
            this.vJoyDriverVersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vJoyDriverVersionLabel.AutoSize = true;
            this.vJoyDriverVersionLabel.Location = new System.Drawing.Point(691, 49);
            this.vJoyDriverVersionLabel.Name = "vJoyDriverVersionLabel";
            this.vJoyDriverVersionLabel.Size = new System.Drawing.Size(10, 13);
            this.vJoyDriverVersionLabel.TabIndex = 19;
            this.vJoyDriverVersionLabel.Text = "-";
            // 
            // vJoyDllVersionLabel
            // 
            this.vJoyDllVersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vJoyDllVersionLabel.AutoSize = true;
            this.vJoyDllVersionLabel.Location = new System.Drawing.Point(691, 64);
            this.vJoyDllVersionLabel.Name = "vJoyDllVersionLabel";
            this.vJoyDllVersionLabel.Size = new System.Drawing.Size(10, 13);
            this.vJoyDllVersionLabel.TabIndex = 20;
            this.vJoyDllVersionLabel.Text = "-";
            // 
            // currFeederStateLabel
            // 
            this.currFeederStateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currFeederStateLabel.AutoSize = true;
            this.currFeederStateLabel.Location = new System.Drawing.Point(691, 104);
            this.currFeederStateLabel.Name = "currFeederStateLabel";
            this.currFeederStateLabel.Size = new System.Drawing.Size(10, 13);
            this.currFeederStateLabel.TabIndex = 21;
            this.currFeederStateLabel.Text = "-";
            // 
            // usedVJoyDeviceLabel
            // 
            this.usedVJoyDeviceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usedVJoyDeviceLabel.AutoSize = true;
            this.usedVJoyDeviceLabel.Location = new System.Drawing.Point(691, 79);
            this.usedVJoyDeviceLabel.Name = "usedVJoyDeviceLabel";
            this.usedVJoyDeviceLabel.Size = new System.Drawing.Size(10, 13);
            this.usedVJoyDeviceLabel.TabIndex = 23;
            this.usedVJoyDeviceLabel.Text = "-";
            // 
            // usedVJoyDeviceInfoLabel
            // 
            this.usedVJoyDeviceInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usedVJoyDeviceInfoLabel.AutoSize = true;
            this.usedVJoyDeviceInfoLabel.Location = new System.Drawing.Point(589, 79);
            this.usedVJoyDeviceInfoLabel.Name = "usedVJoyDeviceInfoLabel";
            this.usedVJoyDeviceInfoLabel.Size = new System.Drawing.Size(81, 13);
            this.usedVJoyDeviceInfoLabel.TabIndex = 22;
            this.usedVJoyDeviceInfoLabel.Text = "vJoy Device Id:";
            // 
            // otherFormsMenuStrip
            // 
            this.otherFormsMenuStrip.Enabled = false;
            this.otherFormsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mappingThemeToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.instructionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.otherFormsMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.otherFormsMenuStrip.Name = "otherFormsMenuStrip";
            this.otherFormsMenuStrip.Size = new System.Drawing.Size(780, 24);
            this.otherFormsMenuStrip.TabIndex = 32;
            // 
            // mappingThemeToolStripMenuItem
            // 
            this.mappingThemeToolStripMenuItem.Name = "mappingThemeToolStripMenuItem";
            this.mappingThemeToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.mappingThemeToolStripMenuItem.Text = "Manage Slider Levels";
            this.mappingThemeToolStripMenuItem.Click += new System.EventHandler(this.mappingThemeToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // sliderAxisInfoLabel3
            // 
            this.sliderAxisInfoLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sliderAxisInfoLabel3.AutoSize = true;
            this.sliderAxisInfoLabel3.Location = new System.Drawing.Point(537, 442);
            this.sliderAxisInfoLabel3.Name = "sliderAxisInfoLabel3";
            this.sliderAxisInfoLabel3.Size = new System.Drawing.Size(33, 13);
            this.sliderAxisInfoLabel3.TabIndex = 38;
            this.sliderAxisInfoLabel3.Text = "100%";
            // 
            // sliderAxisInfoLabel2
            // 
            this.sliderAxisInfoLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sliderAxisInfoLabel2.AutoSize = true;
            this.sliderAxisInfoLabel2.Location = new System.Drawing.Point(280, 442);
            this.sliderAxisInfoLabel2.Name = "sliderAxisInfoLabel2";
            this.sliderAxisInfoLabel2.Size = new System.Drawing.Size(27, 13);
            this.sliderAxisInfoLabel2.TabIndex = 37;
            this.sliderAxisInfoLabel2.Text = "50%";
            // 
            // sliderAxisInfoLabel1
            // 
            this.sliderAxisInfoLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sliderAxisInfoLabel1.AutoSize = true;
            this.sliderAxisInfoLabel1.Location = new System.Drawing.Point(21, 442);
            this.sliderAxisInfoLabel1.Name = "sliderAxisInfoLabel1";
            this.sliderAxisInfoLabel1.Size = new System.Drawing.Size(21, 13);
            this.sliderAxisInfoLabel1.TabIndex = 36;
            this.sliderAxisInfoLabel1.Text = "0%";
            // 
            // sliderInfolabel
            // 
            this.sliderInfolabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sliderInfolabel.AutoSize = true;
            this.sliderInfolabel.Location = new System.Drawing.Point(21, 378);
            this.sliderInfolabel.Name = "sliderInfolabel";
            this.sliderInfolabel.Size = new System.Drawing.Size(136, 13);
            this.sliderInfolabel.TabIndex = 35;
            this.sliderInfolabel.Text = "Set the slider axis manually:";
            // 
            // pingPongCheckBox
            // 
            this.pingPongCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pingPongCheckBox.AutoSize = true;
            this.pingPongCheckBox.Enabled = false;
            this.pingPongCheckBox.Location = new System.Drawing.Point(440, 374);
            this.pingPongCheckBox.Name = "pingPongCheckBox";
            this.pingPongCheckBox.Size = new System.Drawing.Size(130, 17);
            this.pingPongCheckBox.TabIndex = 34;
            this.pingPongCheckBox.Text = "Do Ping Pong Lerping";
            this.pingPongCheckBox.UseVisualStyleBackColor = true;
            this.pingPongCheckBox.CheckedChanged += new System.EventHandler(this.pingPongCheckBox_CheckedChanged);
            // 
            // sliderTrackBar
            // 
            this.sliderTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sliderTrackBar.Enabled = false;
            this.sliderTrackBar.Location = new System.Drawing.Point(13, 394);
            this.sliderTrackBar.Maximum = 100;
            this.sliderTrackBar.Name = "sliderTrackBar";
            this.sliderTrackBar.Size = new System.Drawing.Size(557, 45);
            this.sliderTrackBar.TabIndex = 33;
            this.sliderTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.sliderTrackBar.Value = 50;
            this.sliderTrackBar.Scroll += new System.EventHandler(this.sliderTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Use Level Keys:";
            // 
            // useLevelKeysLabel
            // 
            this.useLevelKeysLabel.AutoSize = true;
            this.useLevelKeysLabel.Location = new System.Drawing.Point(104, 16);
            this.useLevelKeysLabel.Name = "useLevelKeysLabel";
            this.useLevelKeysLabel.Size = new System.Drawing.Size(10, 13);
            this.useLevelKeysLabel.TabIndex = 47;
            this.useLevelKeysLabel.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Hold Down Mode:";
            // 
            // holdModeLevelLabel
            // 
            this.holdModeLevelLabel.AutoSize = true;
            this.holdModeLevelLabel.Location = new System.Drawing.Point(132, 31);
            this.holdModeLevelLabel.Name = "holdModeLevelLabel";
            this.holdModeLevelLabel.Size = new System.Drawing.Size(10, 13);
            this.holdModeLevelLabel.TabIndex = 49;
            this.holdModeLevelLabel.Text = "-";
            // 
            // holdTresholdLevelLabel
            // 
            this.holdTresholdLevelLabel.AutoSize = true;
            this.holdTresholdLevelLabel.Location = new System.Drawing.Point(132, 46);
            this.holdTresholdLevelLabel.Name = "holdTresholdLevelLabel";
            this.holdTresholdLevelLabel.Size = new System.Drawing.Size(29, 13);
            this.holdTresholdLevelLabel.TabIndex = 51;
            this.holdTresholdLevelLabel.Text = "0 ms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Hold Down Treshold:";
            // 
            // tickIntervalLevelLabel
            // 
            this.tickIntervalLevelLabel.AutoSize = true;
            this.tickIntervalLevelLabel.Location = new System.Drawing.Point(132, 61);
            this.tickIntervalLevelLabel.Name = "tickIntervalLevelLabel";
            this.tickIntervalLevelLabel.Size = new System.Drawing.Size(29, 13);
            this.tickIntervalLevelLabel.TabIndex = 53;
            this.tickIntervalLevelLabel.Text = "0 ms";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Tick Interval:";
            // 
            // tickIntervalSliderLabel
            // 
            this.tickIntervalSliderLabel.AutoSize = true;
            this.tickIntervalSliderLabel.Location = new System.Drawing.Point(132, 133);
            this.tickIntervalSliderLabel.Name = "tickIntervalSliderLabel";
            this.tickIntervalSliderLabel.Size = new System.Drawing.Size(29, 13);
            this.tickIntervalSliderLabel.TabIndex = 61;
            this.tickIntervalSliderLabel.Text = "0 ms";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 60;
            this.label10.Text = "Tick Interval:";
            // 
            // holdTresholdSliderLabel
            // 
            this.holdTresholdSliderLabel.AutoSize = true;
            this.holdTresholdSliderLabel.Location = new System.Drawing.Point(132, 118);
            this.holdTresholdSliderLabel.Name = "holdTresholdSliderLabel";
            this.holdTresholdSliderLabel.Size = new System.Drawing.Size(29, 13);
            this.holdTresholdSliderLabel.TabIndex = 59;
            this.holdTresholdSliderLabel.Text = "0 ms";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 58;
            this.label12.Text = "Hold Down Treshold:";
            // 
            // holdModeSliderLabel
            // 
            this.holdModeSliderLabel.AutoSize = true;
            this.holdModeSliderLabel.Location = new System.Drawing.Point(132, 103);
            this.holdModeSliderLabel.Name = "holdModeSliderLabel";
            this.holdModeSliderLabel.Size = new System.Drawing.Size(10, 13);
            this.holdModeSliderLabel.TabIndex = 57;
            this.holdModeSliderLabel.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 13);
            this.label14.TabIndex = 56;
            this.label14.Text = "Hold Down Mode:";
            // 
            // useSliderKeysLabel
            // 
            this.useSliderKeysLabel.AutoSize = true;
            this.useSliderKeysLabel.Location = new System.Drawing.Point(104, 88);
            this.useSliderKeysLabel.Name = "useSliderKeysLabel";
            this.useSliderKeysLabel.Size = new System.Drawing.Size(10, 13);
            this.useSliderKeysLabel.TabIndex = 55;
            this.useSliderKeysLabel.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 88);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 13);
            this.label16.TabIndex = 54;
            this.label16.Text = "Use Slider Keys:";
            // 
            // sliderDeltaSliderLabel
            // 
            this.sliderDeltaSliderLabel.AutoSize = true;
            this.sliderDeltaSliderLabel.Location = new System.Drawing.Point(132, 148);
            this.sliderDeltaSliderLabel.Name = "sliderDeltaSliderLabel";
            this.sliderDeltaSliderLabel.Size = new System.Drawing.Size(13, 13);
            this.sliderDeltaSliderLabel.TabIndex = 63;
            this.sliderDeltaSliderLabel.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 148);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 13);
            this.label18.TabIndex = 62;
            this.label18.Text = "Slider Delta:";
            // 
            // canNotFeedInfoLabel
            // 
            this.canNotFeedInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.canNotFeedInfoLabel.AutoSize = true;
            this.canNotFeedInfoLabel.Location = new System.Drawing.Point(598, 387);
            this.canNotFeedInfoLabel.MaximumSize = new System.Drawing.Size(170, 0);
            this.canNotFeedInfoLabel.Name = "canNotFeedInfoLabel";
            this.canNotFeedInfoLabel.Size = new System.Drawing.Size(157, 26);
            this.canNotFeedInfoLabel.TabIndex = 45;
            this.canNotFeedInfoLabel.Text = "The programm isn\'t finished with setting up.";
            this.canNotFeedInfoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // debugModeCheckBox
            // 
            this.debugModeCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.debugModeCheckBox.AutoSize = true;
            this.debugModeCheckBox.Location = new System.Drawing.Point(621, 169);
            this.debugModeCheckBox.Name = "debugModeCheckBox";
            this.debugModeCheckBox.Size = new System.Drawing.Size(116, 17);
            this.debugModeCheckBox.TabIndex = 64;
            this.debugModeCheckBox.Text = "Display Debug Info";
            this.debugModeCheckBox.UseVisualStyleBackColor = true;
            this.debugModeCheckBox.CheckedChanged += new System.EventHandler(this.debugModeCheckBox_CheckedChanged);
            // 
            // debugInfoGroupBox
            // 
            this.debugInfoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.debugInfoGroupBox.Controls.Add(this.sliderDeltaSliderLabel);
            this.debugInfoGroupBox.Controls.Add(this.label18);
            this.debugInfoGroupBox.Controls.Add(this.tickIntervalSliderLabel);
            this.debugInfoGroupBox.Controls.Add(this.label10);
            this.debugInfoGroupBox.Controls.Add(this.holdTresholdSliderLabel);
            this.debugInfoGroupBox.Controls.Add(this.label12);
            this.debugInfoGroupBox.Controls.Add(this.holdModeSliderLabel);
            this.debugInfoGroupBox.Controls.Add(this.label14);
            this.debugInfoGroupBox.Controls.Add(this.useSliderKeysLabel);
            this.debugInfoGroupBox.Controls.Add(this.label16);
            this.debugInfoGroupBox.Controls.Add(this.tickIntervalLevelLabel);
            this.debugInfoGroupBox.Controls.Add(this.label8);
            this.debugInfoGroupBox.Controls.Add(this.holdTresholdLevelLabel);
            this.debugInfoGroupBox.Controls.Add(this.label6);
            this.debugInfoGroupBox.Controls.Add(this.holdModeLevelLabel);
            this.debugInfoGroupBox.Controls.Add(this.label3);
            this.debugInfoGroupBox.Controls.Add(this.useLevelKeysLabel);
            this.debugInfoGroupBox.Controls.Add(this.label1);
            this.debugInfoGroupBox.Location = new System.Drawing.Point(585, 196);
            this.debugInfoGroupBox.Name = "debugInfoGroupBox";
            this.debugInfoGroupBox.Size = new System.Drawing.Size(184, 168);
            this.debugInfoGroupBox.TabIndex = 65;
            this.debugInfoGroupBox.TabStop = false;
            this.debugInfoGroupBox.Text = "Debug Info";
            this.debugInfoGroupBox.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 468);
            this.Controls.Add(this.debugInfoGroupBox);
            this.Controls.Add(this.debugModeCheckBox);
            this.Controls.Add(this.canNotFeedInfoLabel);
            this.Controls.Add(this.sliderAxisInfoLabel3);
            this.Controls.Add(this.sliderAxisInfoLabel2);
            this.Controls.Add(this.sliderAxisInfoLabel1);
            this.Controls.Add(this.sliderInfolabel);
            this.Controls.Add(this.pingPongCheckBox);
            this.Controls.Add(this.sliderTrackBar);
            this.Controls.Add(this.usedVJoyDeviceLabel);
            this.Controls.Add(this.usedVJoyDeviceInfoLabel);
            this.Controls.Add(this.currFeederStateLabel);
            this.Controls.Add(this.vJoyDllVersionLabel);
            this.Controls.Add(this.vJoyDriverVersionLabel);
            this.Controls.Add(this.vJoyDriverFoundLabel);
            this.Controls.Add(this.vJoyDriverFoundInfoLabel);
            this.Controls.Add(this.vJoyDriverVersionInfoLabel);
            this.Controls.Add(this.vJoyDllVersionInfoLabel);
            this.Controls.Add(this.currFeederStateInfoLabel);
            this.Controls.Add(this.maxSliderValueLabel);
            this.Controls.Add(this.maxSliderValueInfoLabel);
            this.Controls.Add(this.currSliderValueLabel);
            this.Controls.Add(this.currSliderValueInfoLabel);
            this.Controls.Add(this.currSliderValueRelLabel);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.toggleFeedingButton);
            this.Controls.Add(this.otherFormsMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "vSlide - A vJoy Feeder";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.otherFormsMenuStrip.ResumeLayout(false);
            this.otherFormsMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderTrackBar)).EndInit();
            this.debugInfoGroupBox.ResumeLayout(false);
            this.debugInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button toggleFeedingButton;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Timer pingPongTimer;
        private System.Windows.Forms.Timer inputCheckTimer;
        private System.Windows.Forms.Label currSliderValueRelLabel;
        private System.Windows.Forms.Label currSliderValueInfoLabel;
        private System.Windows.Forms.Label currSliderValueLabel;
        private System.Windows.Forms.Label maxSliderValueInfoLabel;
        private System.Windows.Forms.Label maxSliderValueLabel;
        private System.Windows.Forms.Label currFeederStateInfoLabel;
        private System.Windows.Forms.Label vJoyDllVersionInfoLabel;
        private System.Windows.Forms.Label vJoyDriverVersionInfoLabel;
        private System.Windows.Forms.Label vJoyDriverFoundInfoLabel;
        private System.Windows.Forms.Label vJoyDriverFoundLabel;
        private System.Windows.Forms.Label vJoyDriverVersionLabel;
        private System.Windows.Forms.Label vJoyDllVersionLabel;
        private System.Windows.Forms.Label currFeederStateLabel;
        private System.Windows.Forms.Label usedVJoyDeviceLabel;
        private System.Windows.Forms.Label usedVJoyDeviceInfoLabel;
        private System.Windows.Forms.MenuStrip otherFormsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mappingThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label sliderAxisInfoLabel3;
        private System.Windows.Forms.Label sliderAxisInfoLabel2;
        private System.Windows.Forms.Label sliderAxisInfoLabel1;
        private System.Windows.Forms.Label sliderInfolabel;
        private System.Windows.Forms.CheckBox pingPongCheckBox;
        private System.Windows.Forms.TrackBar sliderTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label useLevelKeysLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label holdModeLevelLabel;
        private System.Windows.Forms.Label holdTresholdLevelLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tickIntervalLevelLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label tickIntervalSliderLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label holdTresholdSliderLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label holdModeSliderLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label useSliderKeysLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label sliderDeltaSliderLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label canNotFeedInfoLabel;
        private System.Windows.Forms.CheckBox debugModeCheckBox;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.GroupBox debugInfoGroupBox;
    }
}

