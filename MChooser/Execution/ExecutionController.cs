using MChooser.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MChooser.Execution
{
    public class ExecutionController
    {
        SelectionForm SelectionForm;
        AddMechForm AddMechForm;
        MechCountForm MechCountForm;

        public ExecutionController()
        {
            this.SelectionForm = new SelectionForm(SwitchToAddMechWindow, SwitchToMechCountWindow);
            this.AddMechForm = new AddMechForm(SwitchToSelectionWindow, SwitchToMechCountWindow);
            this.MechCountForm = new MechCountForm(SwitchToSelectionWindow, SwitchToAddMechWindow);

            Application.Run(SelectionForm);
        }

        public void SwitchToAddMechWindow()
        {
            this.SelectionForm.Hide();
            this.MechCountForm.Hide();
            this.AddMechForm.Show();
        }

        public void SwitchToSelectionWindow()
        {
            this.SelectionForm.Show();
            this.AddMechForm.Hide();
            this.MechCountForm.Hide();
        }

        public void SwitchToMechCountWindow()
        {
            this.SelectionForm.Hide();
            this.AddMechForm.Hide();
            this.MechCountForm.Show();
        }
    }
}
