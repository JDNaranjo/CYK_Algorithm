using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYK.model
{
    class Gramatic
    {
        private List<Variable> variables;
        private List<Terminal> terminals;
        private List<Production> productions;

        HashSet<String>[,] x;

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is to allow the instances creation for this class
        */
        public Gramatic() {
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is the getter method for the variables of the gramatic
        * @returns {List<Variables>} List of variables that the gramatic has
        */
        public List<Variable> getVariables()
        {
            return variables;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is to set another value for the variables of the gramatic
        * <b>pre:</b> The input variables needs to be != null
        * @param {List<Variables>} variables List of variables that you want to be the new variables
        * @returns The method is void, so it does not have return
        */
        public void setVariables(List<Variable> variables)
        {
            this.variables = variables;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is the getter method for the terminals of the gramatic
        * @returns {List<Terminals>} List of terminals that are involved in the gramatic productions
        */
        public List<Terminal> getTerminals()
        {
            return terminals;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is to set another value for the terminals of the gramatic
        * <b>pre:</b> The input name needs to be != null
        * @param {List<Terminals>} terminals List of terminals that you want to assign to the variables of the gramatic
        * @returns The method is void, so it does not have return
        */
        public void setTerminals(List<Terminal> terminals)
        {
            this.terminals = terminals;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is the getter method for the productions of the gramatic
        * @returns {List<Productions>} List of productions associated with the variables of the gramatic
        */
        public List<Production> getProductions()
        {
            return productions;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is to set another value for the productions of the gramatic
        * <b>pre:</b> The input name needs to be != null
        * @param {List<Productions>} productions List of productions that you want to assign to the gramatic
        * @returns The method is void, so it does not have return
        */
        public void setProductions(List<Production> productions)
        {
            this.productions = productions;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is to add another value to the productions of the gramatic
        * <b>pre:</b> The input name needs to be != null
        * @param {Production} newProduction Production you want to add to the ist of productions of the gramatic
        * @returns The method is void, so it does not have return
        */
        public void addProduction(Production newProduction)
        {
            if (productions == null)
            {
                productions = new List<Production>();
            }
            productions.Add(newProduction);
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is to add another value to the terminals of the gramatic
        * <b>pre:</b> The input name needs to be != null
        * @param {Terminal} newTerminal Terminal you want to add to the list of terminals of the gramatic
        * @returns The method is void, so it does not have return
        */
        public void addTerminal(Terminal newTerminal)
        {
            if (terminals == null)
            {
                terminals = new List<Terminal>();
            }
            terminals.Add(newTerminal);
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is to add another value to the variables of the gramatic
        * <b>pre:</b> The input name needs to be != null
        * @param {Variable} newVariable Variable you want to add to the list of variables of the gramatic
        * @returns The method is void, so it does not have return
        */
        public void addVariable(Variable newVariable)
        {
            if (variables == null)
            {
                variables = new List<Variable>();
            }
            variables.Add(newVariable);
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is to validate if the input string is accepted by the gramatic
        * <b>pre:</b> The gramatic needs to be created at 100%
        * @param {String} w The string you want to check if is accepted by the gramatic
        * @returns {Boolean} The boolean indicate if the string is accepted or not
        */
        internal Boolean cykAlgorithm(String w)
        {
            Boolean confirmation = false;
            int n = w.Length;
            Console.WriteLine(n);
            x = new HashSet<String>[n,n];

            if (n == 0)
            {
                foreach (Production p in variables.First().getProductions())
                {
                    if (p.getProduction().Equals(""))
                    {
                        confirmation = true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    x[i, 0] = new HashSet<String>();
                    isOrNot(Convert.ToString(w.ElementAt(i)), i, 0);
                }
                for (int j = 1; j < n; j++)
                {
                    for (int i = 0; i < n - j; i++)
                    {
                        x[i, j] = new HashSet<String>();
                        for (int k = 0; k <= j - 1; k++)
                        {
                            HashSet<String> set1 = x[i, k];
                            HashSet<String> set2 = x[i + k + 1, j - k - 1];
                            String[] prods = cartesianProduct(set1, set2);
                            foreach (String body in prods)
                            {
                                isOrNot(body, i, j);
                            }
                        }
                    }
                }
                if (x[0, n - 1].Contains(productions.First().getVariable().getName()))
                {
                    confirmation = true;
                }
            }
            return confirmation;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is to validate if a short string is accepted by the gramatic
        * <b>pre:</b> The gramatic needs to be created at 100%
        * @param {String} w The string you want to check if is accepted by the gramatic
        * @returns {Boolean} The boolean indicate if the string is accepted or not
        */
        public void isOrNot(String w, int i, int j)
        {
            foreach (Variable head in variables)
            {
                foreach (Production body in head.getProductions())
                {
                    if (body.getProduction().Equals(w))
                    {
                        x[i,j].Add(head.getName());
                    }
                }
            }
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is to do the cartesian product between two set of String
        * <b>pre:</b> The gramatic needs to be created at 100%
        * @param {String} w The string you want to check if is accepted by the gramatic
        * @returns {Boolean} The boolean indicate if the string is accepted or not
        */
        private String[] cartesianProduct(HashSet<String> set1, HashSet<String> set2)
        {
            String[] cartesianProductResult = new String[set1.Count * set2.Count];
            int i = 0;
            foreach (String element1 in set1)
            {
                foreach (String element2 in set2)
                {
                    cartesianProductResult[i] = element1 + element2;
                    i++;
                }
            }
            return cartesianProductResult;
        }

    }
}
