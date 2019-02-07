using MChooser.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MChooser.UI
{
    public partial class MoreInformationWindow : Form
    {
        private List<MechModel> MoreInformationMechs;
        private static string SELECTION_STRING = "-- Please select a chassis --";

        public MoreInformationWindow(List<MechModel> moreInformationMechs, string mechWeightDescription)
        {
            this.MoreInformationMechs = moreInformationMechs;
            InitializeComponent();
            this.weightLabel.Text = mechWeightDescription;
            chassisListBox.Items.Add(SELECTION_STRING);
            foreach (MechModel model in moreInformationMechs.GroupBy(m => m.MechModelName).Select(m => m.FirstOrDefault()).ToList())
            {
                chassisListBox.Items.Add(model.MechModelName);
            }
        }

        private void chassisListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = chassisListBox.SelectedItem.ToString();
            if (selection.Equals(SELECTION_STRING))
            {
                this.ClassText.Text = "";
                this.FactionText.Text = "";
                this.VariantsText.Text = "";
            }
            else
            {
                List<MechModel> selectedMech = MoreInformationMechs.Where(m => m.MechModelName.Equals(selection)).ToList();
                this.ClassText.Text = selectedMech[0].MechClass.ToString();
                this.FactionText.Text = selectedMech[0].MechFaction.ToString().Replace("_", " ");
                this.VariantsText.Text = BuildVariantString(selectedMech); 
            }
        }

        private string BuildVariantString(List<MechModel> selectedMech)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < selectedMech.Count; i++)
            {
                sb.Append(selectedMech[i].ModelVariantName);
                if ((i + 1) != selectedMech.Count)
                { sb.Append(", ");  }
            }
            return sb.ToString();
        }
    }
}
