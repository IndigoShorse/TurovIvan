namespace Курсовая_ТуровИВ_ИТб_213
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.inputDataTab = new System.Windows.Forms.TabPage();
            this.errorLabel2 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.splitGroups = new System.Windows.Forms.Button();
            this.allNamesBox = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputResultsTab = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericSecs = new System.Windows.Forms.NumericUpDown();
            this.showGroup3Button = new System.Windows.Forms.Button();
            this.winnersBox = new System.Windows.Forms.GroupBox();
            this.winnerCBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.winnerBBox = new System.Windows.Forms.TextBox();
            this.winnerABox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showGroup2Button = new System.Windows.Forms.Button();
            this.showGroup1Button = new System.Windows.Forms.Button();
            this.groupNameLabel = new System.Windows.Forms.Label();
            this.eNumberLabel = new System.Windows.Forms.Label();
            this.calcResultsButton = new System.Windows.Forms.Button();
            this.nextSportsman = new System.Windows.Forms.Button();
            this.numericMins = new System.Windows.Forms.NumericUpDown();
            this.sportsmanNameLabel = new System.Windows.Forms.Label();
            this.showAllButton = new System.Windows.Forms.Button();
            this.mainTabs.SuspendLayout();
            this.inputDataTab.SuspendLayout();
            this.inputResultsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSecs)).BeginInit();
            this.winnersBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMins)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabs
            // 
            this.mainTabs.Controls.Add(this.inputDataTab);
            this.mainTabs.Controls.Add(this.inputResultsTab);
            this.mainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabs.Location = new System.Drawing.Point(0, 0);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(800, 450);
            this.mainTabs.TabIndex = 0;
            // 
            // inputDataTab
            // 
            this.inputDataTab.Controls.Add(this.errorLabel2);
            this.inputDataTab.Controls.Add(this.errorLabel);
            this.inputDataTab.Controls.Add(this.splitGroups);
            this.inputDataTab.Controls.Add(this.allNamesBox);
            this.inputDataTab.Controls.Add(this.AddButton);
            this.inputDataTab.Controls.Add(this.nameBox);
            this.inputDataTab.Controls.Add(this.label1);
            this.inputDataTab.Location = new System.Drawing.Point(4, 22);
            this.inputDataTab.Name = "inputDataTab";
            this.inputDataTab.Padding = new System.Windows.Forms.Padding(3);
            this.inputDataTab.Size = new System.Drawing.Size(792, 424);
            this.inputDataTab.TabIndex = 0;
            this.inputDataTab.Text = "Ввод участников";
            this.inputDataTab.UseVisualStyleBackColor = true;
            // 
            // errorLabel2
            // 
            this.errorLabel2.AutoSize = true;
            this.errorLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel2.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel2.Location = new System.Drawing.Point(8, 318);
            this.errorLabel2.Name = "errorLabel2";
            this.errorLabel2.Size = new System.Drawing.Size(150, 13);
            this.errorLabel2.TabIndex = 9;
            this.errorLabel2.Text = "Невозможно распределить!";
            this.errorLabel2.Visible = false;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(8, 94);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(137, 13);
            this.errorLabel.TabIndex = 8;
            this.errorLabel.Text = "Такой участник уже есть!";
            this.errorLabel.Visible = false;
            // 
            // splitGroups
            // 
            this.splitGroups.Location = new System.Drawing.Point(11, 288);
            this.splitGroups.Name = "splitGroups";
            this.splitGroups.Size = new System.Drawing.Size(154, 27);
            this.splitGroups.TabIndex = 7;
            this.splitGroups.Text = "Распределить по группам";
            this.splitGroups.UseVisualStyleBackColor = true;
            this.splitGroups.Click += new System.EventHandler(this.splitGroups_Click);
            // 
            // allNamesBox
            // 
            this.allNamesBox.FormattingEnabled = true;
            this.allNamesBox.Location = new System.Drawing.Point(185, 25);
            this.allNamesBox.Name = "allNamesBox";
            this.allNamesBox.Size = new System.Drawing.Size(238, 290);
            this.allNamesBox.TabIndex = 6;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(8, 51);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(157, 40);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "В список";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(8, 25);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(157, 20);
            this.nameBox.TabIndex = 4;
            this.nameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите имя участника:";
            // 
            // inputResultsTab
            // 
            this.inputResultsTab.Controls.Add(this.showAllButton);
            this.inputResultsTab.Controls.Add(this.label6);
            this.inputResultsTab.Controls.Add(this.label5);
            this.inputResultsTab.Controls.Add(this.numericSecs);
            this.inputResultsTab.Controls.Add(this.showGroup3Button);
            this.inputResultsTab.Controls.Add(this.winnersBox);
            this.inputResultsTab.Controls.Add(this.showGroup2Button);
            this.inputResultsTab.Controls.Add(this.showGroup1Button);
            this.inputResultsTab.Controls.Add(this.groupNameLabel);
            this.inputResultsTab.Controls.Add(this.eNumberLabel);
            this.inputResultsTab.Controls.Add(this.calcResultsButton);
            this.inputResultsTab.Controls.Add(this.nextSportsman);
            this.inputResultsTab.Controls.Add(this.numericMins);
            this.inputResultsTab.Controls.Add(this.sportsmanNameLabel);
            this.inputResultsTab.Location = new System.Drawing.Point(4, 22);
            this.inputResultsTab.Name = "inputResultsTab";
            this.inputResultsTab.Padding = new System.Windows.Forms.Padding(3);
            this.inputResultsTab.Size = new System.Drawing.Size(792, 424);
            this.inputResultsTab.TabIndex = 1;
            this.inputResultsTab.Text = "Ввод результатов";
            this.inputResultsTab.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(467, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "сек";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "мин";
            // 
            // numericSecs
            // 
            this.numericSecs.Location = new System.Drawing.Point(445, 41);
            this.numericSecs.Name = "numericSecs";
            this.numericSecs.Size = new System.Drawing.Size(47, 20);
            this.numericSecs.TabIndex = 10;
            this.numericSecs.ValueChanged += new System.EventHandler(this.numericSecs_Changed);
            // 
            // showGroup3Button
            // 
            this.showGroup3Button.Enabled = false;
            this.showGroup3Button.Location = new System.Drawing.Point(341, 125);
            this.showGroup3Button.Name = "showGroup3Button";
            this.showGroup3Button.Size = new System.Drawing.Size(75, 66);
            this.showGroup3Button.TabIndex = 9;
            this.showGroup3Button.Text = "Результаты группы 3";
            this.showGroup3Button.UseVisualStyleBackColor = true;
            this.showGroup3Button.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // winnersBox
            // 
            this.winnersBox.Controls.Add(this.winnerCBox);
            this.winnersBox.Controls.Add(this.label4);
            this.winnersBox.Controls.Add(this.winnerBBox);
            this.winnersBox.Controls.Add(this.winnerABox);
            this.winnersBox.Controls.Add(this.label3);
            this.winnersBox.Controls.Add(this.label2);
            this.winnersBox.Location = new System.Drawing.Point(408, 212);
            this.winnersBox.Name = "winnersBox";
            this.winnersBox.Size = new System.Drawing.Size(317, 165);
            this.winnersBox.TabIndex = 8;
            this.winnersBox.TabStop = false;
            this.winnersBox.Text = "Победители";
            // 
            // winnerCBox
            // 
            this.winnerCBox.Location = new System.Drawing.Point(9, 110);
            this.winnerCBox.Name = "winnerCBox";
            this.winnerCBox.ReadOnly = true;
            this.winnerCBox.Size = new System.Drawing.Size(114, 20);
            this.winnerCBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Победитель группы В";
            // 
            // winnerBBox
            // 
            this.winnerBBox.Location = new System.Drawing.Point(9, 71);
            this.winnerBBox.Name = "winnerBBox";
            this.winnerBBox.ReadOnly = true;
            this.winnerBBox.Size = new System.Drawing.Size(114, 20);
            this.winnerBBox.TabIndex = 3;
            // 
            // winnerABox
            // 
            this.winnerABox.Location = new System.Drawing.Point(9, 32);
            this.winnerABox.Name = "winnerABox";
            this.winnerABox.ReadOnly = true;
            this.winnerABox.Size = new System.Drawing.Size(114, 20);
            this.winnerABox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Победитель группы Б";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Побежитель группы А";
            // 
            // showGroup2Button
            // 
            this.showGroup2Button.Enabled = false;
            this.showGroup2Button.Location = new System.Drawing.Point(260, 125);
            this.showGroup2Button.Name = "showGroup2Button";
            this.showGroup2Button.Size = new System.Drawing.Size(75, 66);
            this.showGroup2Button.TabIndex = 7;
            this.showGroup2Button.Text = "Результаты группы 2";
            this.showGroup2Button.UseVisualStyleBackColor = true;
            this.showGroup2Button.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // showGroup1Button
            // 
            this.showGroup1Button.Enabled = false;
            this.showGroup1Button.Location = new System.Drawing.Point(179, 125);
            this.showGroup1Button.Name = "showGroup1Button";
            this.showGroup1Button.Size = new System.Drawing.Size(75, 66);
            this.showGroup1Button.TabIndex = 6;
            this.showGroup1Button.Text = "Результаты группы 1";
            this.showGroup1Button.UseVisualStyleBackColor = true;
            this.showGroup1Button.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // groupNameLabel
            // 
            this.groupNameLabel.AutoSize = true;
            this.groupNameLabel.Location = new System.Drawing.Point(24, 22);
            this.groupNameLabel.Name = "groupNameLabel";
            this.groupNameLabel.Size = new System.Drawing.Size(52, 13);
            this.groupNameLabel.TabIndex = 5;
            this.groupNameLabel.Text = "Группа А";
            // 
            // eNumberLabel
            // 
            this.eNumberLabel.AutoSize = true;
            this.eNumberLabel.Location = new System.Drawing.Point(24, 74);
            this.eNumberLabel.Name = "eNumberLabel";
            this.eNumberLabel.Size = new System.Drawing.Size(42, 13);
            this.eNumberLabel.TabIndex = 4;
            this.eNumberLabel.Text = "Этап N";
            // 
            // calcResultsButton
            // 
            this.calcResultsButton.Enabled = false;
            this.calcResultsButton.Location = new System.Drawing.Point(59, 125);
            this.calcResultsButton.Name = "calcResultsButton";
            this.calcResultsButton.Size = new System.Drawing.Size(88, 66);
            this.calcResultsButton.TabIndex = 3;
            this.calcResultsButton.Text = "Выполнить расчеты";
            this.calcResultsButton.UseVisualStyleBackColor = true;
            this.calcResultsButton.Click += new System.EventHandler(this.calcResultsButton_Click);
            // 
            // nextSportsman
            // 
            this.nextSportsman.Location = new System.Drawing.Point(498, 41);
            this.nextSportsman.Name = "nextSportsman";
            this.nextSportsman.Size = new System.Drawing.Size(88, 23);
            this.nextSportsman.TabIndex = 2;
            this.nextSportsman.Text = "Следующий";
            this.nextSportsman.UseVisualStyleBackColor = true;
            this.nextSportsman.Click += new System.EventHandler(this.nextSportsman_Click);
            // 
            // numericMins
            // 
            this.numericMins.Location = new System.Drawing.Point(389, 41);
            this.numericMins.Name = "numericMins";
            this.numericMins.Size = new System.Drawing.Size(50, 20);
            this.numericMins.TabIndex = 1;
            // 
            // sportsmanNameLabel
            // 
            this.sportsmanNameLabel.AutoSize = true;
            this.sportsmanNameLabel.Location = new System.Drawing.Point(24, 51);
            this.sportsmanNameLabel.Name = "sportsmanNameLabel";
            this.sportsmanNameLabel.Size = new System.Drawing.Size(123, 13);
            this.sportsmanNameLabel.TabIndex = 0;
            this.sportsmanNameLabel.Text = "Имя гоночной машины";
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(139, 235);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(114, 48);
            this.showAllButton.TabIndex = 13;
            this.showAllButton.Text = "Результаты всех групп";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainTabs);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.mainTabs.ResumeLayout(false);
            this.inputDataTab.ResumeLayout(false);
            this.inputDataTab.PerformLayout();
            this.inputResultsTab.ResumeLayout(false);
            this.inputResultsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSecs)).EndInit();
            this.winnersBox.ResumeLayout(false);
            this.winnersBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMins)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.TabPage inputDataTab;
        private System.Windows.Forms.ListBox allNamesBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage inputResultsTab;
        private System.Windows.Forms.Button splitGroups;
        private System.Windows.Forms.Label sportsmanNameLabel;
        private System.Windows.Forms.Label eNumberLabel;
        private System.Windows.Forms.Button calcResultsButton;
        private System.Windows.Forms.Button nextSportsman;
        private System.Windows.Forms.NumericUpDown numericMins;
        private System.Windows.Forms.Label groupNameLabel;
        private System.Windows.Forms.Button showGroup2Button;
        private System.Windows.Forms.Button showGroup1Button;
        private System.Windows.Forms.GroupBox winnersBox;
        private System.Windows.Forms.TextBox winnerBBox;
        private System.Windows.Forms.TextBox winnerABox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox winnerCBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button showGroup3Button;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label errorLabel2;
        private System.Windows.Forms.NumericUpDown numericSecs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button showAllButton;
    }
}

