using SimpleSniffer.BaseClass;
using System.Windows.Forms;

namespace SimpleSniffer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.filterCheckBox = new System.Windows.Forms.CheckBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.hintLabel = new System.Windows.Forms.Label();
            this.packetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.allButton = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.clearButton = new SimpleSniffer.BaseClass.MyButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.listOptions = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.window_size = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.urgentPointer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checksum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.reservedBits = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flags_checks = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tcpheader_size = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.offset = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ack = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.seq = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dest_port = new System.Windows.Forms.TextBox();
            this.src_port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.charTextBox = new SimpleSniffer.BaseClass.MyRichTextBox();
            this.hexTextBox = new SimpleSniffer.BaseClass.MyRichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.packetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterCheckBox
            // 
            this.filterCheckBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterCheckBox.Location = new System.Drawing.Point(28, 15);
            this.filterCheckBox.Name = "filterCheckBox";
            this.filterCheckBox.Size = new System.Drawing.Size(103, 29);
            this.filterCheckBox.TabIndex = 0;
            this.filterCheckBox.Text = "filter";
            this.toolTip1.SetToolTip(this.filterCheckBox, "Filter via certain ip, port and protocol type before sniffing.");
            this.filterCheckBox.UseVisualStyleBackColor = true;
            this.filterCheckBox.CheckedChanged += new System.EventHandler(this.filterCheckBox_CheckedChanged);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(496, 9);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(70, 33);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(581, 9);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(70, 33);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // ipTextBox
            // 
            this.ipTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ipTextBox.Location = new System.Drawing.Point(101, 12);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(149, 26);
            this.ipTextBox.TabIndex = 3;
            this.ipTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.ipTextBox, "Filter Format(For source host only): IP, PORT, IP/PORT OR IP:PORT");
            this.ipTextBox.GotFocus += new System.EventHandler(this.ipTextBox_GotFocus);
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintLabel.Location = new System.Drawing.Point(1, 569);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(250, 16);
            this.hintLabel.TabIndex = 4;
            this.hintLabel.Text = "Packets received: 0  Total length: [0 Bytes]";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(3, 49);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(826, 307);
            this.listView.TabIndex = 6;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Source_IP";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Source_PORT";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Destination_IP";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Destination_PORT";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "TYPE";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "TIME";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "TotalLength";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 88;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "briedInfo";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 133;
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "",
            "TCP",
            "UDP",
            "GGP",
            "ICMP",
            "IDP",
            "IGMP",
            "IP",
            "ND",
            "PUP",
            "OTHERS"});
            this.typeComboBox.Location = new System.Drawing.Point(280, 11);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(103, 27);
            this.typeComboBox.TabIndex = 7;
            // 
            // allButton
            // 
            this.allButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allButton.Location = new System.Drawing.Point(740, 9);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(85, 33);
            this.allButton.TabIndex = 10;
            this.allButton.Text = "AllSniffed";
            this.allButton.UseVisualStyleBackColor = true;
            this.allButton.Click += new System.EventHandler(this.allButton_Click);
            // 
            // filterButton
            // 
            this.filterButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterButton.Location = new System.Drawing.Point(412, 9);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(70, 33);
            this.filterButton.TabIndex = 11;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(666, 9);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(70, 33);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.toolTip3.SetToolTip(this.clearButton, "One click, clear all the list; double click, clear all the sniffed packets");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.DoubleClick += new System.EventHandler(this.clearButton_DoubleClick);
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.listOptions);
            this.groupBox1.Controls.Add(this.window_size);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.urgentPointer);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.checksum);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tcpheader_size);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.offset);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ack);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.seq);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dest_port);
            this.groupBox1.Controls.Add(this.src_port);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(835, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 584);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Pacote TCP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Opções";
            // 
            // listOptions
            // 
            this.listOptions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader12,
            this.columnHeader13});
            this.listOptions.HideSelection = false;
            this.listOptions.Location = new System.Drawing.Point(9, 284);
            this.listOptions.Name = "listOptions";
            this.listOptions.Size = new System.Drawing.Size(579, 291);
            this.listOptions.TabIndex = 21;
            this.listOptions.UseCompatibleStateImageBehavior = false;
            this.listOptions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Cod.";
            this.columnHeader9.Width = 40;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Tam(bytes)";
            this.columnHeader10.Width = 85;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Descrição";
            this.columnHeader12.Width = 250;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Dados";
            this.columnHeader13.Width = 300;
            // 
            // window_size
            // 
            this.window_size.Location = new System.Drawing.Point(346, 36);
            this.window_size.Name = "window_size";
            this.window_size.ReadOnly = true;
            this.window_size.Size = new System.Drawing.Size(100, 23);
            this.window_size.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tamanho da janela";
            // 
            // urgentPointer
            // 
            this.urgentPointer.Location = new System.Drawing.Point(359, 202);
            this.urgentPointer.Name = "urgentPointer";
            this.urgentPointer.ReadOnly = true;
            this.urgentPointer.Size = new System.Drawing.Size(107, 23);
            this.urgentPointer.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(218, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(240, 34);
            this.label10.TabIndex = 17;
            this.label10.Text = "Ponteiro de urgência\r\n(Considerado se URG estiver ligado)";
            // 
            // checksum
            // 
            this.checksum.Location = new System.Drawing.Point(85, 204);
            this.checksum.Name = "checksum";
            this.checksum.ReadOnly = true;
            this.checksum.Size = new System.Drawing.Size(107, 23);
            this.checksum.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Checksum";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.reservedBits);
            this.groupBox3.Location = new System.Drawing.Point(325, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(133, 59);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bits Reservados";
            // 
            // reservedBits
            // 
            this.reservedBits.AutoSize = true;
            this.reservedBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservedBits.Location = new System.Drawing.Point(31, 19);
            this.reservedBits.Name = "reservedBits";
            this.reservedBits.Size = new System.Drawing.Size(73, 31);
            this.reservedBits.TabIndex = 0;
            this.reservedBits.Text = "0 0 0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flags_checks);
            this.groupBox2.Location = new System.Drawing.Point(479, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(109, 194);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flags";
            // 
            // flags_checks
            // 
            this.flags_checks.Enabled = false;
            this.flags_checks.FormattingEnabled = true;
            this.flags_checks.Items.AddRange(new object[] {
            "NS",
            "CWR",
            "ECE",
            "URG",
            "ACK",
            "PSH",
            "RST",
            "SYN",
            "FIN"});
            this.flags_checks.Location = new System.Drawing.Point(20, 22);
            this.flags_checks.Name = "flags_checks";
            this.flags_checks.Size = new System.Drawing.Size(77, 166);
            this.flags_checks.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "bytes)";
            // 
            // tcpheader_size
            // 
            this.tcpheader_size.Location = new System.Drawing.Point(324, 168);
            this.tcpheader_size.Name = "tcpheader_size";
            this.tcpheader_size.ReadOnly = true;
            this.tcpheader_size.Size = new System.Drawing.Size(66, 23);
            this.tcpheader_size.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "(Cabeçalho TCP possui tamanho";
            // 
            // offset
            // 
            this.offset.Location = new System.Drawing.Point(58, 167);
            this.offset.Name = "offset";
            this.offset.ReadOnly = true;
            this.offset.Size = new System.Drawing.Size(42, 23);
            this.offset.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Offset";
            // 
            // ack
            // 
            this.ack.Location = new System.Drawing.Point(214, 125);
            this.ack.Name = "ack";
            this.ack.ReadOnly = true;
            this.ack.Size = new System.Drawing.Size(100, 23);
            this.ack.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Número de Confirmação (ACK)";
            // 
            // seq
            // 
            this.seq.Location = new System.Drawing.Point(214, 96);
            this.seq.Name = "seq";
            this.seq.ReadOnly = true;
            this.seq.Size = new System.Drawing.Size(100, 23);
            this.seq.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Número de Sequência (SEQ)";
            // 
            // dest_port
            // 
            this.dest_port.Location = new System.Drawing.Point(104, 64);
            this.dest_port.Name = "dest_port";
            this.dest_port.ReadOnly = true;
            this.dest_port.Size = new System.Drawing.Size(100, 23);
            this.dest_port.TabIndex = 3;
            // 
            // src_port
            // 
            this.src_port.Location = new System.Drawing.Point(104, 37);
            this.src_port.Name = "src_port";
            this.src_port.ReadOnly = true;
            this.src_port.Size = new System.Drawing.Size(100, 23);
            this.src_port.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Porta Destino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Porta Origem";
            // 
            // charTextBox
            // 
            this.charTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charTextBox.Location = new System.Drawing.Point(521, 362);
            this.charTextBox.Name = "charTextBox";
            this.charTextBox.OtherRichTextBox = null;
            this.charTextBox.ReadOnly = true;
            this.charTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.charTextBox.Size = new System.Drawing.Size(308, 199);
            this.charTextBox.TabIndex = 9;
            this.charTextBox.Text = "";
            // 
            // hexTextBox
            // 
            this.hexTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexTextBox.Location = new System.Drawing.Point(4, 362);
            this.hexTextBox.Name = "hexTextBox";
            this.hexTextBox.OtherRichTextBox = null;
            this.hexTextBox.ReadOnly = true;
            this.hexTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.hexTextBox.Size = new System.Drawing.Size(521, 199);
            this.hexTextBox.TabIndex = 8;
            this.hexTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 596);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.allButton);
            this.Controls.Add(this.charTextBox);
            this.Controls.Add(this.hexTextBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.hintLabel);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.filterCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hearen\'s SimpleSniffer v2";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrom_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.CheckBox filterCheckBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Label hintLabel;
        private MyButton clearButton;
        private System.Windows.Forms.BindingSource packetBindingSource;
        private System.Windows.Forms.ListView listView;
        private ColumnHeader header;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ComboBox typeComboBox;
        private MyRichTextBox hexTextBox;
        private MyRichTextBox charTextBox;
        private Button allButton;
        private Button filterButton;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
        private GroupBox groupBox1;
        private Label reservedBits;
        private TextBox tcpheader_size;
        private Label label7;
        private TextBox offset;
        private Label label6;
        private TextBox ack;
        private Label label5;
        private TextBox seq;
        private Label label4;
        private TextBox dest_port;
        private TextBox src_port;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private CheckedListBox flags_checks;
        private Label label8;
        private TextBox urgentPointer;
        private Label label10;
        private TextBox checksum;
        private Label label9;
        private GroupBox groupBox3;
        private TextBox window_size;
        private Label label1;
        private ListView listOptions;
        public ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private Label label11;
    }
}