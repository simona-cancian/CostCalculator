namespace CostCalculator
{
    partial class CostCalculator
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
            btnCalculate = new Button();
            lblFerry = new Label();
            txtFerry = new TextBox();
            lblFlight = new Label();
            txtFlight = new TextBox();
            lblFuel = new Label();
            txtFuel = new TextBox();
            labelResult = new Label();
            groupBoxTransportation = new GroupBox();
            labelDatePicker = new Label();
            labelTitle = new Label();
            groupBoxFood = new GroupBox();
            txtTravelExpenses = new TextBox();
            lblTravelExpenses = new Label();
            txtGroceries = new TextBox();
            lblGroceries = new Label();
            monthCalendar1 = new MonthCalendar();
            lblSavings = new Label();
            txtSavings = new TextBox();
            progressBar1 = new ProgressBar();
            lblExtras = new Label();
            txtExtras = new TextBox();
            groupBoxTransportation.SuspendLayout();
            groupBoxFood.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(546, 309);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblFerry
            // 
            lblFerry.AutoSize = true;
            lblFerry.Location = new Point(34, 36);
            lblFerry.Name = "lblFerry";
            lblFerry.Size = new Size(33, 15);
            lblFerry.TabIndex = 2;
            lblFerry.Text = "Ferry";
            // 
            // txtFerry
            // 
            txtFerry.Location = new Point(171, 36);
            txtFerry.Name = "txtFerry";
            txtFerry.Size = new Size(100, 23);
            txtFerry.TabIndex = 3;
            txtFerry.Text = "";
            // 
            // lblFlight
            // 
            lblFlight.AutoSize = true;
            lblFlight.Location = new Point(34, 72);
            lblFlight.Name = "lblFlight";
            lblFlight.Size = new Size(37, 15);
            lblFlight.TabIndex = 4;
            lblFlight.Text = "Flight";
            // 
            // txtFlight
            // 
            txtFlight.Location = new Point(171, 69);
            txtFlight.Name = "txtFlight";
            txtFlight.Size = new Size(100, 23);
            txtFlight.TabIndex = 5;
            txtFlight.Text = "";
            // 
            // lblFuel
            // 
            lblFuel.AutoSize = true;
            lblFuel.Location = new Point(34, 112);
            lblFuel.Name = "lblFuel";
            lblFuel.Size = new Size(29, 15);
            lblFuel.TabIndex = 6;
            lblFuel.Text = "Fuel";
            // 
            // txtFuel
            // 
            txtFuel.Location = new Point(171, 104);
            txtFuel.Name = "txtFuel";
            txtFuel.Size = new Size(100, 23);
            txtFuel.TabIndex = 7;
            txtFuel.Text = "";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(479, 352);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 15);
            labelResult.TabIndex = 8;
            // 
            // groupBoxTransportation
            // 
            groupBoxTransportation.Controls.Add(txtFerry);
            groupBoxTransportation.Controls.Add(lblFerry);
            groupBoxTransportation.Controls.Add(txtFuel);
            groupBoxTransportation.Controls.Add(lblFlight);
            groupBoxTransportation.Controls.Add(lblFuel);
            groupBoxTransportation.Controls.Add(txtFlight);
            groupBoxTransportation.Location = new Point(71, 75);
            groupBoxTransportation.Name = "groupBoxTransportation";
            groupBoxTransportation.Size = new Size(323, 153);
            groupBoxTransportation.TabIndex = 9;
            groupBoxTransportation.TabStop = false;
            groupBoxTransportation.Text = "Transportation";
            // 
            // labelDatePicker
            // 
            labelDatePicker.AutoSize = true;
            labelDatePicker.Location = new Point(205, 242);
            labelDatePicker.Name = "labelDatePicker";
            labelDatePicker.Size = new Size(43, 15);
            labelDatePicker.TabIndex = 10;
            labelDatePicker.Text = "When?";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(324, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(165, 30);
            labelTitle.TabIndex = 11;
            labelTitle.Text = "Travel Expenses";
            // 
            // groupBoxFood
            // 
            groupBoxFood.Controls.Add(txtExtras);
            groupBoxFood.Controls.Add(lblExtras);
            groupBoxFood.Controls.Add(txtTravelExpenses);
            groupBoxFood.Controls.Add(lblTravelExpenses);
            groupBoxFood.Controls.Add(txtGroceries);
            groupBoxFood.Controls.Add(lblGroceries);
            groupBoxFood.Location = new Point(449, 75);
            groupBoxFood.Name = "groupBoxFood";
            groupBoxFood.Size = new Size(282, 153);
            groupBoxFood.TabIndex = 12;
            groupBoxFood.TabStop = false;
            groupBoxFood.Text = "Food";
            // 
            // txtTravelExpenses
            // 
            txtTravelExpenses.Location = new Point(148, 69);
            txtTravelExpenses.Name = "txtTravelExpenses";
            txtTravelExpenses.Size = new Size(100, 23);
            txtTravelExpenses.TabIndex = 3;
            txtTravelExpenses.Text = "";
            // 
            // lblTravelExpenses
            // 
            lblTravelExpenses.AutoSize = true;
            lblTravelExpenses.Location = new Point(17, 72);
            lblTravelExpenses.Name = "lblTravelExpenses";
            lblTravelExpenses.Size = new Size(91, 15);
            lblTravelExpenses.TabIndex = 2;
            lblTravelExpenses.Text = "Travel Expenses ";
            // 
            // txtGroceries
            // 
            txtGroceries.Location = new Point(148, 36);
            txtGroceries.Name = "txtGroceries";
            txtGroceries.Size = new Size(100, 23);
            txtGroceries.TabIndex = 1;
            txtGroceries.Text = "";
            // 
            // lblGroceries
            // 
            lblGroceries.AutoSize = true;
            lblGroceries.Location = new Point(17, 36);
            lblGroceries.Name = "lblGroceries";
            lblGroceries.Size = new Size(56, 15);
            lblGroceries.TabIndex = 0;
            lblGroceries.Text = "Groceries";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(115, 257);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.ShowTodayCircle = false;
            monthCalendar1.TabIndex = 13;
            // 
            // lblSavings
            // 
            lblSavings.AutoSize = true;
            lblSavings.Location = new Point(466, 242);
            lblSavings.Name = "lblSavings";
            lblSavings.Size = new Size(76, 15);
            lblSavings.TabIndex = 14;
            lblSavings.Text = "Your savings:";
            // 
            // txtSavings
            // 
            txtSavings.Location = new Point(597, 239);
            txtSavings.Name = "txtSavings";
            txtSavings.Size = new Size(100, 23);
            txtSavings.TabIndex = 15;
            txtSavings.Text = "";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(466, 396);
            progressBar1.Maximum = 100000;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(277, 23);
            progressBar1.TabIndex = 16;
            // 
            // lblExtras
            // 
            lblExtras.AutoSize = true;
            lblExtras.Location = new Point(17, 112);
            lblExtras.Name = "lblExtras";
            lblExtras.Size = new Size(38, 15);
            lblExtras.TabIndex = 4;
            lblExtras.Text = "Extras";
            // 
            // txtExtras
            // 
            txtExtras.Location = new Point(148, 104);
            txtExtras.Name = "txtExtras";
            txtExtras.Size = new Size(100, 23);
            txtExtras.TabIndex = 5;
            // 
            // CostCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(txtSavings);
            Controls.Add(lblSavings);
            Controls.Add(monthCalendar1);
            Controls.Add(groupBoxFood);
            Controls.Add(labelTitle);
            Controls.Add(labelDatePicker);
            Controls.Add(groupBoxTransportation);
            Controls.Add(labelResult);
            Controls.Add(btnCalculate);
            ForeColor = SystemColors.ControlText;
            Name = "CostCalculator";
            Text = "CostCalculator";
            groupBoxTransportation.ResumeLayout(false);
            groupBoxTransportation.PerformLayout();
            groupBoxFood.ResumeLayout(false);
            groupBoxFood.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Label lblFerry;
        private TextBox txtFerry;
        private Label lblFlight;
        private TextBox txtFlight;
        private Label lblFuel;
        private TextBox txtFuel;
        private Label labelResult;
        private GroupBox groupBoxTransportation;
        private Label labelDatePicker;
        private Label labelTitle;
        private GroupBox groupBoxFood;
        private Label lblGroceries;
        private MonthCalendar monthCalendar1;
        private TextBox txtTravelExpenses;
        private Label lblTravelExpenses;
        private TextBox txtGroceries;
        private Label lblSavings;
        private TextBox txtSavings;
        private ProgressBar progressBar1;
        private Label lblExtras;
        private TextBox txtExtras;
    }
}
