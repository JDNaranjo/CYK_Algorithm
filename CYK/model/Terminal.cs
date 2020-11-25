using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYK.model
{
    class Terminal
    {
        private String name;

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is to allow the instances creation for this class
        * @param {String} name The name of the terminal that is being created
        */
        public Terminal(String name) {
            this.name = name;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is the getter method for the name of the terminal
        * @returns {String} String belong to the terminal name
        */
        public String getName()
        {
            return name;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is to set another value for the terminal name
        * <b>pre:</b> The input name needs to be != null
        * @param {String} name The name you want to assign for the actual terminal
        * @returns The method is void, so it does not have return
        */
        public void setName(String name)
        {
            this.name = name;
        }
    }
}
