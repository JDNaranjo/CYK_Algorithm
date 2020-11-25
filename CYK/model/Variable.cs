using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYK.model
{
    class Variable
    {
        private String name;
        private List<Production> productions;

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is to allow the instances creation for this class
        * @param {String} name The name of the variable that is being created
        */
        public Variable(String name) {
            this.name = name;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is the getter method for the name of the variable
        * @returns {String} String belong to the terminal variable
        */
        public String getName()
        {
            return name;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is to set another value for the variable name
        * <b>pre:</b> The input name needs to be != null
        * @param {String} name The name you want to assign for the actual variable
        * @returns The method is void, so it does not have return
        */
        public void setName(String name)
        {
            this.name = name;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is the getter method for the productions associated to the variable
        * @returns {List<Productions>} List of productions associated with the variable
        */
        public List<Production> getProductions()
        {
            return productions;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is to set another value for the productions associated to the variable
        * <b>pre:</b> The input name needs to be != null
        * @param {List<Productions>} productions List of productions that you want to assign to the variable
        * @returns The method is void, so it does not have return
        */
        public void setProductions(List<Production> productions)
        {
            this.productions = productions;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is to add another value for the productions associated to the variable
        * <b>pre:</b> The input name needs to be != null
        * @param {Production} newProduction Production you want to add to the ist of productions associated with the variable
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
    }
}
