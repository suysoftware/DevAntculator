using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuzzyLogicController;
using FuzzyLogicController.RuleEngine;

namespace TezAPPV2.Model
{
    public partial class RuleItemUI : UserControl
    {
        private LingVariable _currentBMI;
        private LingVariable _current;

        private RuleItem _item;
       
        private RuleItem _itemBMI;
        public RuleItemUI(String var, InOutType Type)
        {
            this.Name = var;
            InitializeComponent();


            if (Type == InOutType.In) { _current = FuzzyLogic.getVariablebyName(FuzzyLogic.InputVariables, var); }
            else { _current = FuzzyLogic.getVariablebyName(FuzzyLogic.OutputVariables, var); }

            VarText.Text = _current.Name;
            this.Name = var;
            MFCombo.DataSource = _current.MFs;
            MFCombo.ValueMember = "Name";
            MFCombo.DisplayMember = "Name";
            MFCombo.SelectedValue = ((FuzzyLogicController.MFs.MemberShipFunction)MFCombo.Items[0]).Name;

            _item = new RuleItem(_current.Name, (String)MFCombo.SelectedValue);


            //BMI
            if (Type == InOutType.In) { _currentBMI = FuzzyLogic.getVariablebyName(FuzzyLogic.InputVariablesBMI, var); }
            else { _currentBMI = FuzzyLogic.getVariablebyName(FuzzyLogic.OutputVariablesBMI, var); }

            VarTextBMI.Text = _currentBMI.Name;
            this.Name = var;
            MFComboBMI.DataSource = _currentBMI.MFs;
            MFComboBMI.ValueMember = "Name";
            MFComboBMI.DisplayMember = "Name";
            MFComboBMI.SelectedValue = ((FuzzyLogicController.MFs.MemberShipFunction)MFComboBMI.Items[0]).Name;

            _itemBMI = new RuleItem(_currentBMI.Name, (String)MFComboBMI.SelectedValue);

        }




        public RuleItem RuleItem
        {
            get
            {
                _item = new RuleItem(VarText.Text, (String)MFCombo.SelectedValue);
                return _item;
            }
        }
        public RuleItem RuleItemBMI
        {
            get
            {
                _itemBMI = new RuleItem(VarTextBMI.Text, (String)MFComboBMI.SelectedValue);
                return _itemBMI;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }


    public enum InOutType
    {
        In = 0, Out = 1
    }
}



