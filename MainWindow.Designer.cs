namespace Practice
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            GraphBox = new PictureBox();
            FuncSelectBox = new ComboBox();
            label1 = new Label();
            startRange = new NumericUpDown();
            endRange = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            GradusItem = new RadioButton();
            RadianItem = new RadioButton();
            DoGraphButton = new Button();
            SaveButton = new Button();
            InfoButton = new Button();
            ((System.ComponentModel.ISupportInitialize)GraphBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)startRange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)endRange).BeginInit();
            SuspendLayout();
            // 
            // GraphBox
            // 
            GraphBox.Location = new Point(150, 100);
            GraphBox.Name = "GraphBox";
            GraphBox.Size = new Size(840, 430);
            GraphBox.TabIndex = 0;
            GraphBox.TabStop = false;
            // 
            // FuncSelectBox
            // 
            FuncSelectBox.Items.AddRange(new object[] { "Синус (sin)", "Косинус (cos)", "Тангенс (tg)", "Котангенс (ctg)" });
            FuncSelectBox.Location = new Point(182, 17);
            FuncSelectBox.Name = "FuncSelectBox";
            FuncSelectBox.Size = new Size(151, 28);
            FuncSelectBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 20);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 2;
            label1.Text = "Выберите функцию:";
            // 
            // startRange
            // 
            startRange.Location = new Point(12, 123);
            startRange.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            startRange.Name = "startRange";
            startRange.Size = new Size(54, 27);
            startRange.TabIndex = 3;
            startRange.Value = new decimal(new int[] { 5, 0, 0, int.MinValue });
            // 
            // endRange
            // 
            endRange.Location = new Point(72, 123);
            endRange.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            endRange.Name = "endRange";
            endRange.Size = new Size(54, 27);
            endRange.TabIndex = 4;
            endRange.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 100);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 5;
            label2.Text = "Интервал:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 163);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 6;
            label3.Text = "Задан в:";
            // 
            // GradusItem
            // 
            GradusItem.AutoSize = true;
            GradusItem.Location = new Point(12, 216);
            GradusItem.Name = "GradusItem";
            GradusItem.Size = new Size(90, 24);
            GradusItem.TabIndex = 7;
            GradusItem.Text = "градусах";
            GradusItem.UseVisualStyleBackColor = true;
            GradusItem.CheckedChanged += GradusItem_CheckedChanged;
            // 
            // RadianItem
            // 
            RadianItem.AutoSize = true;
            RadianItem.Checked = true;
            RadianItem.Location = new Point(12, 186);
            RadianItem.Name = "RadianItem";
            RadianItem.Size = new Size(96, 24);
            RadianItem.TabIndex = 8;
            RadianItem.TabStop = true;
            RadianItem.Text = "радианах";
            RadianItem.UseVisualStyleBackColor = true;
            // 
            // DoGraphButton
            // 
            DoGraphButton.Location = new Point(12, 262);
            DoGraphButton.Name = "DoGraphButton";
            DoGraphButton.Size = new Size(96, 57);
            DoGraphButton.TabIndex = 9;
            DoGraphButton.Text = "Построить график";
            DoGraphButton.UseVisualStyleBackColor = true;
            DoGraphButton.Click += DoGraphButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(12, 351);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(96, 57);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Сохранить график";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // InfoButton
            // 
            InfoButton.Location = new Point(369, 16);
            InfoButton.Name = "InfoButton";
            InfoButton.Size = new Size(117, 29);
            InfoButton.TabIndex = 11;
            InfoButton.Text = "О функции...";
            InfoButton.UseVisualStyleBackColor = true;
            InfoButton.Click += InfoButton_Click;
            // 
            // MainWindow
            // 
            ClientSize = new Size(1082, 653);
            Controls.Add(InfoButton);
            Controls.Add(SaveButton);
            Controls.Add(DoGraphButton);
            Controls.Add(RadianItem);
            Controls.Add(GradusItem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(endRange);
            Controls.Add(startRange);
            Controls.Add(label1);
            Controls.Add(FuncSelectBox);
            Controls.Add(GraphBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainWindow";
            Text = "Тригонометрические функции";
            Load += MainWindow_Load;
            ((System.ComponentModel.ISupportInitialize)GraphBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)startRange).EndInit();
            ((System.ComponentModel.ISupportInitialize)endRange).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox GraphBox;
        private ComboBox FuncSelectBox;
        private Label label1;
        private NumericUpDown startRange;
        private NumericUpDown endRange;
        private Label label2;
        private Label label3;
        private RadioButton GradusItem;
        private RadioButton RadianItem;
        private Button DoGraphButton;
        private Button SaveButton;
        private Button InfoButton;
    }
}
