using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ItemsAdder
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DescTextBox = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.EffectValueTextBox = new System.Windows.Forms.TextBox();
            this.ItemIDTextBox = new System.Windows.Forms.TextBox();
            this.XMLOpenButton = new System.Windows.Forms.Button();
            this.ItemSelector = new System.Windows.Forms.ComboBox();
            this.XmlAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Base effect value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Item ID";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Heal",
            "Damage",
            "Mana",
            "Buff",
            "Debuff"});
            this.TypeComboBox.Location = new System.Drawing.Point(143, 158);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(177, 21);
            this.TypeComboBox.TabIndex = 6;
            this.TypeComboBox.Text = "Damage";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(143, 99);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(399, 20);
            this.NameTextBox.TabIndex = 7;
            // 
            // DescTextBox
            // 
            this.DescTextBox.Location = new System.Drawing.Point(143, 127);
            this.DescTextBox.Name = "DescTextBox";
            this.DescTextBox.Size = new System.Drawing.Size(399, 20);
            this.DescTextBox.TabIndex = 8;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(143, 188);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(40, 20);
            this.QuantityTextBox.TabIndex = 9;
            // 
            // EffectValueTextBox
            // 
            this.EffectValueTextBox.Location = new System.Drawing.Point(143, 219);
            this.EffectValueTextBox.Name = "EffectValueTextBox";
            this.EffectValueTextBox.Size = new System.Drawing.Size(40, 20);
            this.EffectValueTextBox.TabIndex = 10;
            // 
            // ItemIDTextBox
            // 
            this.ItemIDTextBox.Location = new System.Drawing.Point(143, 250);
            this.ItemIDTextBox.Name = "ItemIDTextBox";
            this.ItemIDTextBox.ReadOnly = true;
            this.ItemIDTextBox.Size = new System.Drawing.Size(40, 20);
            this.ItemIDTextBox.TabIndex = 11;
            // 
            // XMLOpenButton
            // 
            this.XMLOpenButton.Location = new System.Drawing.Point(42, 41);
            this.XMLOpenButton.Name = "XMLOpenButton";
            this.XMLOpenButton.Size = new System.Drawing.Size(75, 23);
            this.XMLOpenButton.TabIndex = 12;
            this.XMLOpenButton.Text = "Select XML";
            this.XMLOpenButton.UseVisualStyleBackColor = true;
            this.XMLOpenButton.Click += new System.EventHandler(this.XMLOpenButton_Click);
            // 
            // ItemSelector
            // 
            this.ItemSelector.FormattingEnabled = true;
            this.ItemSelector.Location = new System.Drawing.Point(42, 71);
            this.ItemSelector.Name = "ItemSelector";
            this.ItemSelector.Size = new System.Drawing.Size(278, 21);
            this.ItemSelector.TabIndex = 13;
            this.ItemSelector.TextChanged += new System.EventHandler(this.ItemSelector_Click);
            this.ItemSelector.Click += new System.EventHandler(this.ItemSelector_Click);
            // 
            // XmlAddButton
            // 
            this.XmlAddButton.Location = new System.Drawing.Point(42, 347);
            this.XmlAddButton.Name = "XmlAddButton";
            this.XmlAddButton.Size = new System.Drawing.Size(75, 23);
            this.XmlAddButton.TabIndex = 14;
            this.XmlAddButton.Text = "Add";
            this.XmlAddButton.UseVisualStyleBackColor = true;
            this.XmlAddButton.Click += new System.EventHandler(this.XmlAddButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 594);
            this.Controls.Add(this.XmlAddButton);
            this.Controls.Add(this.ItemSelector);
            this.Controls.Add(this.XMLOpenButton);
            this.Controls.Add(this.ItemIDTextBox);
            this.Controls.Add(this.EffectValueTextBox);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.DescTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ItemAdder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox DescTextBox;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.TextBox EffectValueTextBox;
        private System.Windows.Forms.TextBox ItemIDTextBox;
        private System.Windows.Forms.Button XMLOpenButton;
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();
        private XDocument xmlDoc = new XDocument();
        private string DocPath;

        public void XMLOpenButton_Click(object Sender, EventArgs e)
        {

            openFileDialog1.Filter = "XML files| *.xml";
            int size = -1;

            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                



                try
                {
                    ItemSelector.Items.Clear();
                    XDocument xmlDoc1 = XDocument.Load(openFileDialog1.OpenFile());
                    DocPath = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                    foreach(XElement item in xmlDoc1.Root.Element("BattleItems").Descendants())
                    {

                        ItemSelector.Items.Add(item.Attribute("name").Value);
                    }

                    
                    
                    
                    string text = File.ReadAllText(file);
                    size = text.Length;
                    xmlDoc = xmlDoc1;
                    ItemIDTextBox.Text = (xmlDoc.Root.Element("BattleItems").Descendants().Count() + 1).ToString();
               
                }
                catch (IOException)
                {

                }

            }




            Console.WriteLine(size);
            Console.WriteLine(result);
                        


        }

        private ComboBox ItemSelector;
        private Button XmlAddButton;
    }

   
}

