using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYK.model
{
    class Production
    {
        private Variable variable;
        private String production;

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is to allow the instances creation for this class
        * @param {Variable} variable The variable in which the production is associated
        * @param {String} production The string production that the variable will have
        */
        public Production(Variable variable, String production) {
            this.variable = variable;
            this.production = production;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is the getter method for the variable in which the production is associated
        * @returns {Variables} Variable in which the production is associated
        */
        public Variable getVariable()
        {
            return variable;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is to set another value for the variable in which the production is associated
        * <b>pre:</b> The input variable needs to be != null
        * @param {Variables} variable New value that you want to assign for the variable in which the production is associated
        * @returns The method is void, so it does not have return
        */
        public void setVariable(Variable variable)
        {
            this.variable = variable;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is the getter method for the production string
        * @returns {String} String belong to the production chain
        */
        public String getProduction()
        {
            return production;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is to set another value for production string
        * <b>pre:</b> The input production needs to be != null
        * @param {String} production The new production string that you want to assign
        * @returns The method is void, so it does not have return
        */
        public void setProduction(String production)
        {
            this.production = production;
        }

    }
}
