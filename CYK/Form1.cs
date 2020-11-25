using CYK.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CYK
{
    public partial class Form1 : Form
    {
        private Gramatic cyk;

        public Form1()
        {
            InitializeComponent();
            cyk = new Gramatic();
            variableLbl.Visible = false;
            terminalLbl.Visible = false;
            productionLbl.Visible = false;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method validate when the variable needs to be added and when the variable doesn't have to be
        * added, and also it throws a message in the screen
        * <b>pre:</b> The input can't be empty
        * @param
        * @param
        * @return The method is void, so it does not have return
        */
        private void variablesBtn_Click(object sender, EventArgs e)
        {
            terminalLbl.Visible = false;
            productionLbl.Visible = false;
            if (variablesTxt.Text.Equals("")) {
                variableLbl.Text = "The variable name can't be empty";
                variableLbl.Visible = true;
            }
            else {
                string name = variablesTxt.Text;
                Variable newVariable = new Variable(name);
                List<Variable> variablesList = cyk.getVariables();

                if (variablesList != null)
                {
                    if (variablesList.Contains(newVariable))
                    {
                        variableLbl.Text = "This variable is already in the gramatic";
                        variableLbl.Visible = true;
                    }
                    else
                    {
                        addingVariable(newVariable);
                    }
                }
                else
                {
                    addingVariable(newVariable);
                }
            }
            
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method add every variable to the gramatic and throws a message in the screen
        * @param {Variable} newVariable The variable that will be added to the gramatic
        * @return The method is void, so it does not have return
        */
        private void addingVariable(Variable newVariable)
        {
            cyk.addVariable(newVariable);
            variableBox.Items.Add(newVariable.getName());
            productionsBox.Items.Add(newVariable.getName());
            variableLbl.Text = "The variable has been added succesfully";
            variableLbl.Visible = true;
            variablesTxt.Text = "";
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method validate when the terminal needs to be added and when the terminal doesn't have to be
        * added, and also it throws a message in the screen
        * <b>pre:</b> The input can't be empty
        * @param
        * @param
        * @return The method is void, so it does not have return
        */
        private void terminalsBtn_Click(object sender, EventArgs e)
        {
            variableLbl.Visible = false;
            productionLbl.Visible = false;
                string name = terminalsTxt.Text;
                Terminal newTerminal = new Terminal(name);
                List<Terminal> terminalsList = cyk.getTerminals();

                if (terminalsList != null)
                {
                    if (terminalsList.Contains(newTerminal))
                    {
                        terminalLbl.Text = "This terminal is already in the alphabet";
                        terminalLbl.Visible = true;
                    }
                    else
                    {
                        addingTerminal(newTerminal);
                    }
                }
                else
                {
                    addingTerminal(newTerminal);
                }

        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method add every terminal to the gramatic and throws a message in the screen
        * @param {Variable} newVariable The variable that will be added to the gramatic
        * @return The method is void, so it does not have return
        */
        private void addingTerminal(Terminal newTerminal)
        {
            cyk.addTerminal(newTerminal);
            productionsBox.Items.Add(newTerminal.getName());
            terminalLbl.Text = "The terminal has been added succesfully";
            terminalLbl.Visible = true;
            terminalsTxt.Text = "";
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method add all the symbols to the text box of the productions
        * <b>pre:</b> The input can't be empty
        * @param
        * @param
        * @return The method is void, so it does not have return
        */
        private void symbolsBtn_Click(object sender, EventArgs e)
        {
            string symbol = productionsBox.SelectedItem.ToString();
            productionsTxt.Text = productionsTxt.Text + symbol;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method validate when the production needs to be added and when the production doesn't have to be
        * added, and also it throws a message in the screen
        * <b>pre:</b> The input can't be empty
        * @param
        * @param
        * @return The method is void, so it does not have return
        */
        private void productionBtn_Click(object sender, EventArgs e)
        {
            variableLbl.Visible = false;
            terminalLbl.Visible = false;
                Variable pVariable = new Variable(variableBox.SelectedItem.ToString());

                List<Variable> variables = cyk.getVariables();

                foreach (Variable variable in variables)
                {
                    if (variable.getName().Equals(variableBox.SelectedItem.ToString()))
                    {
                        pVariable = variable;
                    }
                }

                string productionString = productionsTxt.Text;
                Production newProduction = new Production(pVariable, productionString);
                List<Production> productionsList = cyk.getProductions();

                if (productionsList != null)
                {
                    if (productionsList.Contains(newProduction))
                    {
                        terminalLbl.Text = "This production is already in the alphabet";
                        terminalLbl.Visible = true;
                    }
                    else
                    {
                        addingProduction(pVariable, newProduction);
                    }
                }
                else
                {
                    addingProduction(pVariable, newProduction);
                }
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method add every terminal to the gramatic and throws a message in the screen
        * @param {Variable} newVariable The variable that will be added to the gramatic
        * @return The method is void, so it does not have return
        */
        private void addingProduction(Variable variable, Production newProduction)
        {
            cyk.addProduction(newProduction);
            variable.addProduction(newProduction);
            productionLbl.Text = "The production has been added succesfully";
            productionLbl.Visible = true;
            productionsTxt.Text = "";
        }


        private void createGramaticBtn_Click(object sender, EventArgs e)
        {
            if (cyk.getProductions() != null)
            {
                gramaticBox.Enabled = false;
            }
            else {
                System.Windows.Forms.MessageBox.Show("The gramatic can't be created without productions");
            }
        }

        private void stringBtn_Click(object sender, EventArgs e)
        {
            string w = stringTxt.Text;

            Boolean yesOrNot = cyk.cykAlgorithm(w);

            if (yesOrNot)
            {
                outputLbl.Text = "La cadena pertenece a la gramatica";
            }
            else
            {
                outputLbl.Text = "La cadena no pertenece a la gramatica";
            }
            outputLbl.Visible = true;
        }
    }
}
