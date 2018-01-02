using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace ItemsAdder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ItemSelector_Click(object sender, EventArgs e)
        {
            if(ItemSelector.SelectedText !=null)
            {
                NameTextBox.Text = ItemSelector.Text;
                try
                {
                    foreach (XElement element in xmlDoc.Root.Element("BattleItems").Descendants())
                    {
                        if (ItemSelector.Text == element.Attribute("name").Value)
                        {
                            DescTextBox.Text = element.Attribute("description").Value;
                            QuantityTextBox.Text = element.Attribute("quantity").Value;
                            EffectValueTextBox.Text = element.Attribute("baseDmg").Value;
                            ItemIDTextBox.Text = element.Attribute("ItemID").Value;
                            switch (element.Attribute("type").Value)
                            {
                                case "Heal":
                                    TypeComboBox.SelectedItem = TypeComboBox.Items[0];
                                    break;
                                case "Damage":
                                    TypeComboBox.SelectedItem = TypeComboBox.Items[1];
                                    break;
                                case "Mana":
                                    TypeComboBox.SelectedItem = TypeComboBox.Items[2];
                                    break;
                                case "Buff":
                                    TypeComboBox.SelectedItem = TypeComboBox.Items[3];
                                    break;
                                case "Debuff":
                                    TypeComboBox.SelectedItem = TypeComboBox.Items[4];
                                    break;
                                default:
                                    TypeComboBox.SelectedItem = TypeComboBox.Items[1];
                                    break;
                            }

                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Nothing");
                }
            }
        }
        private void XmlAddButton_Click(object sender, EventArgs e)
        {
            if (xmlDoc != null)
            {
                try
                {
                    if (NameTextBox.Text !=""  && DescTextBox.Text != "" && QuantityTextBox.Text != "" && EffectValueTextBox.Text != "")
                    {
                        XElement newItem = new XElement("BattleItem");
                        newItem.Add(new XAttribute("name", NameTextBox.Text), new XAttribute("description", DescTextBox.TextAlign), new XAttribute("type", TypeComboBox.SelectedText), new XAttribute("baseDmg", EffectValueTextBox.Text), new XAttribute("quantity", QuantityTextBox.Text), new XAttribute("ItemID",ItemIDTextBox.Text));
                        xmlDoc.Root.Element("BattleItems").Add(newItem);
                        xmlDoc.Save(DocPath);
                        ItemSelector.Items.Add(newItem.Attribute("name").Value);
                        Console.WriteLine("Item added succesful");
                        MessageBox.Show("Item added succesful");
                    }
                    else
                    {
                        Console.WriteLine("Not all of required values are filled");
                        MessageBox.Show("Not all of required values are filled");
                    }
                }
                catch
                {
                    Console.WriteLine("Smutek");
                    MessageBox.Show("Smutek");
                }
            }
            else
            {
                Console.WriteLine("XML file not loaded");
            }

           
        }

    }
}
